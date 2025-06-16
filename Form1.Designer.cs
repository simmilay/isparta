namespace isparta
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.ImageKey = "(none)";
            button2.Location = new Point(56, 230);
            button2.Name = "button2";
            button2.Size = new Size(160, 32);
            button2.TabIndex = 3;
            button2.Text = "YEMEKLER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(233, 294);
            button3.Name = "button3";
            button3.Size = new Size(122, 26);
            button3.TabIndex = 4;
            button3.Text = "YÖRESEL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Location = new Point(72, 385);
            button4.Name = "button4";
            button4.Size = new Size(157, 31);
            button4.TabIndex = 5;
            button4.Text = "TARİHİ ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Bell MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageKey = "(none)";
            button1.Location = new Point(205, 131);
            button1.Name = "button1";
            button1.Size = new Size(105, 49);
            button1.TabIndex = 2;
            button1.Text = "GEZİLECEK YERLER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1197, 618);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Bell MT", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ISPARTA";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
    }
}