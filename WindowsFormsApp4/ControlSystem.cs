using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ControlSystem
    {

        private double valveIn2;
        private double valveIn3;
        

        private double out1;
        public double Out1{ get { return out1; } }

        private ClampBlock clampInput;
        public double Time;
        public double dt;

        public PIDBlock pid { get; set; }
        public double SetPoint { get; set; }
        public ComplexBlock Object { get; set; }

        public double ValveIn2
        {
            get { return valveIn2; }
            set
            {
                valveIn2 = clampInput.Calc(value);
                pid.Umanual = value;
            }
        }
        public double ValveIn3 { get { return valveIn3; } set { valveIn3 = clampInput.Calc(value); } }

        public SpeedClampBlock spClampBlock { get; set; }
        private APBlock apBlock;
    
        public ControlSystem(double dt)
        {
            this.dt = dt;
            clampInput = new ClampBlock(0, 100);
            
            spClampBlock = new SpeedClampBlock(dt, 10);
            apBlock = new APBlock(dt, 1.1336, 1000000);

            pid = new PIDBlock(1, 0.01, 0, dt);
        }
        public void Calc()
        {
            
            Time += dt;
            if (!pid.IsManual)
            {
                ValveIn2 = pid.Calc(SetPoint - out1);
            }
            double inputValue = 106.7 * 1 + 121.9 * ValveIn2 + 1237.8 * ValveIn3 - 2179.9* 1;
            out1 = apBlock.Calc(inputValue);
        }
    }
}
