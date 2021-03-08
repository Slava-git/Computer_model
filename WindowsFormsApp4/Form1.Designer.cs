namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.btnx10 = new System.Windows.Forms.Button();
            this.btnx1 = new System.Windows.Forms.Button();
            this.btnDownIn2 = new System.Windows.Forms.Button();
            this.btnUpIn2 = new System.Windows.Forms.Button();
            this.lbValve = new System.Windows.Forms.Label();
            this.lbValve3 = new System.Windows.Forms.Label();
            this.btnUpIn3 = new System.Windows.Forms.Button();
            this.btnDownIn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChPlot
            // 
            this.ChPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChPlot.Legends.Add(legend1);
            this.ChPlot.Location = new System.Drawing.Point(44, 217);
            this.ChPlot.Name = "ChPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "z(t)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Valve";
            this.ChPlot.Series.Add(series1);
            this.ChPlot.Series.Add(series2);
            this.ChPlot.Size = new System.Drawing.Size(677, 156);
            this.ChPlot.TabIndex = 1;
            this.ChPlot.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(358, 89);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 34);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(358, 138);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(96, 33);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnx10
            // 
            this.btnx10.Location = new System.Drawing.Point(358, 12);
            this.btnx10.Name = "btnx10";
            this.btnx10.Size = new System.Drawing.Size(75, 23);
            this.btnx10.TabIndex = 4;
            this.btnx10.Text = "x10";
            this.btnx10.UseVisualStyleBackColor = true;
            this.btnx10.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnx1
            // 
            this.btnx1.Location = new System.Drawing.Point(358, 41);
            this.btnx1.Name = "btnx1";
            this.btnx1.Size = new System.Drawing.Size(75, 23);
            this.btnx1.TabIndex = 5;
            this.btnx1.Text = "x1";
            this.btnx1.UseVisualStyleBackColor = true;
            this.btnx1.Click += new System.EventHandler(this.btnx1_Click);
            // 
            // btnDownIn2
            // 
            this.btnDownIn2.Location = new System.Drawing.Point(472, 13);
            this.btnDownIn2.Name = "btnDownIn2";
            this.btnDownIn2.Size = new System.Drawing.Size(42, 22);
            this.btnDownIn2.TabIndex = 6;
            this.btnDownIn2.Text = "<";
            this.btnDownIn2.UseVisualStyleBackColor = true;
            this.btnDownIn2.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUpIn2
            // 
            this.btnUpIn2.Location = new System.Drawing.Point(557, 14);
            this.btnUpIn2.Name = "btnUpIn2";
            this.btnUpIn2.Size = new System.Drawing.Size(42, 22);
            this.btnUpIn2.TabIndex = 7;
            this.btnUpIn2.Text = ">";
            this.btnUpIn2.UseVisualStyleBackColor = true;
            this.btnUpIn2.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lbValve
            // 
            this.lbValve.AutoSize = true;
            this.lbValve.Location = new System.Drawing.Point(520, 19);
            this.lbValve.Name = "lbValve";
            this.lbValve.Size = new System.Drawing.Size(13, 13);
            this.lbValve.TabIndex = 8;
            this.lbValve.Text = "0";
            // 
            // lbValve3
            // 
            this.lbValve3.AutoSize = true;
            this.lbValve3.Location = new System.Drawing.Point(520, 58);
            this.lbValve3.Name = "lbValve3";
            this.lbValve3.Size = new System.Drawing.Size(13, 13);
            this.lbValve3.TabIndex = 11;
            this.lbValve3.Text = "0";
            // 
            // btnUpIn3
            // 
            this.btnUpIn3.Location = new System.Drawing.Point(557, 53);
            this.btnUpIn3.Name = "btnUpIn3";
            this.btnUpIn3.Size = new System.Drawing.Size(42, 22);
            this.btnUpIn3.TabIndex = 10;
            this.btnUpIn3.Text = ">";
            this.btnUpIn3.UseVisualStyleBackColor = true;
            this.btnUpIn3.Click += new System.EventHandler(this.btnUpIn3_Click);
            // 
            // btnDownIn3
            // 
            this.btnDownIn3.Location = new System.Drawing.Point(472, 52);
            this.btnDownIn3.Name = "btnDownIn3";
            this.btnDownIn3.Size = new System.Drawing.Size(42, 22);
            this.btnDownIn3.TabIndex = 9;
            this.btnDownIn3.Text = "<";
            this.btnDownIn3.UseVisualStyleBackColor = true;
            this.btnDownIn3.Click += new System.EventHandler(this.btnDownIn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValve3);
            this.Controls.Add(this.btnUpIn3);
            this.Controls.Add(this.btnDownIn3);
            this.Controls.Add(this.lbValve);
            this.Controls.Add(this.btnUpIn2);
            this.Controls.Add(this.btnDownIn2);
            this.Controls.Add(this.btnx1);
            this.Controls.Add(this.btnx10);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ChPlot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChPlot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button btnx10;
        private System.Windows.Forms.Button btnx1;
        private System.Windows.Forms.Button btnDownIn2;
        private System.Windows.Forms.Button btnUpIn2;
        private System.Windows.Forms.Label lbValve;
        private System.Windows.Forms.Label lbValve3;
        private System.Windows.Forms.Button btnUpIn3;
        private System.Windows.Forms.Button btnDownIn3;
    }
}

