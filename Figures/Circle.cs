using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double Radius) {
            this.Radius = Radius;
        }

        public override double getArea()
        {
            if (Radius <= 0)
            {
                throw new CircleException("Incorrect radius)");
            }
            return Radius * 2 * 3.14;
        }
    }
}
