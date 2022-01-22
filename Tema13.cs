using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 13. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();
                Console.Write("стоимость 1 кг конфет: ");
                int C = int.Parse(Console.ReadLine());
                Console.WriteLine("Стоимость конфет: ");
                float m;
                for (m = 1; m < 11; m += 1)
                {
                    Console.WriteLine(m/10 + " кг = " + m/10*C);
                }
                    Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();
                double p = 1;
                Console.Write("N: ");
                int N = int.Parse(Console.ReadLine());

                for (int i = 1; i <= N; i++)
                {
                    p = p * (1 + 0.1 * i);
                }
                Console.WriteLine("Результат: " + p);             
                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());

                int rez = 0;
                int i;
                for (i = 1; i <= (2 * n - 1); i += 2)
                {
                    rez += i;
                    Console.WriteLine(rez);
                }

                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("A: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());
                float a2 = 1, rez = 1;
                int i;
                for (i = 2; i <= n; ++i)
                {
                    a2 *= a;
                    rez += a2;
                }
                Console.WriteLine(rez);

                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.Write("A: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());
                float a2 = 1, rez = 1;
                int i;
                for (i = 2; i <= n; ++i)
                {
                    a2 *= -a;
                    rez += a2;
                }
                Console.WriteLine(rez);
                Console.ReadLine();
            }


            Console.Clear();
            goto m1;

        }
    }
}