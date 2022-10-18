using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            N4();
            Console.ReadLine();
        }

        public static void N1()
        {
            int r = 2;

            int x1 = 0;
            int y1 = 2;

            if (Math.Abs(x1 * x1 + y1 * y1 - r * r) <= Math.Pow(10, -3))
            {
                Console.WriteLine("точка 1 лежит ");            
            }
            else
            {
                Console.WriteLine("точка 1 не лежит ");
            }

            double x2=1.5;
            double y2 = 0.7;

            if (Math.Abs(x2 * x2 + y2 * y2 - r * r) <= Math.Pow(10, -3))
            {
                Console.WriteLine("точка 2 лежит ");
            }
            else
            {
                Console.WriteLine("точка 2 не лежит ");
            }

            double x3 = 1;
            double y3 = 1;

            if (Math.Abs(x3 * x3 + y3 * y3 - r * r) <= Math.Pow(10,-3))
            {
                Console.WriteLine("точка 3 лежит ");
            }
            else
            {
                Console.WriteLine("точка 3 не лежит ");
            }

            double x4 = 3;
            double y4 = 0;

            if (Math.Abs(x4 * x4 + y4 * y4 - r * r) <= Math.Pow(10, -3))
            {
                Console.WriteLine("точка 4 лежит ");
            }
            else
            {
                Console.WriteLine("точка 4 не лежит ");
            }   

        }
        public static void N4()
        {
            Console.WriteLine("Введите три числа через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');

            double a = Convert.ToDouble(splitString[0]);
            double b = Convert.ToDouble(splitString[1]);
            double c = Convert.ToDouble(splitString[2]);

       

            double z = Math.Max(Math.Min(a,b),c);

            Console.WriteLine(z);
        }

        public static void N7()
        {
            Console.WriteLine("Введите число x");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');

            double x = Convert.ToDouble(splitString[0]);
            double y = 0;

            if (Math.Abs(x) > 1)
            {
                Console.WriteLine("y=1");

            }
            else
            {
                Console.WriteLine("y= "+Math.Abs(x));
            }
        }
    }
}
