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
            if (aboveZero(SideA, SideB, SideC))
            {
                throw new FigureException("Incorrect sides");
            }
            if (correctTriangle(SideA, SideB, SideC))
            {
                throw new FigureException("Incorrect triangle");
            }
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public bool RightTriangle()
        {
            return (SideA == degreeSides(SideB, SideC)) || (SideB == degreeSides(SideA, SideC))
                   || (SideC == degreeSides(SideB, SideA));

        }
        public double degreeSides(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public bool aboveZero(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 && sideC > 0)
                return false;
            return true;
        }
        public bool correctTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB + sideC || sideB > sideA + sideB || sideC > sideB + sideA)
                return true;
            return false;
        }
    }
}
