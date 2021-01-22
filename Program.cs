using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a != b)
            {
                if (a > b)
                {
                    b = a;
                }
                else
                {
                    a = b;
                }

            }
            else if (a == b)
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);

            // #2
            Console.Write("Введите цифры a = ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Введите цифры b = ");
            double operand2 = double.Parse(Console.ReadLine());
            char act;
            Console.Write("Выберите арифметический знак = "); act = char.Parse(Console.ReadLine());

            if (act == '+')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
            }
            if (act == '-')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
            }
            if (act == '*')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
            }
            if (act == '/')
            {
                Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");

            }
            if (operand2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка! Делить на ноль нельзя!");
            }


            //Есть вопросы на счет доработки, я вас спрошу на уроке)

            //#3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите цифры в диапозоне от 0 до 100 = ");
            Console.ForegroundColor = ConsoleColor.White;

            int i = int.Parse(Console.ReadLine());

            if (i >= 0 && i <= 14)
            {
                Console.WriteLine("Вы попали в диапазон между 0 - 14");
            }
            if (i >= 15 && i <= 35)
            {
                Console.WriteLine("Вы попали в диапазон между 15 - 35");
            }
            if (i >= 36 && i <= 50)
            {
                Console.WriteLine("Вы попали в диапазон между 36 - 50");
            }
            if (i >= 51 && i <= 100)
            {
                Console.WriteLine("Вы попали в диапазон между 51 - 100");
            }
            else if (i > 100)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОШИБКА");
            }
            Console.ReadKey();
            //#4
            Console.Write("Введите сумму покупки = ");
            double p = int.Parse(Console.ReadLine());
            double dis1 = 0.03;
            double dis2 = 0.05;
            double res;

            if (p <= 499)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("К сожалению вам НЕ присвоена скидка");
            }

            if (p >= 500 && p <= 999)
            {
                res = p - p * dis1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Общая сумма с учетом скидки = " + res);

            }
            if (p >= 1000)
            {
                res = p - p * dis2;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Общая сумма сучетом скидки = " + res);
            }
            Console.ReadKey();
            //#5
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            int res;
            if ((a < b) & (b < c) & (c < d))
            {
                Console.WriteLine("Числа возрастающие");

            }
            else if ((a == b) & (b == c) & (c == d))
            {
                res = (a * b * c * d);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Произведение 4 чисел равна = " + res);

            }
            else
            {
                res = Math.Min(Math.Min(a, b), Math.Min(c, d));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Minimum = " + res);
            }
            //#6
            l:
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            if (b > a && a > c)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }


            else if (a > c && c > b)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            else if (c > b && b > a)
            {
                c = a + c;
                a = c - a;
                c = c - a;
            }
            else if (c > a && a > b)
            {
                c = c + a;
                a = c - a;
                c = c - a;
                c = c + b;
                b = c - b;
                c = c - b;
            }
            else if (b > c && c > a)
            {
                c = c + a;
                a = c - a;
                c = c - a;
                b = b + a;
                a = b - a;
                b = b - a;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);







        }
    }
}
