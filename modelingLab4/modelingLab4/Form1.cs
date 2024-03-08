using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelingLab4
{
    public partial class Form1 : Form
    {
        bool[,] map;

        Bitmap bitmap;
        Graphics graphics;
        Random rand = new Random();
        Pen pen = new Pen(Color.Black, 1);

        int m;
        int n;

        public Form1()
        {
            InitializeComponent();
            m = (int)pictureBox1.Width - 1 / 4;
            n = (int)pictureBox1.Height - 1 / 4;
            map = new bool[m, n];
        }

        void generateMap()
        {
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    map[i, j] = Convert.ToBoolean(rand.Next(0, 2));
        }

        void drawMap()
        {
            var scale = (pictureBox1.Width / pictureBox1.Height) * (int)scaleSP.Value;

            graphics.Clear(Color.White);

            for (int i = 0; i < pictureBox1.Width / 4; i++)
            {
                for (int j = 0; j < pictureBox1.Height / 4; j++)
                { 
                    if (map[i, j])
                    {
                        graphics.DrawRectangle(pen, i * scale, j * scale, scale, scale);
                        graphics.FillRectangle(new SolidBrush(Color.Black), i * scale, j * scale, scale, scale);
                    }
                }
            }

            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    map[i, j] = false;
            drawMap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateMap();
            drawMap();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void activate_Click(object sender, EventArgs e)
        {

        }

        private void scaleSP_ValueChanged(object sender, EventArgs e)
        {
            drawMap();
        }
    }
}
