using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 14. Номер задания(1-6):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();

                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());

                for (int i = b - 1; i > a; i--)
                    Console.WriteLine(i);
                Console.WriteLine(b - a - 1);

                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();

                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                int temp = a;
                while (temp >= 0)
                {
                    temp -= b;
                }
                Console.WriteLine(temp + b);

                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();

                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());
                int k = 0, temp = 0;
                while (temp < n)
                {
                    ++k;
                    temp += 3;
                }
                Console.Write(k + "" + temp);

                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("P: ");
                int p = int.Parse(Console.ReadLine());
                int k = 1;
                float s = 1000;
                while (s <= 1100)
                {
                    ++k;
                    s += s * p / 100;
                }
                Console.Write(k + " " + Math.Round(s,2));
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();

                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }
                Console.WriteLine(a+b);

                Console.ReadLine();
            }

            if (num == "6" || num == "6 ")
            {
                Console.Clear();
                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());
                int f1 = 1, f2 = 1, f = 0, k = 2;
                while (f < n)
                {
                    ++k;
                    f = f2 + f1;
                    f2 = f1;
                    f1 = f;
                }
                Console.WriteLine(k);
                Console.ReadLine();
            }


            Console.Clear();
            goto m1;

        }
    }
}