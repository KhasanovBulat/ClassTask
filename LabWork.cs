using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа");
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Введите Ваше имя:");
            string UserName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Здравствуйте, {0}!", UserName);

            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Введите два числа:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{x1/x2}");

            Console.WriteLine("Домашнее задание 2.1");
            char letter = Console.ReadKey().KeyChar;
            char symbol = char.ToLower(letter);
            char Nextletter;
            if (symbol == 'z')
            {
                Nextletter = 'a';
            }
            else
            {
                Nextletter = (char)(((int)symbol) + 1);
            }
            Console.WriteLine();
            Console.WriteLine("{0}", Nextletter);



            Console.WriteLine("Домашнее задание 2.2");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if(D>0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            else
            {
                double x = -b / 2 * a;
                Console.WriteLine("x = {0}", x);
            }
            if (a == 0)
            {
                double x = -c / b;
                Console.WriteLine("Решение линейного уравнения: {0}", x);
            }
        }
    }
}
