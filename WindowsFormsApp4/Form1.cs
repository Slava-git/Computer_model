using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private ControlSystem Sys { get; set; }
        private const int plotWindow = 50;
        private int pointCnt;
        public Form1()
        {
            InitializeComponent();
            Sys = new ControlSystem(1);

            pointCnt = (int)(plotWindow / Sys.dt);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var y = Sys.Calc();
            ChPlot.Series[0].Points.AddXY(Sys.Time, y);

            if (ChPlot.Series[0].Points.Count > pointCnt)
            {
                ChPlot.Series[0].Points.RemoveAt(0);
                ChPlot.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void btnx1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Sys.ValveIn2--;
            lbValve.Text = Sys.ValveIn2.ToString("F2");
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Sys.ValveIn2++;
            lbValve.Text = Sys.ValveIn2.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDownIn3_Click(object sender, EventArgs e)
        {
            Sys.ValveIn3--;
            lbValve3.Text = Sys.ValveIn3.ToString("F2");
        }

        private void btnUpIn3_Click(object sender, EventArgs e)
        {
            Sys.ValveIn3++;
            lbValve3.Text = Sys.ValveIn3.ToString("F2");
        }
    }
}
