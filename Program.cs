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
            ///Console.WriteLine("Введите число");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Вы ввели число: " + a);

            //Console.WriteLine("Задание 1.4");
            ///Console.WriteLine("Введите число");
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

            Console.WriteLine("Задание 1.12");
            Console.WriteLine("{0} {1}\n{2}", 5, 10, "7 см");

            Console.WriteLine("Задание 1.13");
            Console.WriteLine("{0}\n{1} {2}", "2 кг", 13, 17);

            Console.WriteLine("Задание 2.1(а)");
            Console.WriteLine("Введите значение x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (7*x*x) + 3*x + 6;
            Console.WriteLine("y = {0}", y);

           /* Console.WriteLine("Задание 2.1(б)");
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            y = (12 * x * x) + 7 * x + 12;
            Console.WriteLine("y = {0}", y);

            Console.WriteLine("Задание 2.2");
            Console.WriteLine("Введите длину стороны квадрата");
            a = Convert.ToDouble(Console.ReadLine());
            double p = 4 * a;
            Console.WriteLine("Периметр квадрата равен {0}", p);

            Console.WriteLine("Задание 2.3");
            double r = Convert.ToDouble(Console.ReadLine());
            double l = 2 * r; ///Диаметр окружности
            Console.WriteLine("Диаметр окружности равен {0}", l);

            Console.WriteLine("Задание 2.4");
            double R = 6350; ///Радиус Земли (в км)
            Console.WriteLine("Введите значение высоты h над Землёй");
            double h = Convert.ToDouble(Console.ReadLine());
            double s = Math.Sqrt(Math.Pow(R + h, 2) - Math.Pow(R, 2)); /// Расстояние от точки В до линии горизонта
            Console.WriteLine("Расстояние до линии горизонта от точки B равно {0} км", s);

            Console.WriteLine("Задание 2.5");
            Console.WriteLine("Введите длину ребра куба");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double v = Math.Pow(a1,3);
            double s1 = 4 * Math.Pow(a1, 2); ///Площадь боковой поверхности куба
            Console.WriteLine("Объем куба равен {0}", v);
            Console.WriteLine("Площадь боковой поверхности куба равна {0}", s1);

            Console.WriteLine("Задание 2.6");
            Console.WriteLine("Введите значение радиуса r");
            r = Convert.ToDouble(Console.ReadLine());
            double C = 2 * Math.PI * r; /// Длина окружности
            double S = (Math.PI) * (Math.Pow(r, 2));
            Console.WriteLine("Длина окружности равна {0}", C);
            Console.WriteLine("Площадь круга равна {0}", S);

            Console.WriteLine("Задание 2.7");
            Console.WriteLine("Введите первое целое число");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double average1 = (z1 + z2) / 2; /// Среднее арифметическое
            double average2 = Math.Sqrt(z1 * z2); /// Среднее геометрическое
            Console.WriteLine("Среднее арифметическое равно {0}", average1 );
            Console.WriteLine("Среднее геометрическое равно {0}", average2 );

            Console.WriteLine("Задание 2.8");
            double m = Convert.ToDouble(Console.ReadLine());
            double V = Convert.ToDouble(Console.ReadLine());
            p = m / V;
            Console.WriteLine("Плотность материала равна {0}", p);

            Console.WriteLine("Задание 2.9");
            Console.WriteLine("Введите количество жителей в государстве");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение площади государства");
            s = Convert.ToDouble(Console.ReadLine());
            p = n / s;
            Console.WriteLine("Плотность населения в этом государстве равна {0}", p);

            Console.WriteLine("Задание 2.10");
            Console.WriteLine("Введите коэффициенты уравнения");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if(a !=0)
            {
                x = -b / a;
                Console.WriteLine("x = {0}", x);
            }
            else
            {
                Console.WriteLine("Уравнений решений не имеет");
            }

            Console.WriteLine("Задание 2.11");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Гипотенузв равна {0}", c);

            Console.WriteLine("Задание 2.12");
            Console.WriteLine("Введите значение радиуса внешней окружности");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение радиуса внутренней окружности");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double S1 = Math.PI * (Math.Pow(r1, 2) - Math.Pow(r2, 2));
            Console.WriteLine("Площадь кольца равна {0}", S1);

            Console.WriteLine("Задание 2.13");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            p = a + b + c;
            Console.WriteLine("Периметр треугольника равен {0}", p);

            Console.WriteLine("Задание 2.13А");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            average1 = (Math.Abs(x1) + Math.Abs(x2)) / 2;
            average2 = Math.Sqrt(Math.Abs(x1) * Math.Abs(x2));
            Console.WriteLine("Среднее арифметическое равно {0}", average1);
            Console.WriteLine("Среднее арифметическое равно {0}", average2);

            Console.WriteLine("Задание 2.14");
            Console.WriteLine("Введите значение оснований");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение высоты");
            h = Convert.ToDouble(Console.ReadLine()); ///Высота равнобедренной трапеции
            c = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((b - a) / 2, 2));
            p = a + b + 2 * c;
            Console.WriteLine("Периметр равнобедренной трапеции равен {0}", p);

            Console.WriteLine("Задание 2.14A");
            Console.WriteLine("Введите значения длин сторон прямоугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            p = 2 * (a + b);
            d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Периметр прямоугольника равен {0}", p);
            Console.WriteLine("Диагональ прямоугольника равен {0}", d);

            Console.WriteLine("Задание 2.15");
            Console.WriteLine("Введите два числа");
            x1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            double addition = x1 + x2;
            double difference = x1 - x2;
            double multiply = x1 * x2;
            double divide = x1 / x2;
            Console.WriteLine("x1 + x2 = {0}", addition);
            Console.WriteLine("x1 - x2 = {0}", difference);
            Console.WriteLine("x1*x2 = {0}", multiply);
            Console.WriteLine("X1 / X2 = {0}" , divide);

            Console.WriteLine("Задание 2.16");
            Console.WriteLine("Введите значения длин сторон прямоугольного параллелепипеда");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            V = a * b * c;
            S = 2 * (a * c + b * c);
            Console.WriteLine("Объем прямоугольного параллелепипеда равен {0}", V);
            Console.WriteLine("Площадь боковой поверхности прямоугольного параллелепипеда равна {0}", S);

            Console.WriteLine("Задание 2.17");
            Console.WriteLine("Введите координаты первой точки");
            x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) - Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками равно {0}", distance);

            Console.WriteLine("Задание 2.18");
            Console.WriteLine("Введите значение оснований");
            a = Convert.ToDouble(Console.ReadLine()); /// Меньшее основание
            b = Convert.ToDouble(Console.ReadLine()); /// Большее основание
            Console.WriteLine("Введите значение высоты");
            h = Convert.ToDouble(Console.ReadLine()); ///Высота равнобедренной трапеции
            c = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((b - a) / 2, 2));
            p = a + b + 2 * c;
            Console.WriteLine("Периметр равнобедренной трапеции равен {0}", p);

            Console.WriteLine("Задание 2.19");
            Console.WriteLine("Введите значение оснований");
            a = Convert.ToDouble(Console.ReadLine()); /// Меньшее основание
            b = Convert.ToDouble(Console.ReadLine()); /// Большее основание
            double degrees = Convert.ToDouble(Console.ReadLine());
            double e = (b - a) / 2;
            h = Math.Tan((degrees * Math.PI) / 180) * e;
            Console.WriteLine("Площадь трапеции равна {0}", ((a + b) / 2) * h);

            Console.WriteLine("Задание 2.20");
            Console.WriteLine("Введите координаты первой вершины");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double dist1 = Math.Sqrt(Math.Pow(x2 - x1, 2) - Math.Pow(y2 - y1, 2)); /// Расстояние между 1 и 2 вершиной
            double dist2 = Math.Sqrt(Math.Pow(x3 - x2, 2) - Math.Pow(y3 - y2, 2)); /// Расстояние между 3 и 2 вершиной
            double dist3 = Math.Sqrt(Math.Pow(x3 - x1, 2) - Math.Pow(y3 - y1, 2)); /// Расстояние между 3 и 1 вершиной
            p = dist1 + dist2 + dist3;
            double P = p / 2;
            double square = Math.Sqrt(P * (P - dist1) * (P - dist2) * (P - dist3));
            Console.WriteLine("Периметр треугольника равен {0}", p);
            Console.WriteLine("Площадь треугольника равна {0}", square);

            Console.WriteLine("Задание 2.21");
            Console.WriteLine("Введите координаты 1 вершины");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты 2 вершины");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты 3 вершины");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты 4 вершины");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            dist1 = Math.Sqrt(Math.Pow(x2 - x1, 2) - Math.Pow(y2 - y1, 2)); /// Расстояние между 1 и 2 вершиной
            dist2 = Math.Sqrt(Math.Pow(x3 - x2, 2) - Math.Pow(y3 - y2, 2)); /// Расстояние между 3 и 2 вершиной
            dist3 = Math.Sqrt(Math.Pow(x3 - x1, 2) - Math.Pow(y3 - y1, 2)); /// Расстояние между 3 и 1 вершиной
            double dist4 = Math.Sqrt(Math.Pow(x4 - x3, 2) - Math.Pow(y4 - y3, 2));
            double dist5 = Math.Sqrt(Math.Pow(x4 - x1, 2) - Math.Pow(y4 - y1, 2));
            double p1 = (dist1 + dist2 + dist3) / 2; /// Полупериметр первого треугольника
            double p2 = (dist3 + dist4 + dist5) / 2;  /// Полупериметр второго треугольника
            S1 = Math.Sqrt(p1 * (p1 - dist1) * (p1 - dist2) * (p1 - dist3));
            double S2 = Math.Sqrt(p2 * (p2 - dist3) * (p2 - dist4) * (p2 - dist5));
            Console.WriteLine("Площадь выпуклого четырехугольника равна {0}", S1 + S2);

            Console.WriteLine("Задание 2.22");
            double sweets = Convert.ToDouble(Console.ReadLine()); /// Стоимость 1 кг конфет
            double cookies = Convert.ToDouble(Console.ReadLine()); /// Стоимость 1 кг печенья
            double apples = Convert.ToDouble(Console.ReadLine()); /// Стоимость 1 кг яблок
            double weight1 = Convert.ToDouble(Console.ReadLine()); /// Вес конфет
            double weight2 = Convert.ToDouble(Console.ReadLine()); /// Вес печенья
            double weight3 = Convert.ToDouble(Console.ReadLine()); /// Вес яблок
            double FullCost = (sweets * weight1) + (cookies * weight2) * (apples * weight3);
            Console.WriteLine("Стоимость всей покупки составит {0}", FullCost);

            Console.WriteLine("Задание 2.23");
            double monitor = Convert.ToDouble(Console.ReadLine());
            double systemunit = Convert.ToDouble(Console.ReadLine());
            double keyboard = Convert.ToDouble(Console.ReadLine());
            double mouse = Convert.ToDouble(Console.ReadLine());
            FullCost = monitor + systemunit + keyboard + mouse;
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость 3 компьютеров, состоящих из этих элементов составит {0}", 3 * FullCost);
            Console.WriteLine("Стоимость N компьютеров, состоящих из этих элементов составит {0}", N * FullCost);

            Console.WriteLine("Задание 2.24");
            Console.WriteLine("Введите возраст Тани");
            double age1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите возраст Мити");
            double age2 = Convert.ToDouble(Console.ReadLine());
            double average_age = (age1 + age2) / 2;
            double difference1 = Math.Abs(age1 - average_age); /// Разница между возрастом Тани и средним значением
            double difference2 = Math.Abs(age2 - average_age); /// Разница между возрастом Мити и средним значением
            Console.WriteLine("Средний возраст составляет {0}", average_age);
            Console.WriteLine("Разница между возрастом Тани и средним значением составляет {0}", difference1);
            Console.WriteLine("Разница между возрастом Мити и средним значением составляет {0}", difference2);

            Console.WriteLine("Задание 2.25");
            Console.WriteLine("Введите значение скоростей (в км/час");
            double v1 = Convert.ToDouble(Console.ReadLine());
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение расстояния между автомобилями (в км)");
            s = Convert.ToDouble(Console.ReadLine());
            double t = s / (v1 + v2);
            Console.WriteLine("Время, через которое автомобили встретятся, составит {0} часа", t);

            Console.WriteLine("Задание 2.26");
            Console.WriteLine("Введите значение скоростей (в км/ч)");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            s = Convert.ToDouble(Console.ReadLine());
            s1 = s +(v1-v2)*0.5;
            Console.WriteLine("Расстояние между автомобилями станет {0}", s1);

            Console.WriteLine("Задание 2.27");
            Console.WriteLine("Введите значение температуры по шкале Цельсия");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 1.8) + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("По шкале Фаренгейта: {0}\nПо шкале Кельвина: {1}", fahrenheit, kelvin);

            Console.WriteLine("Задание 2.28");
            fahrenheit = 450;
            celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("Темература по шкале Цельсия равна: {0}", celsius);

            Console.WriteLine("Задание 3.1");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Console.WriteLine("Задание 3.2");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double temp1 = Convert.ToDouble(Console.ReadLine());
            double temp2 = Convert.ToDouble(Console.ReadLine());
            temp1 = a;
            a = b;
            temp2 = c;
            c = temp1;
            b = temp2;
*/
            Console.WriteLine("Задание 3.3(а)");
            a = Convert.ToDouble(Console.ReadLine());
            a = a * a; /// а в квадрате
            a = a * a; /// а в четвертой
            Console.WriteLine($"{a}");

            Console.WriteLine("Задание 3.3(б)");
            a = Convert.ToDouble(Console.ReadLine());
            a = a * a; /// а в квадрате
            b = a * a; /// а в 4 степени
            a = b * a; /// а в 6 степени
            Console.WriteLine($"{a}");

            Console.WriteLine("Задание 3.3(в)");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * a;
            b = b * a;
            b = b * b;
            b = b * a;
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.3(г)");
            a = Convert.ToDouble(Console.ReadLine());
            a = a * a;
            a = a * a;
            a = a * a;
            Console.WriteLine($"{a}");

            Console.WriteLine("Задание 3.3(д)");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * a;
            b = b * b;
            b = b * b;
            b = b * a;
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.3(е)");
            a = Convert.ToDouble(Console.ReadLine());
            a = a * a;
            b = a * a;
            b = b * b;
            b = b * a;
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.4а");
            a = Convert.ToDouble(Console.ReadLine());
            double j = a;
            j = a * a; ///a^2
            b = a * j; /// a^3
            b = b * j; /// a^5
            b = b * b; /// a^10
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.4б");
            a = Convert.ToDouble(Console.ReadLine());
            double u = a;
            j = a * a; ///a^2
            u = j * j; /// a^4
            b = u * u; /// a^8
            b = b * b; /// a^16
            b = b * u; /// a^20
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.4в");
            a = Convert.ToDouble(Console.ReadLine());
            j = a * a; ///a^2
            u = j * a; /// a^3
            b = u * j; ///a^5
            b = b * b; ///a^10
            b = b * u; /// a^13
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.4г");
            a = Convert.ToDouble(Console.ReadLine());
            j = a * a; /// a^2
            u = j * j; /// a^4
            d = u * a; /// a^5
            b = b * u; /// a^9
            b = b * b; /// a^18
            b = b * a; /// a^19
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.4д");
            a = Convert.ToDouble(Console.ReadLine());
            double k = a;
            double f = a;
            j = a * a; /// a^2
            u = j * a; /// a^3
            b = u * j; /// a^5
            k = b * b; /// a^10
            f = k * b; /// a^15
            b = f * j; /// a^17
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.4e");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * a;
            b = b * b;
            b = u * u;
            b = b * a;
            b = b * b;
            b = b * u;
            Console.WriteLine($"{b}");

            Console.WriteLine("Задание 3.5");
            a = 10;
            b = a * a;
            a = a * a;
            a = a * a;
            a = a * a;
            b = a * b;
            Console.WriteLine($"{b}");

            Console.ReadKey();
        }
    }
}
