using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SincTester
{
    public partial class AnimatorControl : UserControl
    {
        Timer timer;

        List<AnimatorTrace> traceList = new List<AnimatorTrace>();
        public AnimatorControl()
        {
            InitializeComponent();
            _initialize();

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void _initialize()
        {
            traceList.Clear();
            Random rand = new Random();

            float xpos = -50;

            int ntrace = Width / 100;
            for (int i = 0; ; i++)
            {
                xpos += AnimatorRandom.RandF(50f, 100f);
                Color color = Color.FromArgb(rand.Next(100), Color.White);
                var aT = new AnimatorTrace(color,
                    (float)rand.Next(1, 10),
                    xpos,
                     (float)Math.Pow(10, AnimatorRandom.RandF(1, 1.8f)),
                      (float)AnimatorRandom.RandF(-1.3f, 1.3f));
                aT.Bounds = doubleBuffer1.Bounds;
                aT.Initialize();
                traceList.Add(aT);
                if (xpos > Width) break;
            }


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var trace in traceList)
            {
                trace.Increment();
            }

            doubleBuffer1.Refresh();
        }

        private void doubleBuffer1_PaintEvent(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            foreach (var trace in traceList)
            {
                trace.Draw(graphics);
            }
        }


        private void doubleBuffer1_Resize(object sender, EventArgs e)
        {
            _initialize();
        }

        private void doubleBuffer1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && !timer.Enabled)
                timer.Start();
            if (!this.Visible && timer.Enabled)
                timer.Stop();
        }
    }

    static class AnimatorRandom
    {
        static Random rand = new Random();

        public static PointF RandPointF(float x0, float x1, float y0, float y1)
        {
            return (new PointF(RandF(x0, x1), RandF(y0, y1)));
        }

        public static float RandF(float v0, float v1)
        {
            return ((float)(v0 + rand.NextDouble() * (v1 - v0)));
        }

        internal static double RandD(float dX)
        {
            return ((float)(rand.NextDouble() * dX));
        }
    }

    class AnimatorTrace
    {
        List<PointF> _components = null;

        PointF[] ptArr = null;
        float _dX = 50;
        Pen _pen;
        private float _transY;
        float X;
        public AnimatorTrace(Color col, float lw, float x, float w, float speed)
        {
            _pen = new Pen(col, lw);
            X = x;
            _pen.MiterLimit = 10;
            _pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            Speed = speed;
            _dX = w;
        }
        public Rectangle Bounds { get; set; }
        public float Speed { get; set; } = 2;
        int _bigBufferAmt = 50;
        public void Increment()
        {
            _transY += Speed;

            if (Math.Abs(_transY) > _bigBufferAmt)
            {
                if (_transY > 0)
                {
                    _transY -= _bigBufferAmt;
                }
                else 
                {
                    _transY += _bigBufferAmt;
                }
            }

        }



        internal void Draw(Graphics graphics)
        {
            graphics.TranslateTransform(X, -_bigBufferAmt - _transY);
            graphics.DrawLines(_pen, ptArr);
            graphics.ResetTransform();
        }



        int _nEdge = 10;
        int _arrayLen;
        int _dY = 5;
        private int _nComponents = 6;

        internal void Initialize()
        {
            _bigBufferAmt = _nEdge * _dY;
            _arrayLen = (int)(Bounds.Height / _dY);
            _arrayLen += _nEdge;
            _arrayLen += _nEdge;

            _components = new List<PointF>();
            for (int j = 0; j < _nComponents; j++)
            {
                _components.Add(new PointF(AnimatorRandom.RandF(0, 3.14f), AnimatorRandom.RandF(1, 50)));
            }

            List<PointF> points = new List<PointF>();
            for (int i = 0; i < _arrayLen; i++)
            {
                float rv = _calcValue(i);
                points.Add(new PointF(rv, i * _dY));
            }

            ptArr = points.ToArray();

        }

        private float _calcValue(int i)
        {
            float v = 0;
            double pi2 = Math.PI * 2;
            for (int j = 0; j < _nComponents; j++)
            {
                v += (float)Math.Sin(pi2 * i / _components[j].Y + _components[j].X);
            }
            return (_dX * v / _nComponents);
        }
    }


}

