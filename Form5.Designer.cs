namespace isparta
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            ımageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(29, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(703, 422);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Elephant", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(29, 35);
            label2.Name = "label2";
            label2.Size = new Size(240, 56);
            label2.TabIndex = 1;
            label2.Text = "TARİHİ";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "1c1c66f4-d4a9-45b0-80aa-7351771361a0-min.jpg");
            ımageList1.Images.SetKeyName(1, "24c553eb-d9ff-476e-ae1c-7a1a084176d1-min.jpg");
            ımageList1.Images.SetKeyName(2, "14147104-b599-4fce-9416-832f2884ad67-min.jpg");
            ımageList1.Images.SetKeyName(3, "af425c49-675a-4a28-9003-5f14320567cf-min.jpg");
            ımageList1.Images.SetKeyName(4, "Egirdir-Kalesi-min.jpg");
            ımageList1.Images.SetKeyName(5, "Ekran görüntüsü 2023-04-16 143607-min.jpg");
            ımageList1.Images.SetKeyName(6, "ISPARTA-YALVAÇ-PISIDA ANTIOKHEIA ANTİK KENTİ-AUGUSTUS KUTSAL ALANI-GÜLCAN ACAR (8)-min.jpg");
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(817, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 320);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Linen;
            label3.Location = new Point(817, 451);
            label3.Name = "label3";
            label3.Size = new Size(317, 140);
            label3.TabIndex = 0;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1197, 618);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Form5";
            Text = "TARİHİ";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}