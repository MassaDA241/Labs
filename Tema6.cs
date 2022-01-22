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
                Console.Clear();
                Console.Write("A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int c = a; a = b; b = c;
                Console.WriteLine("A: " + a);
                Console.WriteLine("B: " + b);
                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("C: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                int a1 = a; int b1 = b; int c1 = c;
                a = c1; b = a1; c = b1;

                Console.WriteLine("A: " + a);
                Console.WriteLine("B: " + b);
                Console.WriteLine("C: " + c);
                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("C: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                int a1 = a; int b1 = b; int c1 = c;
                a = b1; b = c1; c = a1;

                Console.WriteLine("A: " + a);
                Console.WriteLine("B: " + b);
                Console.WriteLine("C: " + c);
                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.WriteLine("Функция: y = 3x^6 - 6x^2 - 7 ");
                Console.WriteLine();
                Console.Write("X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y = " + ((3 * Math.Pow(x, 6)) - (6 * Math.Pow(x,2)) - 7 ));
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.WriteLine("Функция: y = 4(x-3)^6 - 7(x-3)^3 + 2  ");
                Console.WriteLine();
                Console.Write("X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y = " +  ((4 * Math.Pow((x-3),6)) - (7 * Math.Pow((x-3),3)) + 2  ));
                Console.ReadLine();
            }

            if (num == "6" || num == "6 ")
            {
                Console.Clear();

                Console.Write("A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = a * a;
                Console.WriteLine("Вторая степень: " + b);
                b = b * b;
                Console.WriteLine("Четвертая степень: " + b);
                b = b * b;
                Console.WriteLine("Восьмая степень: " + b);
                Console.ReadLine();
            }

            if (num == "7" || num == "7 ")
            {
                Console.Clear();

                Console.Write("A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int k = a * a;
                Console.WriteLine("Вторая степень: " + k);
                int m = a * k;
                Console.WriteLine("Третья степень: " + m);
                m = m * k;
                Console.WriteLine("Пятая степень: " + m);
                k = m * m;
                Console.WriteLine("Десятая степень: " + k);
                k = k * m;
                Console.WriteLine("Пятнадцатая степень: " + k);
                Console.ReadLine();
            }





                Console.Clear();
            goto m1;

        }
    }
}
