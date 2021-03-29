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
            Sys.Calc();
            ChPlot.Series[0].Points.AddXY(Sys.Time, Sys.Out1);

            if (ChPlot.Series[0].Points.Count > pointCnt)
            {
                ChPlot.Series[0].Points.RemoveAt(0);
                ChPlot.ChartAreas[0].RecalculateAxesScale();
            }
            tbPIDK.Text = Sys.pid.K.ToString("F2");
            tbPIDTi.Text = Sys.pid.Ti.ToString("F2");
            tbPIDKd.Text = Sys.pid.Kd.ToString("F2");
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

        private void btSpDown_Click(object sender, EventArgs e)
        {
            Sys.SetPoint--;
            tbSetpoint.Text = Sys.SetPoint.ToString("F2");
        }

        private void btSpUp_Click(object sender, EventArgs e)
        {
            Sys.SetPoint++;
            tbSetpoint.Text = Sys.SetPoint.ToString("F2");
        }

        private void tbSetpoint_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbSetpoint.Text, out val))
            {
                Sys.SetPoint = val;
                tbSetpoint.Text = Sys.SetPoint.ToString("F2");
            }
        }

        private void tbPIDK_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbPIDK.Text, out val))
            {
                Sys.pid.K = val;
                tbPIDK.Text = Sys.pid.K.ToString("F2");
            }
        }

        private void tbPIDTi_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbPIDTi.Text, out val))
            {
                Sys.pid.Ti = val;
                tbPIDTi.Text = Sys.pid.Ti.ToString("F2");
            }
        }

        private void tbPIDKd_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbPIDKd.Text, out val))
            {
                Sys.pid.Kd = val;
                tbPIDKd.Text = Sys.pid.Kd.ToString("F2");
            }
        }

        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            Sys.pid.IsManual = !Sys.pid.IsManual;
            btnAutoMode.Text = Sys.pid.IsManual ? "Manual" : "Auto";
            btnUpIn2.Enabled = Sys.pid.IsManual;
            btnDownIn2.Enabled = Sys.pid.IsManual;
            lbValve.Enabled = Sys.pid.IsManual;
            lbValve.Text = Sys.ValveIn2.ToString("F2");

            btnUpIn3.Enabled = Sys.pid.IsManual;
            btnDownIn3.Enabled = Sys.pid.IsManual;
            lbValve3.Enabled = Sys.pid.IsManual;
            lbValve3.Text = Sys.ValveIn3.ToString("F2");
        }
    }
}
