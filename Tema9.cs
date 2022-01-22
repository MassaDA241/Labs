using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 9. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();
                Console.Write("Введите кол-во секунд: ");
                int a = int.Parse(Console.ReadLine());
                int x = a % 60;
                Console.WriteLine("Кол-во секунд, прошедших с последней минуты: " + x);
                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();
                Console.Write("Введите день этого года: ");
                int a = int.Parse(Console.ReadLine());
                int x = (a % 7);
                Console.WriteLine("День недели : " + x);
                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("Введите день этого года: ");
                int a = int.Parse(Console.ReadLine());
                int x = ((a + 4) % 7);
                Console.WriteLine("День недели : " + x);
                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());

                int x = (a / c) * (b / c);
                Console.WriteLine("На прямоугольнике можно разместить: " + x + " квадратов");
                double s = a * b - a * Math.Sqrt(c);
                Console.WriteLine("Не занятая площадь прямоугольника равна " +  s);
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.Write("Введите номер года: ");
                int a = int.Parse(Console.ReadLine());
                int x = ((a - 1) / 100) + 1;
                Console.WriteLine("Это год " + x + " столетия");
                Console.ReadLine();
            }

            Console.Clear();
            goto m1;
        }
    }
}
