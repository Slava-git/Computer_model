using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class SpeedClampBlock : BaseBlock {
        private double dt;
        private double maxSpeed;
        private double prev;
        public SpeedClampBlock(double dt, double maxSpeed) {
            this.dt = dt;
            this.maxSpeed = maxSpeed;
        }

        public override double Calc(double x)
        {
            var s = (x - prev) / dt;
            
            if (Math.Abs(s) > prev)
            {
                x = maxSpeed * dt + prev;
            }
            prev = x;
            return x;
            
        }
    }
}
