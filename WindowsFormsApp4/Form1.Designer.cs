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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tbPIDK = new System.Windows.Forms.TextBox();
            this.tbPIDTi = new System.Windows.Forms.TextBox();
            this.tbPIDKd = new System.Windows.Forms.TextBox();
            this.lbPIDK = new System.Windows.Forms.Label();
            this.lbPIDTi = new System.Windows.Forms.Label();
            this.lbPIDKi = new System.Windows.Forms.Label();
            this.tbSetpoint = new System.Windows.Forms.TextBox();
            this.btSpUp = new System.Windows.Forms.Button();
            this.btSpDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutoMode = new System.Windows.Forms.Button();
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
            chartArea3.Name = "ChartArea1";
            this.ChPlot.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChPlot.Legends.Add(legend3);
            this.ChPlot.Location = new System.Drawing.Point(44, 217);
            this.ChPlot.Name = "ChPlot";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "z(t)";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Valve";
            this.ChPlot.Series.Add(series5);
            this.ChPlot.Series.Add(series6);
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
            this.Start.Location = new System.Drawing.Point(323, 92);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 34);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(323, 141);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(96, 33);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnx10
            // 
            this.btnx10.Location = new System.Drawing.Point(323, 13);
            this.btnx10.Name = "btnx10";
            this.btnx10.Size = new System.Drawing.Size(75, 23);
            this.btnx10.TabIndex = 4;
            this.btnx10.Text = "x10";
            this.btnx10.UseVisualStyleBackColor = true;
            this.btnx10.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnx1
            // 
            this.btnx1.Location = new System.Drawing.Point(323, 42);
            this.btnx1.Name = "btnx1";
            this.btnx1.Size = new System.Drawing.Size(75, 23);
            this.btnx1.TabIndex = 5;
            this.btnx1.Text = "x1";
            this.btnx1.UseVisualStyleBackColor = true;
            this.btnx1.Click += new System.EventHandler(this.btnx1_Click);
            // 
            // btnDownIn2
            // 
            this.btnDownIn2.Location = new System.Drawing.Point(473, 29);
            this.btnDownIn2.Name = "btnDownIn2";
            this.btnDownIn2.Size = new System.Drawing.Size(42, 22);
            this.btnDownIn2.TabIndex = 6;
            this.btnDownIn2.Text = "<";
            this.btnDownIn2.UseVisualStyleBackColor = true;
            this.btnDownIn2.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUpIn2
            // 
            this.btnUpIn2.Location = new System.Drawing.Point(558, 30);
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
            this.lbValve.Location = new System.Drawing.Point(521, 35);
            this.lbValve.Name = "lbValve";
            this.lbValve.Size = new System.Drawing.Size(13, 13);
            this.lbValve.TabIndex = 8;
            this.lbValve.Text = "0";
            // 
            // lbValve3
            // 
            this.lbValve3.AutoSize = true;
            this.lbValve3.Location = new System.Drawing.Point(521, 74);
            this.lbValve3.Name = "lbValve3";
            this.lbValve3.Size = new System.Drawing.Size(13, 13);
            this.lbValve3.TabIndex = 11;
            this.lbValve3.Text = "0";
            // 
            // btnUpIn3
            // 
            this.btnUpIn3.Location = new System.Drawing.Point(558, 69);
            this.btnUpIn3.Name = "btnUpIn3";
            this.btnUpIn3.Size = new System.Drawing.Size(42, 22);
            this.btnUpIn3.TabIndex = 10;
            this.btnUpIn3.Text = ">";
            this.btnUpIn3.UseVisualStyleBackColor = true;
            this.btnUpIn3.Click += new System.EventHandler(this.btnUpIn3_Click);
            // 
            // btnDownIn3
            // 
            this.btnDownIn3.Location = new System.Drawing.Point(473, 68);
            this.btnDownIn3.Name = "btnDownIn3";
            this.btnDownIn3.Size = new System.Drawing.Size(42, 22);
            this.btnDownIn3.TabIndex = 9;
            this.btnDownIn3.Text = "<";
            this.btnDownIn3.UseVisualStyleBackColor = true;
            this.btnDownIn3.Click += new System.EventHandler(this.btnDownIn3_Click);
            // 
            // tbPIDK
            // 
            this.tbPIDK.Location = new System.Drawing.Point(694, 12);
            this.tbPIDK.Name = "tbPIDK";
            this.tbPIDK.Size = new System.Drawing.Size(27, 20);
            this.tbPIDK.TabIndex = 12;
            this.tbPIDK.Text = "0";
            this.tbPIDK.TextChanged += new System.EventHandler(this.tbPIDK_TextChanged);
            // 
            // tbPIDTi
            // 
            this.tbPIDTi.Location = new System.Drawing.Point(694, 39);
            this.tbPIDTi.Name = "tbPIDTi";
            this.tbPIDTi.Size = new System.Drawing.Size(27, 20);
            this.tbPIDTi.TabIndex = 13;
            this.tbPIDTi.Text = "0";
            this.tbPIDTi.TextChanged += new System.EventHandler(this.tbPIDTi_TextChanged);
            // 
            // tbPIDKd
            // 
            this.tbPIDKd.Location = new System.Drawing.Point(694, 66);
            this.tbPIDKd.Name = "tbPIDKd";
            this.tbPIDKd.Size = new System.Drawing.Size(27, 20);
            this.tbPIDKd.TabIndex = 14;
            this.tbPIDKd.Text = "0";
            this.tbPIDKd.TextChanged += new System.EventHandler(this.tbPIDKd_TextChanged);
            // 
            // lbPIDK
            // 
            this.lbPIDK.AutoSize = true;
            this.lbPIDK.Location = new System.Drawing.Point(727, 19);
            this.lbPIDK.Name = "lbPIDK";
            this.lbPIDK.Size = new System.Drawing.Size(14, 13);
            this.lbPIDK.TabIndex = 15;
            this.lbPIDK.Text = "K";
            // 
            // lbPIDTi
            // 
            this.lbPIDTi.AutoSize = true;
            this.lbPIDTi.Location = new System.Drawing.Point(727, 42);
            this.lbPIDTi.Name = "lbPIDTi";
            this.lbPIDTi.Size = new System.Drawing.Size(16, 13);
            this.lbPIDTi.TabIndex = 16;
            this.lbPIDTi.Text = "Ti";
            // 
            // lbPIDKi
            // 
            this.lbPIDKi.AutoSize = true;
            this.lbPIDKi.Location = new System.Drawing.Point(727, 69);
            this.lbPIDKi.Name = "lbPIDKi";
            this.lbPIDKi.Size = new System.Drawing.Size(20, 13);
            this.lbPIDKi.TabIndex = 17;
            this.lbPIDKi.Text = "Td";
            // 
            // tbSetpoint
            // 
            this.tbSetpoint.Location = new System.Drawing.Point(650, 151);
            this.tbSetpoint.Name = "tbSetpoint";
            this.tbSetpoint.Size = new System.Drawing.Size(27, 20);
            this.tbSetpoint.TabIndex = 18;
            this.tbSetpoint.Text = "0";
            this.tbSetpoint.TextChanged += new System.EventHandler(this.tbSetpoint_TextChanged);
            // 
            // btSpUp
            // 
            this.btSpUp.Location = new System.Drawing.Point(699, 149);
            this.btSpUp.Name = "btSpUp";
            this.btSpUp.Size = new System.Drawing.Size(42, 22);
            this.btSpUp.TabIndex = 19;
            this.btSpUp.Text = ">";
            this.btSpUp.UseVisualStyleBackColor = true;
            this.btSpUp.Click += new System.EventHandler(this.btSpUp_Click);
            // 
            // btSpDown
            // 
            this.btSpDown.Location = new System.Drawing.Point(588, 149);
            this.btSpDown.Name = "btSpDown";
            this.btSpDown.Size = new System.Drawing.Size(42, 22);
            this.btSpDown.TabIndex = 20;
            this.btSpDown.Text = "<";
            this.btSpDown.UseVisualStyleBackColor = true;
            this.btSpDown.Click += new System.EventHandler(this.btSpDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "SetPoint";
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.Location = new System.Drawing.Point(452, 143);
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(96, 34);
            this.btnAutoMode.TabIndex = 23;
            this.btnAutoMode.Text = "Auto";
            this.btnAutoMode.UseVisualStyleBackColor = true;
            this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutoMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSpDown);
            this.Controls.Add(this.btSpUp);
            this.Controls.Add(this.tbSetpoint);
            this.Controls.Add(this.lbPIDKi);
            this.Controls.Add(this.lbPIDTi);
            this.Controls.Add(this.lbPIDK);
            this.Controls.Add(this.tbPIDKd);
            this.Controls.Add(this.tbPIDTi);
            this.Controls.Add(this.tbPIDK);
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
        private System.Windows.Forms.TextBox tbPIDK;
        private System.Windows.Forms.TextBox tbPIDTi;
        private System.Windows.Forms.TextBox tbPIDKd;
        private System.Windows.Forms.Label lbPIDK;
        private System.Windows.Forms.Label lbPIDTi;
        private System.Windows.Forms.Label lbPIDKi;
        private System.Windows.Forms.TextBox tbSetpoint;
        private System.Windows.Forms.Button btSpUp;
        private System.Windows.Forms.Button btSpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutoMode;
    }
}

