using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class APBlock: BaseBlock
    {
        private double dt;
        private double T;
        private double prev;
        private double max;
        public APBlock(double dt, double T, double max)
        {
            this.dt = dt;
            this.T = T;
            this.max = max;
        }
        public override double Calc(double x)
        {
            var y = (dt * x + T * prev) / (T + dt);
            if(y < 0)
            {
                y = 0;
            }
            else if (y > max)
            {
                y = max;
            }
            prev = y;
            return y;
        }
    }
}
