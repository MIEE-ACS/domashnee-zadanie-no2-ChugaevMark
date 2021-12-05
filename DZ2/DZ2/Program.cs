using System;
// Вариант задания 6
namespace DZ2
{
    class Program
    {
        //Создаем методы для расчета значений на отрезках
        static double Segment1(double x)
        {
            double y = -3;
            return y;
        }
        static double Segment2(double x)
        {
            double y = x + 3;
            return y;
        }
        static double Segment3(double x, double r)
        {
            //задаем условие для введенного радиуса.чтобы узнать о наличие точек разрыва второго рода
            if (r < 3 && (x > r || x < -r)) {
                Console.WriteLine("Разрыв второго рода,функция не определена");
                return 0;
            }
            if (r > 3)
                r = 3;
            double y = Math.Sqrt(r*r - x*x);
            return y;
        }
        static double Segment4(double x)
        {
            double y = 0.6*x - 1.8;
            return y;
        }
        static double Segment5(double x)
        {
            double y = 3;
            return y;
        }
        static void Main(string[] args)
        {
            //выводим значения y от х на заданном диапазоне
            for (double x = -8,r = 3; x < 10.2; x += 0.2)
            {
                if (x < -8)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x < -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                else if (x < -3)
                {
                    //при х = -5.0 выводим два значения у,так как в этой точки разрыв 1ого рода
                    if (x < -4.8)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, -3);
                    }
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
                }
                else if (x < 3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x, r));
                }
                else if (x < 8)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }
                else if (x < 10.2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                }
            }
            //запускаем бесконечный цыкл в котором вводятся значения х и r,а выводятся у
            while (true)
            {
                double x = double.Parse(Console.ReadLine());
                if (x < -8)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x < -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                else if (x < -3)
                {
                    if (x < -4.8)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, -3);
                    }
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
                }
                else if (x < 3)
                {
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x, r));
                }
                else if (x < 8)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }
                else if (x < 10.2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                }
            }
        }
    }
}
