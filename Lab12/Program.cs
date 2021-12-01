using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle.Lenght();
            Circle.Area();
            Circle.Belong();
            Console.ReadKey();
        }

        static class Circle 
        {
            public static double radius = 25; 
            public static int x = 5;
            public static int y = 26;            

            public static void Lenght()
            {
                Console.WriteLine("Длина окружности = {0:F2}", Math.PI * 2 * radius);
            }
            public static void Area()
            {
                Console.WriteLine("Площадь окружности ={0:F2}", Math.PI * Math.Pow(radius, 2));
            }

            public static void Belong()
            {
                if (Math.Abs(x) <= radius && Math.Abs(y) <= radius)
                {
                    Console.WriteLine("Точка - внутри круга с диаметром {0}", radius);
                }
                else
                {
                    Console.WriteLine("Точка - за пределами круга с диаметром {0}", radius);    
                }

            }


        }

    }
}
