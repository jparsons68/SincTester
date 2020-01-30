namespace SincTester
{
    partial class AnimatorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doubleBuffer1 = new ChartLib.DoubleBuffer();
            this.SuspendLayout();
            // 
            // doubleBuffer1
            // 
            this.doubleBuffer1.BackColor = System.Drawing.Color.SteelBlue;
            this.doubleBuffer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBuffer1.Freeze = false;
            this.doubleBuffer1.Location = new System.Drawing.Point(0, 0);
            this.doubleBuffer1.Name = "doubleBuffer1";
            this.doubleBuffer1.Size = new System.Drawing.Size(558, 375);
            this.doubleBuffer1.TabIndex = 1;
            this.doubleBuffer1.Text = "doubleBuffer1";
            this.doubleBuffer1.PaintEvent += new System.Windows.Forms.PaintEventHandler(this.doubleBuffer1_PaintEvent);
            this.doubleBuffer1.VisibleChanged += new System.EventHandler(this.doubleBuffer1_VisibleChanged);
            this.doubleBuffer1.Resize += new System.EventHandler(this.doubleBuffer1_Resize);
            // 
            // AnimatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doubleBuffer1);
            this.Name = "AnimatorControl";
            this.Size = new System.Drawing.Size(558, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartLib.DoubleBuffer doubleBuffer1;
    }
}
