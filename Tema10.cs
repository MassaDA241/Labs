using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 10. Номер задания(1-7):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine((a>2) && (b <=3));
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
                Console.WriteLine((a<b) && (b<c));
                Console.ReadLine();
            }

            

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine((a>9) && (a<100) && (a%2 == 0));
                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine((((a / 100) > (a % 100 / 10)) && ((a % 100 / 10) > (a % 10))) || (((a / 100) < (a % 100 / 10)) && ((a % 100 / 10) < (a % 10))) );
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(((a % 10) == (a / 1000)) && (((a % 100) / 10) == ((a % 1000) / 100)));
                Console.ReadLine();
            }

            if (num == "6" || num == "6 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine((Math.Sqrt(a) == Math.Sqrt(b) + Math.Sqrt(c)) || (Math.Sqrt(b) == Math.Sqrt(a) + Math.Sqrt(c)) || (Math.Sqrt(c) == Math.Sqrt(a) + Math.Sqrt(b)) && (a > 0) && (b > 0) && (c > 0));
                Console.ReadLine();
            }

            if (num == "7" || num == "7 ")
            {
                Console.Clear();
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine(((b + c) > a) && ((a + c) > b) && ((a + b) > c));
                Console.ReadLine();
            }




            Console.Clear();
            goto m1;
        }
    }
}
