using System;

namespace ConsoleApp1
{
    class Program
    {
        static void PowerA3(double A, out double B)
        {
            B = A * A * A;
        }
        static int Sign(int a, int b)
        {
            int a1 = 0;
            int b1 = 0;
            if (a < 0)
                a1 = -1;
            else if (a == 0)
                a1 = 0;
            else if (a > 0)
                a1 = 1;
            if (b < 0)
                b1 = -1;
            else if (b == 0)
                b1 = 0;
            else if (b < 0)
                b1 = 1;
            return a1 + b1;
        }
        static double Ring(double r1, double r2)
        {
            return Math.PI * (r1 + r2) * (r1 - r2);
        }
        static long Fact2(long n)
        {
            long result = 1;
            for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
            {
                result *= i;
            }
            return result;
        }


        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 15. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();

                double b;
                for (int i = 2; i < 7; i++)
                {
                    PowerA3(i, out b);
                    Console.WriteLine(b);
                }

                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();

                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                int c = Sign(a, b);
                Console.WriteLine("Sign(A,B) = " + c);

                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();

                for (int i = 1; i < 4; i++)
                {
                    Console.Write("Внешний радиус: ", i);
                    double r1 = double.Parse(Console.ReadLine());
                    Console.Write("Внутренний радиус: ", i);
                    double r2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Площадь кольца = {1:F3}\n", i, Ring(r1, r2));
                }

                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();

                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.WriteLine(Fact2(7));
                Console.ReadLine();
            }


            Console.Clear();
            goto m1;

        }
    }
}