using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1");
            Console.WriteLine("Введите число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(a, 2));

            Console.WriteLine("Задание 1.2");
            Console.WriteLine(Math.Round(Math.E, 2));

            //Console.WriteLine("Задание 1.3");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Вы ввели число: " + a);

            //Console.WriteLine("Задание 1.4");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(a + "- вот какое число Вы ввели");

            //Console.WriteLine("Задание 1.5");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0} {1} {2}",1,13,49);

            //Console.WriteLine("Задание 1.6");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0}  {1}  {2}", 7, 15, 100);

            Console.WriteLine("Задание 1.7");
            a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}  {1}  {2}", a, b, c);

            Console.WriteLine("Задание 1.8");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);

            //Console.WriteLine("Задание 1.9");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0}\n{1}",50,10);

            //Console.WriteLine("Задание 1.10");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0}\n{1}\n{2}", 5, 10, 21);

            Console.WriteLine("Задание 1.11");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", a, b, c, d);

            

















            Console.ReadKey();
        }
    }
}
