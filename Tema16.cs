using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 16. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();

                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = 1 + i * 2;
                for (int i = 0; i < n; ++i)
                    Console.WriteLine("a[" + i + "] = " + a[i]);

                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();

                int[] a = new int[10];
                int d, n, i, pow;

                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("A[0]: ");
                a[0] = int.Parse(Console.ReadLine());
                Console.Write("D: ");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine();

                pow = 1;
                for (i = 1; i < n; ++i)
                {
                    pow *= d;
                    a[i] = a[0] * pow;
                }

                for (i = 0; i < n; ++i)
                {
                    Console.WriteLine(i + " " + a[i]);
                }

                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();

                int[] a = new int[10];

                int n, i, i2;
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("A: ");
                a[0] = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                a[1] = int.Parse(Console.ReadLine());

                for (i = 2; i < n; ++i)
                {
                    a[i] = 0;
                    for (i2 = 0; i2 < i; ++i2) a[i] += a[i2];
                    
                }
                for (i = 0; i < n; ++i)
                {
                    Console.WriteLine(i + " : " + a[i]);
                }

                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();

                int[] a = new int[10];
                int n, i;

                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                for (i = 0; i < n; ++i)
                {
                    Console.Write(i + ": ");
                    a[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                for (i = 0; i < n / 2; ++i)
                {
                    Console.WriteLine(i + " : " + a[i]);
                    Console.WriteLine(n-i+1 + " : " + a[n-i+1]);
                }

                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();

                int[] a = new int[10];
                int n, i;

                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());

                for (i = 0; i < n; ++i)
                {
                    Console.Write(i+1 + " : ");
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (i = 0; i < n; i += 2) Console.WriteLine(i + " : " + a[i]);
                for (i = n - (n % 2) - 1; i >= 1; i -= 2) Console.WriteLine(i + " : " + a[i]);

                Console.ReadLine();
            }

            Console.Clear();
            goto m1;

        }
    }
}