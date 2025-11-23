namespace qr_code_generation
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            btnGenerate = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 47);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 175);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 354);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 413);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 47);
            textBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(974, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 240);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.MediumSeaGreen;
            btnGenerate.ForeColor = SystemColors.ButtonFace;
            btnGenerate.Location = new Point(628, 557);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(232, 85);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerateqrCode;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 23);
            label3.Name = "label3";
            label3.Size = new Size(895, 81);
            label3.TabIndex = 7;
            label3.Text = "Generate Qr code kat stress lol";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 756);
            Controls.Add(label3);
            Controls.Add(btnGenerate);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button btnGenerate;
        private Label label3;
    }
}
