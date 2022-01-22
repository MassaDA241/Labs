using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.Write("Тема 12. Номер задания(1-5):  ");
            string num = Convert.ToString(Console.ReadLine());

            if (num == "1" || num == "1 ")
            {
                Console.Clear();
                string[] day= new string[32];
                day[1] = "первое "; day[2] = "второе "; day[3] = "третье "; day[4] = "четвертое "; day[5] = "пятое  "; day[6] = "шестое  "; day[7] = "седьмое ";
                day[8] = "восьмое  "; day[9] = "девятое  "; day[10] = "десятое  "; day[11] = "одиннадцатое  "; day[12] = "двенадцатое  "; day[13] = "тринадцатое  "; day[14] = "четырнадцатое  ";
                day[15] = "пятнадцатое  "; day[16] = "шестнадцатое  "; day[17] = "семнадцатое  "; day[18] = "восемнадцатое  "; day[19] = "девятнадцатое  "; day[20] = "двадцатое  "; day[21] = "двадцать первое ";
                day[22] = "двадцать второе "; day[23] = "двадцать третье "; day[24] = "двадцать четвертое "; day[25] = "двадцать пятое "; day[26] = "двадцать шестое "; day[27] = "двадцать седьмое "; day[28] = "двадцать восьмое ";
                day[29] = "двадцать девятое "; day[30] = "тридцатое "; day[31] = "тридцать первое ";

                string[] month = new string[13];
                month[1] = "января"; month[2] = "февраля"; month[3] = "марта"; month[4] = "апреля"; month[5] = "мая"; month[6] = "июня"; month[7] = "июля";
                month[8] = "августа"; month[9] = "сентября"; month[10] = "октября"; month[11] = "ноября"; month[12] = "декабря";

                Console.Write("День(1-31): ");                
                int a = int.Parse(Console.ReadLine());                
                Console.Write("Месяц(1-12): ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(day[a] + month[b]);
                Console.ReadLine();
            }

            if (num == "2" || num == "2 ")
            {
                Console.Clear();

                Console.Write("Направление: ");
                String c = Console.ReadLine();
                Console.Write("Команда: ");
                int n = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case "С":
                        switch (n)
                        {
                            case 1:
                                c = "З";
                                break;
                            case 0:
                                c = "С";
                                break;
                            case -1:
                                c = "В";
                                break;
                        }
                        break;

                    case "В":
                        switch (n)
                        {
                            case 1:
                                c = "С";
                                break;
                            case 0:
                                c = "В";
                                break;
                            case -1:
                                c = "Ю";
                                break;
                        }
                        break;

                    case "Ю":
                        switch (n)
                        {
                            case 1:
                                c = "В";
                                break;
                            case 0:
                                c = "Ю";
                                break;
                            case -1:
                                c = "З";
                                break;
                        }
                        break;

                    default:
                        switch (n)
                        {
                            case 1:
                                c = "Ю";
                                break;
                            case 0:
                                c = "З";
                                break;
                            case -1:
                                c = "С";
                                break;
                        }
                        break;
                }
                Console.Write("Результат: " + c);
                Console.ReadKey();

                
            }

            if (num == "3" || num == "3 ")
            {
                Console.Clear();
                Console.Write("Кол-во: ");
                int n = int.Parse(Console.ReadLine());
                if (n / 10 == 1)
                {
                    switch (n)
                    {
                        case 10:
                            Console.Write("десять учебных заданий.");
                            break;
                        case 11:
                            Console.Write("одинадцать учебных заданий.");
                            break;
                        case 12:
                            Console.Write("двенадцать учебных заданий.");
                            break;
                        case 13:
                            Console.Write("тринадцать учебных заданий.");
                            break;
                        case 14:
                            Console.Write("четырнадцать учебных заданий.");
                            break;
                        case 15:
                            Console.Write("пятнадцать учебных заданий.");
                            break;
                        case 16:
                            Console.Write("шестнадцать учебных заданий.");
                            break;
                        case 17:
                            Console.Write("семнадцать учебных заданий.");
                            break;
                        case 18:
                            Console.Write("восемнадцать учебных заданий.");
                            break;
                        case 19:
                            Console.Write("девятнадцать учебных заданий.");
                            break;

                    }
                }
                else
                {
                    switch (n/10)
                    {
                        case 2:
                            Console.Write("двадцать ");
                            break;
                        case 3:
                            Console.Write("тридцать ");
                            break;
                        case 4:
                            Console.Write("сорок ");
                            break;
                    }
                    switch (n%10)
                    {
                        case 1:
                            Console.Write("одно ");
                            break;
                        case 2:
                            Console.Write("два ");
                            break;
                        case 3:
                            Console.Write("три ");
                            break;
                        case 4:
                            Console.Write("четыре ");
                            break;
                        case 5:
                            Console.Write("пять ");
                            break;
                        case 6:
                            Console.Write("шесть ");
                            break;
                        case 7:
                            Console.Write("семь ");
                            break;
                        case 8:
                            Console.Write("восемь ");
                            break;
                        case 9:
                            Console.Write("девять ");
                            break;
                    }

                    switch (n%10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            Console.WriteLine("учебных заданий.");
                            break;
                        case 1:
                            Console.WriteLine("учебное задание.");
                            break;
                        case 2:
                        case 3:
                        case 4:
                            Console.WriteLine("учебных задания.");
                            break;
                    }

                }
                Console.ReadLine();
            }

            if (num == "4" || num == "4 ")
            {
                Console.Clear();
                Console.Write("Введите число: ");
                int n = int.Parse(Console.ReadLine());
                switch (n / 100)
                {
                    case 1:
                        Console.Write("сто ");
                        break;
                    case 2:
                        Console.Write("двести ");
                        break;
                    case 3:
                        Console.Write("триста ");
                        break;
                    case 4:
                        Console.Write("четыреста ");
                        break;
                    case 5:
                        Console.Write("пятьсот ");
                        break;
                    case 6:
                        Console.Write("шестьсот ");
                        break;
                    case 7:
                        Console.Write("семьсот ");
                        break;
                    case 8:
                        Console.Write("восемьсот  ");
                        break;
                    case 9:
                        Console.Write("девятьсот  ");
                        break;
                }

                if ((n % 100) / 10 == 1)
                {
                    switch (n % 100)
                    {
                        case 10:
                            Console.Write("десять ");
                            break;
                        case 11:
                            Console.Write("одинадцать ");
                            break;
                        case 12:
                            Console.Write("двенадцать ");
                            break;
                        case 13:
                            Console.Write("тринадцать ");
                            break;
                        case 14:
                            Console.Write("четырнадцать ");
                            break;
                        case 15:
                            Console.Write("пятнадцать ");
                            break;
                        case 16:
                            Console.Write("шестнадцать ");
                            break;
                        case 17:
                            Console.Write("семнадцать ");
                            break;
                        case 18:
                            Console.Write("восемнадцать ");
                            break;
                        case 19:
                            Console.Write("девятнадцать ");
                            break;
                    }
                }
                else
                {
                    switch ((n % 100) / 10)
                    {
                        case 2:
                            Console.Write("двадцать ");
                            break;
                        case 3:
                            Console.Write("тридцать ");
                            break;
                        case 4:
                            Console.Write("сорок ");
                            break;
                        case 5:
                            Console.Write("пятьдесят ");
                            break;
                        case 6:
                            Console.Write("шестьдесят ");
                            break;
                        case 7:
                            Console.Write("семьдесят ");
                            break;
                        case 8:
                            Console.Write("восемьдесят ");
                            break;
                        case 9:
                            Console.Write("девяносто ");
                            break;
                    }
                    switch (n % 10)
                    {
                        case 1:
                            Console.Write("один ");
                            break;
                        case 2:
                            Console.Write("два ");
                            break;
                        case 3:
                            Console.Write("три ");
                            break;
                        case 4:
                            Console.Write("четыре ");
                            break;
                        case 5:
                            Console.Write("пять ");
                            break;
                        case 6:
                            Console.Write("шесть ");
                            break;
                        case 7:
                            Console.Write("семь ");
                            break;
                        case 8:
                            Console.Write("восемь ");
                            break;
                        case 9:
                            Console.Write("девять ");
                            break;
                    }
                }

                
                Console.ReadLine();
            }

            if (num == "5" || num == "5 ")
            {
                Console.Clear();
                Console.Write("Введите год: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Год ");

                switch ((n) % 10)
                {
                    case 0:
                    case 1:
                        Console.Write("бел");
                        break;
                    case 2:
                    case 3:
                        Console.Write("черн");
                        break;
                    case 4:
                    case 5:
                        Console.Write("зелён");
                        break;
                    case 6:
                    case 7:
                        Console.Write("красн");
                        break;
                    case 8:
                    case 9:
                        Console.Write("жёлт");
                        break;
                }
                switch ((n + 1) % 5)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 9:
                    case 10:
                    case 11:
                        Console.Write("ой ");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.Write("ого ");
                        break;
                }
                switch ((n + 8) % 12)
                {
                    case 0:
                        Console.Write("крысы ");
                        break;
                    case 1:
                        Console.Write("коровы ");
                        break;
                    case 2:
                        Console.Write("тигра ");
                        break;
                    case 3:
                        Console.Write("зайцa ");
                        break;
                    case 4:
                        Console.Write("дракона ");
                        break;
                    case 5:
                        Console.Write("змеи ");
                        break;
                    case 6:
                        Console.Write("лошади ");
                        break;
                    case 7:
                        Console.Write("овцы ");
                        break;
                    case 8:
                        Console.Write("обезьяны ");
                        break;
                    case 9:
                        Console.Write("курицы ");
                        break;
                    case 10:
                        Console.Write("собаки ");
                        break;
                    case 11:
                        Console.Write("свиньи ");
                        break;
                }

                Console.ReadLine();
            }

      

            Console.Clear();
            goto m1;

        }
    }
}