using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelingLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double g = 9.81, C = 0.15, rho = 1.29;
        double height, angle, speed, size, mass, maxY, cosa, sina, k;
        double dt;
        double x, y, vx, vy;
        int i = 0;

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {}

       

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = false;

            for (int i = 0; i < 6; i++)
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
            for (int i = 0; i < 5; i++) 
                dataGridView1.Rows.Add();
            
            for (int i = 0; i < 6; i++)
            {
                chartLab1.Series.Add("");
                chartLab1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartLab1.Series[i].BorderWidth = 3;
            }
            dataGridView1.Rows[0].HeaderCell.Value = "Time step";
            dataGridView1.Rows[1].HeaderCell.Value = "Distance";
            dataGridView1.Rows[2].HeaderCell.Value = "Max Height";
            dataGridView1.Rows[3].HeaderCell.Value = "Last Speed";
            dataGridView1.Rows[4].HeaderCell.Value = "Color";
        }

        private void launch_Click_1(object sender, EventArgs e)
        {
            if (i == 6)
            {   
                for (int j = 0; j < 5; j++) 
                    for (int k = 0; k < 6; k++)
                    {
                        chartLab1.Series[k].Points.Clear();
                        dataGridView1.Rows[j].Cells[k].Value = "";
                        dataGridView1.Rows[j].Cells[k].Value = "";
                        dataGridView1.Rows[j].Cells[k].Value = "";
                        dataGridView1.Rows[j].Cells[k].Value = "";
                        dataGridView1.Rows[j].Cells[k].Value = "";
                    }
                
                i = 0;
                launch.Text = "Launch";
            }

            dt = (double)timeSP.Value;
            height = (double)heightSP.Value;
            angle = (double)angleSP.Value;
            speed = (double)speedSP.Value;
            size = (double)sizeSP.Value;
            mass = (double)weightSP.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);
            dataGridView1.Rows[0].Cells[i].Value = dt.ToString();

            k = 0.5 * C * size * rho / mass;
            x = 0;
            y = height;
            vx = speed * cosa;
            vy = speed * sina;

            chartLab1.Series[i].Points.AddXY(x, y);

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double v = (double)Math.Sqrt((double)(vx * vx + vy * vy));
            
            vx = vx - k * vx * v * dt; // скорость по х
            vy = vy - (g + k * vy * v) * dt; // скорость по y
            x = x + vx * dt; // перемещение по х
            y = y + vy * dt; // перемещение по y
            if (y > maxY) 
                maxY = y; // Макс высота

            chartLab1.Series[i].Points.AddXY(x, y);

            if (y <= 0) { 
                timer2.Stop();
                dataGridView1.Rows[1].Cells[i].Value = x.ToString();
                dataGridView1.Rows[2].Cells[i].Value = maxY.ToString();
                dataGridView1.Rows[3].Cells[i].Value = v.ToString();
                dataGridView1.Rows[4].Cells[i].Value = chartLab1.Series[i].BorderColor;
                i++;
            }

            if (i == 6) { 
                launch.Text = "Reset ?";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {}

        private void chartLab1_Click(object sender, EventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {}
    }
}
