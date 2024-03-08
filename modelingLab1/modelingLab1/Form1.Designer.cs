namespace modelingLab1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.heightSP = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.Label();
            this.timeSP = new System.Windows.Forms.NumericUpDown();
            this.chartLab1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.launch = new System.Windows.Forms.Button();
            this.weightSP = new System.Windows.Forms.NumericUpDown();
            this.sizeSP = new System.Windows.Forms.NumericUpDown();
            this.speedSP = new System.Windows.Forms.NumericUpDown();
            this.angleSP = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.heightSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // heightSP
            // 
            this.heightSP.Location = new System.Drawing.Point(59, 17);
            this.heightSP.Name = "heightSP";
            this.heightSP.Size = new System.Drawing.Size(59, 20);
            this.heightSP.TabIndex = 0;
            this.heightSP.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.time.Location = new System.Drawing.Point(5, 156);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(56, 13);
            this.time.TabIndex = 10;
            this.time.Text = "Time step:";
            // 
            // timeSP
            // 
            this.timeSP.DecimalPlaces = 2;
            this.timeSP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeSP.Location = new System.Drawing.Point(59, 153);
            this.timeSP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeSP.Name = "timeSP";
            this.timeSP.Size = new System.Drawing.Size(59, 20);
            this.timeSP.TabIndex = 9;
            this.timeSP.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // chartLab1
            // 
            this.chartLab1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartLab1.BorderlineWidth = 4;
            chartArea3.Name = "ChartArea1";
            this.chartLab1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartLab1.Legends.Add(legend3);
            this.chartLab1.Location = new System.Drawing.Point(12, 205);
            this.chartLab1.Name = "chartLab1";
            this.chartLab1.Size = new System.Drawing.Size(760, 314);
            this.chartLab1.TabIndex = 4;
            this.chartLab1.Click += new System.EventHandler(this.chartLab1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // launch
            // 
            this.launch.Location = new System.Drawing.Point(12, 179);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(106, 20);
            this.launch.TabIndex = 1;
            this.launch.Text = "Launch";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click_1);
            // 
            // weightSP
            // 
            this.weightSP.DecimalPlaces = 2;
            this.weightSP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.weightSP.Location = new System.Drawing.Point(59, 123);
            this.weightSP.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.weightSP.Name = "weightSP";
            this.weightSP.Size = new System.Drawing.Size(59, 20);
            this.weightSP.TabIndex = 0;
            this.weightSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightSP.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // sizeSP
            // 
            this.sizeSP.DecimalPlaces = 2;
            this.sizeSP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.sizeSP.Location = new System.Drawing.Point(59, 97);
            this.sizeSP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizeSP.Name = "sizeSP";
            this.sizeSP.Size = new System.Drawing.Size(59, 20);
            this.sizeSP.TabIndex = 0;
            this.sizeSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sizeSP.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // speedSP
            // 
            this.speedSP.Location = new System.Drawing.Point(59, 69);
            this.speedSP.Name = "speedSP";
            this.speedSP.Size = new System.Drawing.Size(59, 20);
            this.speedSP.TabIndex = 0;
            this.speedSP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedSP.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // angleSP
            // 
            this.angleSP.Location = new System.Drawing.Point(59, 43);
            this.angleSP.Name = "angleSP";
            this.angleSP.Size = new System.Drawing.Size(59, 20);
            this.angleSP.TabIndex = 0;
            this.angleSP.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.angleSP.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(650, 182);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.timeSP);
            this.Controls.Add(this.chartLab1);
            this.Controls.Add(this.sizeSP);
            this.Controls.Add(this.heightSP);
            this.Controls.Add(this.angleSP);
            this.Controls.Add(this.speedSP);
            this.Controls.Add(this.weightSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            ((System.ComponentModel.ISupportInitialize)(this.heightSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button launch;  
        private System.Windows.Forms.NumericUpDown heightSP;
        private System.Windows.Forms.NumericUpDown weightSP;
        private System.Windows.Forms.NumericUpDown sizeSP;
        private System.Windows.Forms.NumericUpDown speedSP;
        private System.Windows.Forms.NumericUpDown angleSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLab1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.NumericUpDown timeSP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

