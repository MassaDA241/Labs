using System;

namespace Tema5
{
    class Program
    {
        static void Main(string[] args)
        {
            m1:

            Console.Write("Тема 5. Номер задания (1-5): ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();

                Console.WriteLine("Координаты точки A: ");
                Console.Write("x1 = ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y1 = ");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Координаты точки B: ");
                Console.Write("x2 = ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y2 = ");
                int y2 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.Write(" A(" + x1 + "," + y1 + ")" + "   ");
                Console.WriteLine("B(" + x2 + "," + y2 + ")");

                double b = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                Console.WriteLine("Расстояние между точками = " + b);


                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();

                Console.Write("Точка A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Точка B = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Точка C = ");
                int c = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("A(" + a + ")" + "  " + "B(" + b + ")" + "  " + "C(" + c + ")");
                Console.WriteLine();
                int ac = c - a;
                Console.WriteLine("Отрезок АС = " + ac);
                int bc = c - b;
                Console.WriteLine("Отрезок BC = " + bc);
                Console.WriteLine("Сумма отрезков = " + (ac + bc));

                Console.ReadLine();
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();

                Console.Write("Точка A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Точка B = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Точка C = ");
                int c = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("A(" + a + ")" + "  " + "B(" + b + ")" + "  " + "C(" + c + ")");
                Console.WriteLine();
                int ac = c - a;
                Console.WriteLine("Отрезок АС = " + ac);
                int bc = b - c;
                Console.WriteLine("Отрезок BС = " + bc);
                Console.WriteLine("Произведение длин отрезков = " + (ac * bc));

                Console.ReadLine();


            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();

                Console.WriteLine("Координаты точки A: ");
                Console.Write("x1 = ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y1 = ");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Координаты точки B: ");
                Console.Write("x2 = ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y2 = ");
                int y2 = Convert.ToInt32(Console.ReadLine());

                int v = Math.Abs(x2-x1);
                int g = Math.Abs(y2-y1);

                Console.Clear();
                Console.Write(" A(" + x1 + "," + y1 + ")" + "   ");
                Console.WriteLine("B(" + x2 + "," + y2 + ")");
                Console.WriteLine();

                int s = v * g;
                Console.WriteLine("Площадь прямоугольника (S) = " + s);
                int p = (v + g) * 2;
                Console.WriteLine("Периметр прямоугольника (P) = " + p);


                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();

                Console.WriteLine("Координаты точки A: ");
                Console.Write("x1 = ");
                double x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y1 = ");
                double y1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Координаты точки B: ");
                Console.Write("x2 = ");
                double x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y2 = ");
                double y2 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Координаты точки C: ");
                Console.Write("x3 = ");
                double x3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("y3 = ");
                double y3 = Convert.ToInt32(Console.ReadLine());

                double ab = Math.Sqrt( Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));
                double bc = Math.Sqrt( Math.Pow((x2-x3),2) + Math.Pow((y2-y3),2));
                double ac = Math.Sqrt( Math.Pow((x1-x3),2) + Math.Pow((y1-y3),2));

                double p = ab + bc + ac;
                double s = Convert.ToInt32( Math.Sqrt((p/2)*(p-ab)*(p-bc)*(p-ac)) );

                Console.Clear();

                Console.Write(" A(" + x1 + "," + y1 + ")" + "  ");
                Console.Write("B(" + x2 + "," + y2 + ")" + "  ");
                Console.WriteLine("C(" + x3 + "," + y3 + ")");

                Console.WriteLine();
                Console.WriteLine("Площадь Треугольника = " + s);
                Console.WriteLine("Периметр Треугольника = " + p);

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
