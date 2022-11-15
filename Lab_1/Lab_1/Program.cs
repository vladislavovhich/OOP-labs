using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Rhombus rhombus = new Rhombus(0, 0, 5, 5, 10, 5, 5, 0);

            Console.WriteLine("Does rhombus exist: " + rhombus.IsExist());
            Console.WriteLine("Its square: " + rhombus.CalcSquare());
            Console.WriteLine("Its perimeter: " + rhombus.CalcPerimeter());
            Console.WriteLine("Its length of side is " + rhombus.CalcSide());

            double x, y;

            Console.WriteLine("Enter coords of the dot: ");

            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Is your dot inside the figure " + rhombus.IsDotInside(x, y));

            Console.ReadKey();
        }
    }
}
