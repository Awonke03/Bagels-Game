namespace BagelsGame
{
    partial class Bagels
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
            btnplay = new Button();
            lblg = new Label();
            rtbhints = new RichTextBox();
            rtbguess = new RichTextBox();
            nudguess = new NumericUpDown();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudguess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnplay
            // 
            btnplay.Location = new Point(268, 434);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(94, 29);
            btnplay.TabIndex = 0;
            btnplay.Text = "Play";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // lblg
            // 
            lblg.AutoSize = true;
            lblg.Location = new Point(151, 199);
            lblg.Name = "lblg";
            lblg.Size = new Size(85, 20);
            lblg.TabIndex = 1;
            lblg.Text = "Enter Guess";
            // 
            // rtbhints
            // 
            rtbhints.Location = new Point(49, 230);
            rtbhints.Name = "rtbhints";
            rtbhints.Size = new Size(452, 198);
            rtbhints.TabIndex = 2;
            rtbhints.Text = "";
            // 
            // rtbguess
            // 
            rtbguess.Location = new Point(582, 193);
            rtbguess.Name = "rtbguess";
            rtbguess.Size = new Size(257, 225);
            rtbguess.TabIndex = 4;
            rtbguess.Text = "";
            // 
            // nudguess
            // 
            nudguess.Location = new Point(293, 197);
            nudguess.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudguess.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudguess.Name = "nudguess";
            nudguess.Size = new Size(150, 27);
            nudguess.TabIndex = 5;
            nudguess.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(705, 43);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(705, 100);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "New Game";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.f1;
            pictureBox1.Location = new Point(12, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(715, 348);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Bagels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 486);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(nudguess);
            Controls.Add(rtbguess);
            Controls.Add(rtbhints);
            Controls.Add(lblg);
            Controls.Add(btnplay);
            Controls.Add(pictureBox1);
            Name = "Bagels";
            Text = "Form1";
            Load += Bagels_Load;
            ((System.ComponentModel.ISupportInitialize)nudguess).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnplay;
        private Label lblg;
        private RichTextBox rtbhints;
        private RichTextBox rtbguess;
        private NumericUpDown nudguess;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
    }
}