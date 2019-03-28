using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDefinition
{
    class Case
    {
        public double A;
        public double B;
        public double C;
        public int ExpectedType;
        public int ActualType;

        public Case(double a, double b, double c, int expectedType)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.ExpectedType = expectedType;
        }
        public bool IsCorrect()
        {
            return ExpectedType == ActualType;
        }

        public override string ToString()
        {
            return String.Format("a = {0,7} | b = {1,7} | c = {2,7} | Expected: {3,25} | Actual: {4,25}",
                        A, B, C,
                        TriangleType.IdToName(ExpectedType),
                        TriangleType.IdToName(ActualType));
        }
    }
}
