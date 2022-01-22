using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 11. Номер задания(1-6):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    b = a;
                }
                else if (a < b)
                {
                    a = b;
                }
                else
                {
                    a = 0;
                    b = 0;
                }
                Console.WriteLine("A = " + a);
                Console.WriteLine("B = " + b);
                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());
                if (a<=b && a<=c)
                {
                    Console.WriteLine(b+c);
                }
                else if (b <= a && b <= c)
                {
                    Console.WriteLine(a + c);
                }
                else if (c <= a && c <= b)
                {
                    Console.WriteLine(b + b);
                }
                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());
                if (Math.Abs(a - b) < Math.Abs(a - c))
                {
                    Console.WriteLine("Ближе точка B: " + b + ". Она находится на расстоянии: " + Math.Abs(a - b));
                }
                else
                {
                    Console.WriteLine("Ближе точка C: " + c + ". Она находится на расстоянии: " + Math.Abs(a - c));
                }
                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Точка в первой координатной четверти");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Точка в второй координатной четверти");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("Точка в третьей координатной четверти");
                }
                else
                {
                    Console.WriteLine("Точка в четвертой координатной четверти");
                }
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.Write("Введите число: ");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.Write("нулевое ");
                }
                else
                {
                    if (x>0)
                    {
                        Console.Write("положительное ");
                    }
                    if (x % 2 == 0)
                    {
                        Console.Write("чётное ");
                    }
                    else
                    {
                        Console.Write("нечётное ");
                    }
                }
                Console.WriteLine("число");
                Console.ReadLine();
            }

            if (num == "6" || num == "6 ")
            {
                Console.Clear();
                Console.Write("Введите число: ");
                int x = int.Parse(Console.ReadLine());
                if ((x % 2) == 0)
                {
                    Console.Write("Чётное ");
                }
                else
                {
                    Console.Write("Нечётное ");
                }
                if (x > 99)
                {
                    Console.Write("трёхзначное ");
                }
                if (99 >= x && x > 9)
                {
                    Console.Write("двухзначное ");
                }
                if (x <= 9)
                {
                    Console.Write("однозначное  ");
                }
                Console.Write("число");
                Console.ReadLine();
            }

            Console.Clear();
            goto m1;

        }
    }
}