namespace RekenmachineOpdracht_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbGetal1 = new TextBox();
            lblGetal1 = new Label();
            lblGetal2 = new Label();
            tbGetal2 = new TextBox();
            lblGetal3 = new Label();
            tbGetal3 = new TextBox();
            btnResultaat = new Button();
            btnResultaatM = new Button();
            btnResultaatX = new Button();
            btnResultaatD = new Button();
            btnResultaatW = new Button();
            btnResultaatTM = new Button();
            SuspendLayout();
            // 
            // tbGetal1
            // 
            tbGetal1.BackColor = Color.FromArgb(158, 251, 45);
            tbGetal1.Location = new Point(634, 34);
            tbGetal1.Name = "tbGetal1";
            tbGetal1.Size = new Size(125, 27);
            tbGetal1.TabIndex = 0;
            tbGetal1.TextChanged += textBox1_TextChanged;
            // 
            // lblGetal1
            // 
            lblGetal1.AutoSize = true;
            lblGetal1.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGetal1.ForeColor = Color.Red;
            lblGetal1.Location = new Point(519, 43);
            lblGetal1.Name = "lblGetal1";
            lblGetal1.Size = new Size(59, 18);
            lblGetal1.TabIndex = 1;
            lblGetal1.Text = "Getal1";
            lblGetal1.Click += lblGetal1_Click;
            // 
            // lblGetal2
            // 
            lblGetal2.AutoSize = true;
            lblGetal2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetal2.ForeColor = Color.FromArgb(255, 128, 0);
            lblGetal2.Location = new Point(519, 105);
            lblGetal2.Name = "lblGetal2";
            lblGetal2.Size = new Size(79, 27);
            lblGetal2.TabIndex = 2;
            lblGetal2.Text = "getal 2\r\n";
            // 
            // tbGetal2
            // 
            tbGetal2.BackColor = Color.FromArgb(255, 192, 255);
            tbGetal2.Location = new Point(634, 105);
            tbGetal2.Name = "tbGetal2";
            tbGetal2.Size = new Size(125, 27);
            tbGetal2.TabIndex = 3;
            // 
            // lblGetal3
            // 
            lblGetal3.AutoSize = true;
            lblGetal3.Font = new Font("Sitka Subheading", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGetal3.ForeColor = Color.DeepSkyBlue;
            lblGetal3.Location = new Point(46, 34);
            lblGetal3.Name = "lblGetal3";
            lblGetal3.Size = new Size(109, 33);
            lblGetal3.TabIndex = 4;
            lblGetal3.Text = "Resultaat";
            // 
            // tbGetal3
            // 
            tbGetal3.BackColor = Color.FromArgb(255, 192, 192);
            tbGetal3.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbGetal3.Location = new Point(177, 35);
            tbGetal3.Name = "tbGetal3";
            tbGetal3.Size = new Size(125, 34);
            tbGetal3.TabIndex = 5;
            tbGetal3.TextChanged += tbGetal3_TextChanged;
            // 
            // btnResultaat
            // 
            btnResultaat.BackColor = Color.FromArgb(64, 0, 0);
            btnResultaat.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultaat.ForeColor = Color.White;
            btnResultaat.Location = new Point(46, 252);
            btnResultaat.Name = "btnResultaat";
            btnResultaat.Size = new Size(94, 120);
            btnResultaat.TabIndex = 6;
            btnResultaat.Text = "+";
            btnResultaat.UseVisualStyleBackColor = false;
            btnResultaat.Click += btnResultaat_Click;
            // 
            // btnResultaatM
            // 
            btnResultaatM.BackColor = Color.FromArgb(64, 0, 0);
            btnResultaatM.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultaatM.ForeColor = Color.White;
            btnResultaatM.Location = new Point(46, 126);
            btnResultaatM.Name = "btnResultaatM";
            btnResultaatM.Size = new Size(94, 120);
            btnResultaatM.TabIndex = 8;
            btnResultaatM.Text = "-";
            btnResultaatM.UseVisualStyleBackColor = false;
            btnResultaatM.Click += btnResultaatM_Click;
            // 
            // btnResultaatX
            // 
            btnResultaatX.BackColor = Color.FromArgb(64, 0, 0);
            btnResultaatX.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultaatX.ForeColor = Color.White;
            btnResultaatX.Location = new Point(165, 252);
            btnResultaatX.Name = "btnResultaatX";
            btnResultaatX.Size = new Size(94, 120);
            btnResultaatX.TabIndex = 9;
            btnResultaatX.Text = "X";
            btnResultaatX.UseVisualStyleBackColor = false;
            btnResultaatX.Click += btnResultaatX_Click;
            // 
            // btnResultaatD
            // 
            btnResultaatD.BackColor = Color.FromArgb(64, 0, 0);
            btnResultaatD.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultaatD.ForeColor = Color.White;
            btnResultaatD.Location = new Point(165, 126);
            btnResultaatD.Name = "btnResultaatD";
            btnResultaatD.Size = new Size(94, 120);
            btnResultaatD.TabIndex = 10;
            btnResultaatD.Text = "/";
            btnResultaatD.UseVisualStyleBackColor = false;
            btnResultaatD.Click += btnResultaatD_Click;
            // 
            // btnResultaatW
            // 
            btnResultaatW.BackColor = Color.FromArgb(64, 0, 0);
            btnResultaatW.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultaatW.ForeColor = Color.White;
            btnResultaatW.Location = new Point(618, 252);
            btnResultaatW.Name = "btnResultaatW";
            btnResultaatW.Size = new Size(94, 120);
            btnResultaatW.TabIndex = 11;
            btnResultaatW.Text = "√";
            btnResultaatW.UseVisualStyleBackColor = false;
            btnResultaatW.Click += btnResultaatW_Click;
            // 
            // btnResultaatTM
            // 
            btnResultaatTM.BackColor = Color.FromArgb(64, 0, 0);
            btnResultaatTM.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultaatTM.ForeColor = Color.White;
            btnResultaatTM.Location = new Point(718, 252);
            btnResultaatTM.Name = "btnResultaatTM";
            btnResultaatTM.Size = new Size(96, 120);
            btnResultaatTM.TabIndex = 12;
            btnResultaatTM.Text = "X^";
            btnResultaatTM.UseVisualStyleBackColor = false;
            btnResultaatTM.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 384);
            Controls.Add(btnResultaatTM);
            Controls.Add(btnResultaatW);
            Controls.Add(btnResultaatD);
            Controls.Add(btnResultaatX);
            Controls.Add(btnResultaatM);
            Controls.Add(btnResultaat);
            Controls.Add(tbGetal3);
            Controls.Add(lblGetal3);
            Controls.Add(tbGetal2);
            Controls.Add(lblGetal2);
            Controls.Add(lblGetal1);
            Controls.Add(tbGetal1);
            Name = "Form1";
            Text = "Rekenmachine van Azfar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbGetal1;
        private Label lblGetal1;
        private Label lblGetal2;
        private TextBox tbGetal2;
        private Label lblGetal3;
        private TextBox tbGetal3;
        private Button btnResultaat;
        private Button btnResultaatM;
        private Button btnResultaatX;
        private Button btnResultaatD;
        private Button btnResultaatW;
        private Button btnResultaatTM;
    }
}
