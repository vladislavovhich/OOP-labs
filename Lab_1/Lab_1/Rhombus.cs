using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Rhombus
    {
        public double X1, Y1, X2, Y2, X3, Y3, X4, Y4;

        public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            X1 = x1;
            Y1 = y1;

            X2 = x2;
            Y2 = y2;

            X3 = x3;
            Y3 = y3;

            X4 = x4;
            Y4 = y4;
        }

        public double CalcSide()
        {
            double side = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            return side;
        }

        public double CalcSquare()
        {
            double d1 = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            double d2 = Math.Sqrt(Math.Pow(X4 - X2, 2) + Math.Pow(Y4 - Y2, 2));
            double S = d1 * d2 * 0.5;

            return S;
        }

        public double CalcPerimeter()
        {
            double side = CalcSide();
            double P = side * 4;

            return P;
        }

        public bool IsDotInside(double x, double y)
        {
            double line1 = ((x - X1) / (X2 - X1)) - ((y - Y1) / (Y2 - Y1));
            double line2 = ((x - X3) / (X2 - X3)) - ((y - Y3) / (Y2 - Y3));
            double line3 = ((x - X4) / (X3 - X4)) - ((y - Y3) / (Y4 - Y3));
            double line4 = ((x - X1) / (X4 - X1)) - ((y - Y1) / (Y4 - Y1));

            if ((line1 > 0 && line2 > 0 && line3 < 0 && line4 < 0) || line1 == 0 || line2 == 0 || line3 == 0 || line4 == 0)
            {
                return true;
            }

            return false;
        }

        public bool IsExist()
        { 
            double k1 = (Y2 - Y1) / (X2 - X1);
            double k2 = (Y3 - Y2) / (X3 - X2);
            double k3 = (Y4 - Y3) / (X4 - X3);
            double k4 = (Y4 - Y1) / (X4 - Y1);

            if ((k1 != k3) || (k2 != k4))
            {
                return false;
            }

            return true;
        }
    }
}
