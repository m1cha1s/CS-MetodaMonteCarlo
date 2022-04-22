namespace MetodaMonteCarlo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iterate = new System.Windows.Forms.Button();
            this.piLabel = new System.Windows.Forms.Label();
            this.piAproximation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // iterate
            // 
            this.iterate.Location = new System.Drawing.Point(481, 55);
            this.iterate.Name = "iterate";
            this.iterate.Size = new System.Drawing.Size(92, 23);
            this.iterate.TabIndex = 1;
            this.iterate.Text = "iterate";
            this.iterate.UseVisualStyleBackColor = true;
            this.iterate.Click += new System.EventHandler(this.iterate_Click);
            // 
            // piLabel
            // 
            this.piLabel.AutoSize = true;
            this.piLabel.Location = new System.Drawing.Point(481, 37);
            this.piLabel.Name = "piLabel";
            this.piLabel.Size = new System.Drawing.Size(13, 15);
            this.piLabel.TabIndex = 2;
            this.piLabel.Text = "0";
            // 
            // piAproximation
            // 
            this.piAproximation.AutoSize = true;
            this.piAproximation.Location = new System.Drawing.Point(481, 9);
            this.piAproximation.Name = "piAproximation";
            this.piAproximation.Size = new System.Drawing.Size(103, 15);
            this.piAproximation.TabIndex = 3;
            this.piAproximation.Text = "Current pi approx:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.piAproximation);
            this.Controls.Add(this.piLabel);
            this.Controls.Add(this.iterate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button iterate;
        private Label piLabel;
        private Label piAproximation;
        private System.Windows.Forms.Timer timer1;
    }
}