using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 6. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());


            if (num == "1" || num == "1 ")
            {

                m2:
                Console.Clear();
                Console.Write("Введите значение угла A в градусах (0 < A < 360): ");
                var a = Double.Parse(Console.ReadLine());
                if (a > 0 && a < 360)
                {
                    double rad = (Math.PI * a) / 180;
                    Console.WriteLine("Угол " + a + "° имеет " + Math.Round(rad, 2) + " радиан");
                    Console.ReadLine();
                }
                else
                {
                    goto m2;
                }
                
            }

            if (num == "2" || num == "2 ")
            {
                m2:
                Console.Clear();
                Console.WriteLine("Введите значение угла A в радианах (0 < A < 2·p): ");
                var a = Double.Parse(Console.ReadLine());             
                if (a > 0 && a < 2 *  Math.PI)
                {
                   double b = (180 / Math.PI) * a;
                   Console.WriteLine("Значение угла в градусах: " + Math.Round(b,2));
                   Console.ReadLine();
                }

                else
                {
                    goto m2;
                }
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("X: ");
                double x = int.Parse(Console.ReadLine());
                Console.Write("A: ");
                double a = int.Parse(Console.ReadLine());
                a = a / x;
                Console.WriteLine("Стоимость 1 кг конфет: " + Math.Round(a, 2));
                Console.Write("Y: ");
                double y = int.Parse(Console.ReadLine());
                a = a * y;
                Console.WriteLine("Стоимость " + y + " кг конфет: " + Math.Round(a,2));
                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("V1: ");
                double v1 = int.Parse(Console.ReadLine());
                Console.Write("V2: ");
                double v2 = int.Parse(Console.ReadLine());
                Console.Write("S: ");
                double s = int.Parse(Console.ReadLine());
                Console.Write("T: ");
                double t = int.Parse(Console.ReadLine());
                s = Math.Abs(s-(v1+v2)*t);
                Console.WriteLine("S = " + Math.Round(s,2) + " км");
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                m2:
                Console.Clear();
                Console.Write("A: ");
                double a = int.Parse(Console.ReadLine());
                if (a != 0)
                {
                    Console.Write("B: ");
                    double b = int.Parse(Console.ReadLine());
                    double x = (b * (-1)) / a ;
                    Console.WriteLine("X = " + x);
                    Console.ReadLine();
                }
                else
                {
                    goto m2;
                }
                
            }

            if (num == "6" || num == "6 ")
            {
                Console.Clear();
                Console.Write("A1: ");
                double a1 = int.Parse(Console.ReadLine());
                Console.Write("B1: ");
                double b1 = int.Parse(Console.ReadLine());
                Console.Write("C1: ");
                double c1 = int.Parse(Console.ReadLine());

                Console.Write("A2: ");
                double a2 = int.Parse(Console.ReadLine());
                Console.Write("B2: ");
                double b2 = int.Parse(Console.ReadLine());
                Console.Write("C2: ");
                double c2 = int.Parse(Console.ReadLine());

                double d = a1 * b2 - a2 * b1;
                double x = (c1 * b2 - c2 * b1) / d;
                double y = (a1 * c2 - a2 * c1) / d;
                Console.WriteLine("X = " + x);
                Console.WriteLine("Y = " + y);
                Console.ReadLine();

            }


            Console.Clear();
            goto m1;
        }
    }
}