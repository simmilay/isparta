using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace isparta
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 6)
            {

                i = 0;
            }
            pictureBox1.Image = imageList1.Images[i];
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            pictureBox1.Image = imageList1.Images[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1sec = new Form1();
            frm1sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation =
                @"C:\Users\Sıla Ayas\Desktop\ders\isparta\isparta\sarki\Ruhi-Su-Isparta-Zeybeği.wav";
            ses.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation =
                @"C:\Users\Sıla Ayas\Desktop\ders\isparta\isparta\sarki\Ruhi-Su-Isparta-Zeybeği.wav";
            ses.Stop();
        }
    }
}
