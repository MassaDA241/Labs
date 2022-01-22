using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 8. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());


            if (num == "1" || num == "1 ")
            {
                Console.Clear();
                Console.Write("Введите размер файла в байтах: ");
                double a = int.Parse(Console.ReadLine());
                Console.WriteLine("Количество килобайт: " + Math.Round((a/1024),2));
                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                
                Console.Clear();
                m2:
                Console.Write("Отрезок A: ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Длина отрезков B: ");
                double b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    double x = a / b;
                    if ((Convert.ToInt32(Math.Round(x, 0) * b) > 100))
                    {
                        Console.WriteLine("количество отрезков B, размещенных на отрезке A: " + Math.Round(x - 1, 0));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("количество отрезков B, размещенных на отрезке A: " + Math.Round(x, 0));
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("A должно быть больше B");
                    Console.WriteLine();
                    goto m2;
                }
               
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                m2:
                Console.Write("Отрезок A: ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Длина отрезков B: ");
                double b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    double x = a / b;
                    if ((Convert.ToInt32(Math.Round(x, 0) * b) > 100))
                    {
                        double y = 100 - (Math.Round(x - 1, 0) * b);
                        Console.WriteLine("количество отрезков B, размещенных на отрезке A: " + Math.Round(x - 1, 0));
                        Console.WriteLine("Длина незанятой части отрезка A = " + y);
                        Console.ReadLine();
                    }
                    else
                    {
                        double y = 100 - (Math.Round(x, 0) * b);
                        Console.WriteLine("количество отрезков B, размещенных на отрезке A: " + Math.Round(x, 0));
                        Console.WriteLine("Длина незанятой части отрезка A = " + y);
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("A должно быть больше B");
                    Console.WriteLine();
                    goto m2;
                }

            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                m2:
                Console.Write("Введите двузначное число: ");
                int a = int.Parse(Console.ReadLine());
                if (a < 100 && a > 9)
                {
                    int x1 = a % 10;
                    int x2 = a / 10;
                    Console.WriteLine("Получившееся число: " + x1 + x2);
                    Console.ReadLine();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Число не двузначное");
                    Console.WriteLine();
                    goto m2;
                }
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                m2:
                Console.Write("Введите трехзначное число: ");
                int a = int.Parse(Console.ReadLine());
                if (a > 99 && a < 1000)
                {
                    int x1 = a / 100;
                    int x2 = (a / 10) % 10;
                    int x3 = a % 10;
                    Console.WriteLine("Получившееся число: " + x2 + x3 + x1);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Число не трехзначное");
                    Console.WriteLine();
                    goto m2;

                }
                
            }







                Console.Clear();
            goto m1;
        }
    }
}
