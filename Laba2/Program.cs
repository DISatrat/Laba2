//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Laba2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            N4();
//            Console.ReadLine();
//        }

//        public static void N1()
//        {
//            int r = 2;

//            int x1 = 0;
//            int y1 = 2;

//            if (Math.Abs(x1 * x1 + y1 * y1 - r * r) <= Math.Pow(10, -3))
//            {
//                Console.WriteLine("точка 1 лежит ");
//            }
//            else
//            {
//                Console.WriteLine("точка 1 не лежит ");
//            }

//            double x2 = 1.5;
//            double y2 = 0.7;

//            if (Math.Abs(x2 * x2 + y2 * y2 - r * r) <= Math.Pow(10, -3))
//            {
//                Console.WriteLine("точка 2 лежит ");
//            }
//            else
//            {
//                Console.WriteLine("точка 2 не лежит ");
//            }

//            double x3 = 1;
//            double y3 = 1;

//            if (Math.Abs(x3 * x3 + y3 * y3 - r * r) <= Math.Pow(10, -3))
//            {
//                Console.WriteLine("точка 3 лежит ");
//            }
//            else
//            {
//                Console.WriteLine("точка 3 не лежит ");
//            }

//            double x4 = 3;
//            double y4 = 0;

//            if (Math.Abs(x4 * x4 + y4 * y4 - r * r) <= Math.Pow(10, -3))
//            {
//                Console.WriteLine("точка 4 лежит ");
//            }
//            else
//            {
//                Console.WriteLine("точка 4 не лежит ");
//            }

//        }
//        public static void N4()
//        {
//            Console.WriteLine("Введите число a");
//            double a = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите число b");
//            double b = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите число c ");
//            double c = double.Parse(Console.ReadLine());


//            double z = 0;
//            double res = 0;
//            if (a > b)
//            {
//                z = b;
//            }
//            else
//            {
//                z = a;
//            }

//            if (z > c)
//            {
//                Console.WriteLine(z);
//            }
//            else
//            {
//                Console.WriteLine(c);
//            }

            
//        }

//        public static void N7()
//        {
//            Console.WriteLine("Введите число x");

//            double x = int.Parse(Console.ReadLine());


//            if (Math.Abs(x) > 1)
//            {
//                Console.WriteLine("y=1");

//            }
//            else
//            {
//                Console.WriteLine("y= " + Math.Abs(x));
//            }
//        }
//    }
//}
