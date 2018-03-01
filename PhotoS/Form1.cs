using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PhotoS
{
    public partial class Form1 : Form
    {
        public string Ritorna;

        OpenFileDialog dlg;

        public Form1()
        {
            MessageBox.Show("Gli effetti richiediono tempo per essere applicati su immagini ad alta definizione");
            InitializeComponent();
            dlg = new OpenFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
           
        public void carica()
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Immagini";
            dlg.Filter = "Immagini|*.jpeg; *.jpg; *.png;";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                pictureBox2.Image = Image.FromFile(dlg.FileName);
                Ritorna = dlg.FileName;
                
            }
            dlg.Dispose();

        }
        public void Salva()
        {
            saveFileDialog1.Filter = "Image|*.jpg|Image|*.png";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
        }
        public void Ruota()
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox2.Refresh();
        }
        public void Ruota2()
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox2.Refresh();
        }
           //Effetti
        public void Grigioo()
        {
            Bitmap bmp;
            bmp = new Bitmap(Ritorna);


            int width = bmp.Width;
            int height = bmp.Height;

           
            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bmp.SetPixel(x, y, Grigio.Grigg(bmp.GetPixel(x, y)));
                }
            }
            pictureBox2.Image = bmp;

        }
        public void Seppiaa()
        {
            Bitmap bmp;
            bmp = new Bitmap(Ritorna);
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bmp.SetPixel(x, y, Seppia.Sepp(bmp.GetPixel(x,y)));
                }
               
            }
            pictureBox2.Image = bmp;

        }
        public void Alteraa()
        {
            Bitmap bmp;
            bmp = new Bitmap(Ritorna);
            int width = bmp.Width;
            int height = bmp.Height;

           
            Color p;

            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bmp.SetPixel(x, y, Altera.Alt(bmp.GetPixel(x, y)));
                }
                pictureBox2.Image = bmp;
            }

        }
        public void Negativoo()
        {
            Bitmap bmp;
            bmp = new Bitmap(Ritorna);
            int width = bmp.Width;
            int height = bmp.Height; 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    bmp.SetPixel(x, y, Negativo.Nega(bmp.GetPixel(x, y)));
                }
            }
            pictureBox2.Image = bmp;
        }
        public void Distruggii()
        {
            

            Bitmap bmp;
            bmp = new Bitmap(Ritorna);
            

            int width = bmp.Width;
            int height = bmp.Height;
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    bmp.SetPixel(x, y, Distruggi.Dist(bmp.GetPixel(x, y)));
                }
            }
            pictureBox2.Image = bmp;
        }
       

    private void btnfind_Click(object sender, EventArgs e)
        {
            carica();
        }
    private void button1_Click(object sender, EventArgs e)
        {
            Ruota();
        }
    private void button2_Click(object sender, EventArgs e)
        {
            Salva();
        }
    private void button3_Click(object sender, EventArgs e)
        {
            Grigioo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void btnseppia_Click(object sender, EventArgs e)
        {
            Seppiaa();
        }
        private void btnrandom_Click(object sender, EventArgs e)
        {
            Alteraa();
        }
        private void btntext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Questo è un pò più lungo ;)");
            Distruggii();
        }
        private void btnnegativo_Click(object sender, EventArgs e)
        {
            Negativoo();
        }        
        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Ruota2();
        }
    }
}
