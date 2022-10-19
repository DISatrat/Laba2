using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Level_2
    {
        static void Main(string[] args)
        {
            N7();
            Console.ReadLine();
        }
        public static void N1()
        {
            int n, n2, y, sum = 0;
            double average;
            Console.WriteLine("введите количестов учеников");
            n = int.Parse(Console.ReadLine());
            n2 = n;
            while (n != 0)
            {
                Console.WriteLine("введите рост ученика");
                y = int.Parse(Console.ReadLine());
                n--;

                sum += y;

            }
            average = sum / n2;


            Console.WriteLine("средний рост= " + average);
        }
        public static void N4()
        {
            Console.WriteLine("введите значение внутреннего радиуса");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите значение внешнего радиуса");
            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите значение х");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("введите значение у");
            int y = int.Parse(Console.ReadLine());
            if ((r1 >= Math.Sqrt(x * x + y * y)) && (r2 <= Math.Sqrt(x * x + y * y)))
            {
                Console.WriteLine("лежит");
            }
            else
            {
                Console.WriteLine("не лежит");
            }
        }

        public static void N7()
        {

            int r;
            int x, y;
            Console.WriteLine("введите количество точек");
            int n;
            n = int.Parse(Console.ReadLine());
            int c = 0;
            while (n!=0)
            {
            Console.WriteLine("введите x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y");
            y = int.Parse(Console.ReadLine());
            if ((x >= 0) && (y >= 0))
            {
                Console.WriteLine("1 четверть");
                    c++;
            }
            else if ((x <= 0) && (y >= 0))
            {
                Console.WriteLine("2 четверть");
            }
            else if ((x <= 0) && (y <= 0))
            {
                Console.WriteLine("3 четверть");
                    c++;
                }
            else if ((x >= 0) && (y <= 0))
            {
                Console.WriteLine("4 четверть");
            }
                n--;
            }
            Console.Write(c);

        }
        public static void numm()
        {

            int n, y;
            Console.WriteLine("введите n");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                y = int.Parse(Console.ReadLine());
                Console.WriteLine(y);
                n--;
            }

        }

    }
}
