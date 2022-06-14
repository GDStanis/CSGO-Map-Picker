using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Map_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static Image img0 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Dust II.jpg");
        static Image img1 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Mirage.jpg");
        static Image img2 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Inferno.jpg");
        static Image img3 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Cache.jpg");
        static Image img4 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Overpass.jpg");
        static Image img5 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Nuke.jpg");
        static Image img6 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Train.jpg");
        static Image img7 = Image.FromFile(@"C:\Users\mi\Desktop\progs\C#\CSGO Map Picker\Img\Vertigo.jpg");

        Image[] picArr = new Image[] { img0, img1, img2, img3, img4, img5, img6, img7 };
        public static int dig1, dig2, dig3;
        //Random rand = new Random(); - pseudo-random numbers
        public static int rnd;

        public void m1_pusher_Tick(object sender, EventArgs e)
        {
            //dig1 = rand.Next(0, 8);
            dig1 = RandomNumberGenerator.GetInt32(0, 8);
            switch (dig1)
            {
                case 0:
                    pictureBox1.Image = img0;
                    break;
                case 1:
                    pictureBox1.Image = img1;
                    break;
                case 2:
                    pictureBox1.Image = img2;
                    break;
                case 3:
                    pictureBox1.Image = img3;
                    break;
                case 4:
                    pictureBox1.Image = img4;
                    break;
                case 5:
                    pictureBox1.Image = img5;
                    break;
                case 6:
                    pictureBox1.Image = img6;
                    break;
                case 7:
                    pictureBox1.Image = img7;
                    break;
            }
        }

        public void m2_pusher_Tick(object sender, EventArgs e)
        {
            //dig2 = rand.Next(0, 8);
            dig2 = RandomNumberGenerator.GetInt32(0, 8);
            switch (dig2)
            {
                case 0:
                    pictureBox2.Image = img0;
                    break;
                case 1:
                    pictureBox2.Image = img1;
                    break;
                case 2:
                    pictureBox2.Image = img2;
                    break;
                case 3:
                    pictureBox2.Image = img3;
                    break;
                case 4:
                    pictureBox2.Image = img4;
                    break;
                case 5:
                    pictureBox2.Image = img5;
                    break;
                case 6:
                    pictureBox2.Image = img6;
                    break;
                case 7:
                    pictureBox2.Image = img7;
                    break;
            }
        }

        public void m3_pusher_Tick(object sender, EventArgs e) 
        {
            //dig3 = rand.Next(0, 8);
            dig3 = RandomNumberGenerator.GetInt32(0, 8);
            switch (dig3)
            {
                case 0:
                    pictureBox3.Image = img0;
                    break;
                case 1:
                    pictureBox3.Image = img1;
                    break;
                case 2:
                    pictureBox3.Image = img2;
                    break;
                case 3:
                    pictureBox3.Image = img3;
                    break;
                case 4:
                    pictureBox3.Image = img4;
                    break;
                case 5:
                    pictureBox3.Image = img5;
                    break;
                case 6:
                    pictureBox3.Image = img6;
                    break;
                case 7:
                    pictureBox3.Image = img7;
                    break;
            }
        }

        private void m1_stopper_Tick(object sender, EventArgs e)
        {
            m1_pusher.Enabled = false;
        }

        private void m2_stopper_Tick(object sender, EventArgs e)
        {
            m2_pusher.Enabled = false;
        }

        private void m3_stopper_Tick(object sender, EventArgs e)
        {
            m3_pusher.Enabled = false;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            m1_pusher.Enabled = true;
            m2_pusher.Enabled = true;
            m3_pusher.Enabled = true;
            m1_stopper.Enabled = true;
            m2_stopper.Enabled = true;
            m3_stopper.Enabled = true;
        }
    }
}
