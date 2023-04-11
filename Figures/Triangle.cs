using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        public override double getArea()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new TriangleException("Incorrect sides)");
            }

            if (SideA > (SideB + SideC) || SideB > (SideA + SideC) || SideC > (SideA + SideB))
            {
                throw new TriangleException("Incorrect triangle");
            }

            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public bool RightTriangle()
        {
            bool isRightTriangle = (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                               || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                               || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
            return isRightTriangle;
        }
    }
}
