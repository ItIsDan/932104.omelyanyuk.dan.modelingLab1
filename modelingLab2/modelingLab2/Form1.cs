using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelingLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double rateEuro, rateDollar; 
        const double k = 0.1; 
        readonly Random random = new Random();
        bool isActive = true; 
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            rateEuro = rateEuro * (1 + k * (random.NextDouble() - 0.5)); 
            rateDollar = rateDollar * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(0, rateEuro);
            chart1.Series[1].Points.AddXY(0, rateDollar);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear(); 
            chart1.Series[1].Points.Clear();
            isActive = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Legends.Add("euro");
            chart1.Series.Add("euro");
            
            chart1.Legends.Add("dollar");
            chart1.Series.Add("dollar");

            for (int i = 0; i < 2; i++)
            {
                chart1.Series[i].IsValueShownAsLabel = true;
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[i].BorderWidth = 3;
                chart1.Series[i].SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
                chart1.Series[i].SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
                chart1.Series[i].LabelFormat = "f3";
                chart1.Series[i].IsXValueIndexed = true;
            }   
        }

        private void init_Click(object sender, EventArgs e)
        {
            if (isActive) {
                rateEuro = (double)euroSP.Value; 
                rateDollar = (double)dollarSP.Value; 
                chart1.Series[0].Points.Clear(); 
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(0, rateEuro);
                chart1.Series[1].Points.AddXY(0, rateDollar);
            }
            isActive = false;

            if (initButton.Text == "Старт") {
                initButton.Text = "Стоп";
                timer1.Start(); 
            } else {
                initButton.Text = "Старт";
                timer1.Stop();
            }
        }
    }
}
