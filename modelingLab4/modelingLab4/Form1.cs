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
            m = (int)pictureBox1.Width / 8;
            n = (int)pictureBox1.Height / 8;
            map = new bool[m, n];
        }
        bool generated = false;
        void generateMap()
        {
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    map[i, j] = Convert.ToBoolean(rand.Next(0, 2));

            generated = true;
            activate.Text = "Запустить";
        }

        void drawMap()
        {
            var scale = (pictureBox1.Width / pictureBox1.Height) * (int)scaleSP.Value * 2;

            graphics.Clear(Color.White);

            for (int i = 0; i < pictureBox1.Width / 8; i++)
                for (int j = 0; j < pictureBox1.Height / 8; j++)
                    if (map[i, j])
                    {
                        graphics.DrawRectangle(pen, i * scale, j * scale, scale, scale);
                        graphics.FillRectangle(new SolidBrush(Color.Black), i * scale, j * scale, scale, scale);
                    }

            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    map[i, j] = false;
            drawMap();
            generated = false;
            timer1.Stop();
            activate.Text = "Запустить";
        }


        private void lifeTick()
        {

            bool[,] next = new bool[m, n];
            int neighbours;

            for (int i = 1; i < m - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    neighbours = 0;

                    if (map[i - 1, j - 1])
                        neighbours++;
                    if (map[i - 1, j])
                        neighbours++;
                    if (map[i - 1, j + 1])
                        neighbours++;
                    if (map[i, j - 1])
                        neighbours++; 
                    if (map[i, j + 1])
                        neighbours++;
                    if (map[i + 1, j - 1])
                        neighbours++; 
                    if (map[i + 1, j])
                        neighbours++; 
                    if (map[i + 1, j + 1])
                        neighbours++;

                    if (map[i, j])
                    {
                        if (neighbours >= (int)textBox1.Value && neighbours <= (int)textBox2.Value)
                            next[i, j] = true;
                        else
                            next[i, j] = false;
                    }
                    else
                    {
                        if (neighbours >= (int)textBox3.Value && neighbours <= (int)textBox4.Value)
                            next[i, j] = true;
                        else
                            next[i, j] = false;
                    }
                }
            }

            map = next;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (!generated)
                generateMap();
            
            lifeTick();
            drawMap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateMap();
            drawMap();
            timer1.Stop();
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
                    if (activate.Text == "Запустить")
                     {
                         activate.Text = "Остановить";
                          timer1.Start();
                      }
                      else
                      {
                          activate.Text = "Запустить";
                          timer1.Stop();
                      }
        }

        private void scaleSP_ValueChanged(object sender, EventArgs e)
        {
            drawMap();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timerSP_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)timerSP.Value;
        }
    }
}
