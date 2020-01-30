using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SincTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            regenerate();
            doubleBuffer1.Invalidate();
        }


        List<PointF> indat;
        List<PointF> outdat;
        int maxY = 100;
        double _oldFSR, _newFSR, _fMax, _ratioFreq;
        private void regenerate()
        {
            double w = doubleBuffer1.Width;
            maxY = doubleBuffer1.Height / 3;


            double dX = sliderTextControlORATE.Value;
            double rsDX = sliderTextControlFRATE.Value;
            double noise = sliderTextControlNOISE.Value * 0.01;
            _oldFSR = 1.0 / dX;
            _newFSR = 1.0 / rsDX;
            _ratioFreq = _newFSR / _oldFSR;

            if (_ratioFreq >= 0.5) _fMax = 0.5 * Math.Min(_oldFSR, _newFSR);
            else _fMax = _newFSR;

            List<double> indatY = new List<double>();
            indat = new List<PointF>();
            Random rand = new Random(17);
            for (double x = 0; x < w; x += dX)
            {
                double y = maxY * (Math.Sin(2 * Math.PI * x / 200) + 2 * (rand.NextDouble() - 0.5) * noise);
                indat.Add(new PointF((float)x, (float)y));
                indatY.Add(y);
            }
            outdat = new List<PointF>();
            int wnw = (int)sliderTextControlQ.Value;
            for (double x = 0; x < w; x += rsDX)
            {
                double rx = x / dX;
                double rY = Resample(rx, indatY, _fMax, _oldFSR, wnw);
                outdat.Add(new PointF((float)x, (float)rY));
            }
        }



        private void doubleBuffer1_PaintEvent(object sender, PaintEventArgs e)
        {

            var g = e.Graphics;

            g.TranslateTransform(0, doubleBuffer1.Height / 2);
            g.TranslateTransform(-3, -3);
            foreach (var pt in indat)
            {
                g.DrawRectangle(Pens.Black, pt.X, pt.Y, 7, 7);
            }
            g.TranslateTransform(3, 3);
            
            g.TranslateTransform(-2, -2);
            foreach (var pt in outdat)
            {
                g.FillRectangle(Brushes.Blue, pt.X, pt.Y, 5, 5);
            }
            g.TranslateTransform(2, 2);




            g.DrawLines(Pens.Red, indat.ToArray());
            g.DrawLines(Pens.Blue, outdat.ToArray());
            g.ResetTransform();

            g.DrawString("OLD FSR:" + _oldFSR, Font, Brushes.Black, 0, 0);
            g.DrawString("NEW FSR:" + _newFSR, Font, Brushes.Black, 0, 20);
            g.DrawString("RATIO:" + _ratioFreq, Font, Brushes.Black, 0, 40);
            g.DrawString("FMAX:" + _fMax, Font, Brushes.Black, 0, 60);
        }

        private void sliderTextControlORATE_ValueSlideChanged(object sender, EventArgs e)
        {
            regenerate();
            doubleBuffer1.Invalidate();
        }

        private void sliderTextControlFRATE_ValueSlideChanged(object sender, EventArgs e)
        {
            regenerate();
            doubleBuffer1.Invalidate();
        }

        private void sliderTextControlQ_ValueSlideChanged(object sender, EventArgs e)
        {
            regenerate();
            doubleBuffer1.Invalidate();
        }


        private void sliderTextControlNOISE_ValueSlideChanged(object sender, EventArgs e)
        {
            regenerate();
            doubleBuffer1.Invalidate();
        }

        private void doubleBuffer1_Resize(object sender, EventArgs e)
        {
            regenerate();
            doubleBuffer1.Invalidate();
        }



        public static double Resample(double x, List<double> indat, double fmax, double fsr, int wnwdth)
        {
            int alim = indat.Count;
            double fmaxDivFsr = fmax / fsr;
            double pi2 = 2 * Math.PI;
            double r_g = 2 * fmaxDivFsr; // Calc gain correction factor
            double r_y = 0;
            int ic = 0;
            int wnwdthHalf = wnwdth / 2;
            for (int i = -wnwdthHalf; i < wnwdthHalf; i++) // For 1 window width
            {
                // Calc input sample index
                int j = (int)(x + i);
                if ((j >= 0) && (j < alim))
                {
                    // calculate von Hann Window.Scale and calculate Sinc
                    double r_w = 0.5 - 0.5 * Math.Cos(pi2 * (0.5 + (j - x) / wnwdth));
                    double r_a = pi2 * (j - x) * fmaxDivFsr;
                    double r_snc = (r_a != 0) ? (Math.Sin(r_a) / r_a) : 1;
                    r_y += (r_g * r_w * r_snc * indat[j]);
                    ic++;
                }
            }

            return (ic > 0 ? r_y : double.NaN); // Return new filtered sample
        }


    }
}
