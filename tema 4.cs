using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            m1:

            Console.Write("Тема 4. Номер задания(1-5): ");
            string num = Convert.ToString(Console.ReadLine());

            if(num == "1" || num == "1 " )
            {
                Console.Clear();

                int a, b, s, p;
                Console.Write("Сторана A =  ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Сторона B = ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                s = a * b;
                Console.WriteLine("Площадь (S) = " + s);

                p = 2 * (a + b);
                Console.WriteLine("Периметр (Р) = " + p);

                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();
                double p = 3.14;
                int d;

                Console.WriteLine("Число Пи = 3.14");

                Console.Write("Диаметр окружности (d) = ");
                d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Длина окружности (L) = " + (p * d));
                Console.ReadLine();

            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("Переменная А = ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Переменная B = ");
                float b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Среднее арифметическое = " + (a + b)/2 );
                Console.ReadLine();
                
            }

            if (num == "4" || num == "3 ")
            {
                Console.Clear();

                Console.Write("Первое число (A): ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Второе число (B): ");
                float b = Convert.ToInt32(Console.ReadLine());

                a = a * a;
                b = b * b;

                Console.WriteLine("Сумма квадратов = " + (a + b));
                Console.WriteLine("Разность квадратов = " + (a - b));
                Console.WriteLine("Произведение квадратов = " + (a * b));
                Console.WriteLine("Частное квадратов = " + (a / b));

                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();

                Console.Write("Первое число (A): ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Второе число (B): ");
                float b = Convert.ToInt32(Console.ReadLine());

                a = Math.Abs(a);
                b = Math.Abs(b);

                Console.WriteLine("Сумма модулей = " + (a + b));
                Console.WriteLine("Разность модулей = " + (a - b));
                Console.WriteLine("Произведение модулей = " + (a * b));
                Console.WriteLine("Частное модулей = " + (a / b));

                Console.ReadLine();
            }

            else
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}
