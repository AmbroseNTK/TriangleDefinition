using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDefinition
{
    class Triangle
    {
        public double a, b, c;
        public int Define(double a, double b, double c)
        {
            /* 0: ba so a,b,c nhap vao khong tao thanh tam giac
             * 1: tam giac thuong
             * 2: tam giac can
             * 3: tam giac deu
             * 4: tam giac vuong
             * 5: tam giac vuong can
             */
            int result = TriangleType.NotTriangle;

            if(!AreAllBelowZero(a,b,c) && AreSumOfTwoEdgesGreaterThanTheOther(a, b, c))
            {
                result = TriangleType.Triangle;
                if (ArePythagoreanTriple(a, b, c))
                {
                    result = TriangleType.RightTriangle;
                    if (TwoEdgesIsEqual(a, b, c))
                    {
                        result = TriangleType.RightIsoscelesTriangle;
                    }
                }
                else if(TwoEdgesIsEqual(a,b,c))
                {
                    result = TriangleType.IsoscelesTriangle;
                    if (ThreeEdgesIsEqual(a, b, c))
                    {
                        result = TriangleType.EquilateralTriangle;
                    }
                }
            }
           

            this.a = a;
            this.b = b;
            this.c = c;

            return result;
        }

        public bool AreAllBelowZero(double a, double b, double c)
        {
            return a < 0 && b < 0 && c < 0;
        }

        public bool AreSumOfTwoEdgesGreaterThanTheOther(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }
        public bool TwoEdgesIsEqual(double a, double b, double c)
        {
            return a == b || b == c || a == c;
        }
        public bool ThreeEdgesIsEqual(double a, double b, double c)
        {
            return a == b && b == c && a == c;
        }
        public bool ArePythagoreanTriple(double a, double b, double c)
        {
            double aPower = a * a;
            double bPower = b * b;
            double cPower = c * c;
            double epsilon = 0.01;
            return (Math.Abs(aPower + bPower - cPower) < epsilon) || (Math.Abs(aPower + cPower - bPower) < epsilon) || (Math.Abs(bPower + cPower - aPower) < epsilon);
        }
    }
}
