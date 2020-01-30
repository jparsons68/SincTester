namespace SincTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doubleBuffer1 = new ChartLib.DoubleBuffer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderTextControlQ = new IERSInterface.SliderTextControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderTextControlORATE = new IERSInterface.SliderTextControl();
            this.sliderTextControlFRATE = new IERSInterface.SliderTextControl();
            this.label6 = new System.Windows.Forms.Label();
            this.sliderTextControlNOISE = new IERSInterface.SliderTextControl();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBuffer1
            // 
            this.doubleBuffer1.BackColor = System.Drawing.Color.LightYellow;
            this.doubleBuffer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBuffer1.Freeze = false;
            this.doubleBuffer1.Location = new System.Drawing.Point(0, 0);
            this.doubleBuffer1.Name = "doubleBuffer1";
            this.doubleBuffer1.Size = new System.Drawing.Size(1114, 597);
            this.doubleBuffer1.TabIndex = 0;
            this.doubleBuffer1.Text = "doubleBuffer1";
            this.doubleBuffer1.PaintEvent += new System.Windows.Forms.PaintEventHandler(this.doubleBuffer1_PaintEvent);
            this.doubleBuffer1.Resize += new System.EventHandler(this.doubleBuffer1_Resize);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 597);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 132);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sliderTextControlQ, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sliderTextControlORATE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sliderTextControlFRATE, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sliderTextControlNOISE, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 214);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ORIGINAL RATE";
            // 
            // sliderTextControlQ
            // 
            this.sliderTextControlQ.Compact = false;
            this.sliderTextControlQ.DefaultValue = 10D;
            this.sliderTextControlQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderTextControlQ.LargeChange = 10D;
            this.sliderTextControlQ.Location = new System.Drawing.Point(97, 91);
            this.sliderTextControlQ.Margin = new System.Windows.Forms.Padding(1);
            this.sliderTextControlQ.Maximum = 30D;
            this.sliderTextControlQ.Minimum = 1D;
            this.sliderTextControlQ.Name = "sliderTextControlQ";
            this.sliderTextControlQ.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderTextControlQ.Size = new System.Drawing.Size(1016, 28);
            this.sliderTextControlQ.SmallChange = 1D;
            this.sliderTextControlQ.TabIndex = 2;
            this.sliderTextControlQ.TickFrequency = 2D;
            this.sliderTextControlQ.Value = 10D;
            this.sliderTextControlQ.ValueSlideChanged += new System.EventHandler<System.EventArgs>(this.sliderTextControlQ_ValueSlideChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "WIN WIDTH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FINAL RATE";
            // 
            // sliderTextControlORATE
            // 
            this.sliderTextControlORATE.Compact = false;
            this.sliderTextControlORATE.DefaultValue = 10D;
            this.sliderTextControlORATE.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderTextControlORATE.LargeChange = 10D;
            this.sliderTextControlORATE.Location = new System.Drawing.Point(97, 1);
            this.sliderTextControlORATE.Margin = new System.Windows.Forms.Padding(1);
            this.sliderTextControlORATE.Maximum = 100D;
            this.sliderTextControlORATE.Minimum = 1D;
            this.sliderTextControlORATE.Name = "sliderTextControlORATE";
            this.sliderTextControlORATE.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderTextControlORATE.Size = new System.Drawing.Size(1016, 28);
            this.sliderTextControlORATE.SmallChange = 1D;
            this.sliderTextControlORATE.TabIndex = 0;
            this.sliderTextControlORATE.TickFrequency = 10D;
            this.sliderTextControlORATE.Value = 10D;
            this.sliderTextControlORATE.ValueSlideChanged += new System.EventHandler<System.EventArgs>(this.sliderTextControlORATE_ValueSlideChanged);
            // 
            // sliderTextControlFRATE
            // 
            this.sliderTextControlFRATE.Compact = false;
            this.sliderTextControlFRATE.DefaultValue = 1D;
            this.sliderTextControlFRATE.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderTextControlFRATE.LargeChange = 10D;
            this.sliderTextControlFRATE.Location = new System.Drawing.Point(97, 61);
            this.sliderTextControlFRATE.Margin = new System.Windows.Forms.Padding(1);
            this.sliderTextControlFRATE.Maximum = 100D;
            this.sliderTextControlFRATE.Minimum = 1D;
            this.sliderTextControlFRATE.Name = "sliderTextControlFRATE";
            this.sliderTextControlFRATE.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderTextControlFRATE.Size = new System.Drawing.Size(1016, 28);
            this.sliderTextControlFRATE.SmallChange = 1D;
            this.sliderTextControlFRATE.TabIndex = 0;
            this.sliderTextControlFRATE.TickFrequency = 10D;
            this.sliderTextControlFRATE.Value = 1D;
            this.sliderTextControlFRATE.ValueSlideChanged += new System.EventHandler<System.EventArgs>(this.sliderTextControlFRATE_ValueSlideChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "NOISE %";
            // 
            // sliderTextControlNOISE
            // 
            this.sliderTextControlNOISE.Compact = false;
            this.sliderTextControlNOISE.DefaultValue = 10D;
            this.sliderTextControlNOISE.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderTextControlNOISE.LargeChange = 10D;
            this.sliderTextControlNOISE.Location = new System.Drawing.Point(97, 31);
            this.sliderTextControlNOISE.Margin = new System.Windows.Forms.Padding(1);
            this.sliderTextControlNOISE.Maximum = 100D;
            this.sliderTextControlNOISE.Minimum = 0D;
            this.sliderTextControlNOISE.Name = "sliderTextControlNOISE";
            this.sliderTextControlNOISE.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderTextControlNOISE.Size = new System.Drawing.Size(1016, 28);
            this.sliderTextControlNOISE.SmallChange = 0.5D;
            this.sliderTextControlNOISE.TabIndex = 0;
            this.sliderTextControlNOISE.TickFrequency = 10D;
            this.sliderTextControlNOISE.Value = 10D;
            this.sliderTextControlNOISE.ValueSlideChanged += new System.EventHandler<System.EventArgs>(this.sliderTextControlNOISE_ValueSlideChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 729);
            this.Controls.Add(this.doubleBuffer1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Sinc Tester";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartLib.DoubleBuffer doubleBuffer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private IERSInterface.SliderTextControl sliderTextControlQ;
        private IERSInterface.SliderTextControl sliderTextControlFRATE;
        private IERSInterface.SliderTextControl sliderTextControlORATE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private IERSInterface.SliderTextControl sliderTextControlNOISE;
    }
}

