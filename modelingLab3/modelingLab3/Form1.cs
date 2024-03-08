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
                    rule = rule.Insert(0, "0"); // Заполнение нулями слева до полноты.
            }

            if (activeFirstTime)
            {
                FirstLine = new List<int>(new int[15]);
                for (int i = 0; i < FirstLine.Count; i++)
                    FirstLine[i] = 0;

                    FirstLine[7] = 1;
                    FirstLine[8] = 1;
                    FirstLine[12] = 1;
                    colors[7, 0] = Color.Green;
                    colors[8, 0] = Color.Green;
                    colors[12, 0] = Color.Green;

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
        int generation = 1;

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
        bool First = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (First == true) // Хак с пропуском первой строки.
                First = false;
            else
                for (int i = 0; i < otherLine.Count; i++)
                    line[i] = otherLine[i];

            for (int i = 1; i < line.Count - 1; i++)
            {
                string Result = line[i - 1].ToString() + line[i].ToString() + line[i + 1].ToString();
                otherLine[i] = check(Result); //Левая ячейка, центральная и правая.
                if (otherLine[i] == 1)
                    colors[i, generation] = Color.Green;
            }

            tableLayout.Refresh();
            generation++;

            if (generation == 13)
            {
                timer1.Stop();
                generation = 0;
                startButton.Enabled = false;
            }
        }

        private void tableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruleSP_ValueChanged(object sender, EventArgs e)
        {
            String buffer = Convert.ToString((int)ruleSP.Value, 2);
            if (buffer.Length != 8)
            {
                int len = 8 - buffer.Length;
                for (int i = 0; i < len; i++)
                    buffer = buffer.Insert(0, "0");
            }
            decodedText.Text = buffer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 14; j++)
                    colors[i, j] = SystemColors.Control;
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
