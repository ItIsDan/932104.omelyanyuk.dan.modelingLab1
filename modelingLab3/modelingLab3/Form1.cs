using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelingLab3
{
    public partial class Form1 : Form
    {
        string rule;
        List<int> FirstLine;
        Color[,] colors = new Color[15, 14];
        List<int> line = new List<int>(new int[15]);
        List<int> otherLine = new List<int>(new int[15]);

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 14; j++)
                    colors[i, j] = SystemColors.Control;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool activeFirstTime = true;
        private void startButton_Click(object sender, EventArgs e)
        {
            tableLayout.Refresh();
            rule = Convert.ToString((int)ruleSP.Value, 2); // Конвертация числа в основание двойки
            if (rule.Length != 8)
            {
                int len = 8 - rule.Length;
                for (int i = 0; i < len; i++)
                    rule = rule.Insert(0, "0");
            }

            if (activeFirstTime)
            {
                FirstLine = new List<int>(new int[15]);
                for (int i = 0; i < FirstLine.Count; i++)
                    FirstLine[i] = 0;

                    FirstLine[7] = 1;
                    FirstLine[8] = 1;
                    FirstLine[12] = 1;
                    colors[7, 0] = Color.Black;
                    colors[8, 0] = Color.Black;
                    colors[12, 0] = Color.Black;

                for (int i = 0; i < otherLine.Count; i++)
                    otherLine[i] = 0;

                tableLayout.Refresh();
                line = FirstLine;
            }
            activeFirstTime = false;

            if (startButton.Text == "Start")
            {
                startButton.Text = "Stop";
                timer1.Start();
            } 
            else 
            {
                startButton.Text = "Start";
                timer1.Stop();
            }
        }
        int Count = 1;

        public int check(string help)
        {
            switch (help)
            {
                case "110":
                    return rule[1] - 48;
                case "101":
                    return rule[2] - 48;
                case "011":
                    return rule[4] - 48;
                case "010":
                    return rule[5] - 48;
                case "100":
                    return rule[3] - 48;
                case "000":
                    return rule[7] - 48;
                case "111":
                    return rule[0] - 48;
                case "001":
                    return rule[6] - 48;
                default:
                    return rule[0] - 48;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           for (int i = 0; i < otherLine.Count; i++)
                 line[i] = otherLine[i];

            for (int i = 0; i < line.Count; i++)
            {
                if (i != 0 && i != line.Count - 1)
                {
                    string Result = "";
                    Result = line[i - 1].ToString() + line[i].ToString() + line[i + 1].ToString();
                    int result = check(Result);
                    otherLine[i] = result;
                    
                    if (otherLine[i] == 0)
                    {
                        colors[i, Count] = Color.Green;
                    }
                }
            }

            tableLayout.Refresh();
            Count++;

            if (Count == 13)
            {
                timer1.Stop();
                startButton.Enabled = false;
            }
        }

        private void tableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruleSP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayout_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (colors != null)
            {
                SolidBrush brush = new SolidBrush(colors[e.Column, e.Row]);
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }
        }
    }
}
