using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3v11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чему равна сторона a");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чему равна сторона б");
            var v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чему равна сторона с");
            var c = Convert.ToInt32(Console.ReadLine());
            if ((x > 0) && (v > 0) && (c > 0) && (x + v > c) && (v + c > x) && (c + x > v))
            {

                P(x, v, c);
                S(x, v, c);
                Sokr(x, v, c);
            }
            else
            {
                Console.WriteLine("Треугольник не существует");

            }
            Console.ReadKey();
        }

        public static void P(int x, int v, int c)
        {
            double P = x + c + v;
            Console.WriteLine($"Периметр равен" + P);
        }
        public static void S(int x, int v, int c)
        {
            double PP = (v + c + x) / 2;
            double s = (PP * (PP - x) * (PP - v) * (PP - c));
            double S = Math.Sqrt(s);
            Console.WriteLine($"Площадь равна" + S);
        }
        public static void Sokr(int x, int v, int c)
        {
            double PP = (v + c + x) / 2;
            double s = (PP * (PP - x) * (PP - v) * (PP - c));
            double S = Math.Sqrt(s);
            double r = 2 * S / (v + x + c);
            double Sokr = x * v * c / 4 * r;
            Console.WriteLine($"Площадь круга, вписанного в треугольник равна " + Sokr);

        }

    }
}
