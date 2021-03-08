using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class NoiseBlock: BaseBlock
    {
        private double threshold;
        private readonly Random random = new Random();
        public NoiseBlock(double threshold)
        {
            this.threshold = threshold;
        }
        public override double Calc(double x)
        {
            var amp = (x * threshold / 100);
            var ramp = amp / 2 - amp * random.NextDouble();
            return x + ramp;
        }
    }
}
