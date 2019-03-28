using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDefinition
{
    class TriangleType
    {
        public const int NotTriangle = 0;
        public const int Triangle = 1;
        public const int IsoscelesTriangle = 2;
        public const int EquilateralTriangle = 3;
        public const int RightTriangle = 4;
        public const int RightIsoscelesTriangle = 5;
        public static string IdToName(int type)
        {
            switch (type)
            {
                case 0:
                    return "Is not triangle";
                case 1:
                    return "Normal triangle";
                case 2:
                    return "Isosceles triangle";
                case 3:
                    return "Equilateral triangle";
                case 4:
                    return "Right triangle";
                case 5:
                    return "Right Isosceles triangle";
            }
            return "";
        }
    }
}
