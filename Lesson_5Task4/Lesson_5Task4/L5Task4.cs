using System;

namespace Lesson_5Task4
{
    class L5Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, x2, y1, y2): ");
            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние: " + Distance(x1, x2, y1, y2));
        }
        static double Distance(int x1, int x2, int y1, int y2)
        {
            int X = x2 - x1;
            int Y = y2 - y1;
            double res = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return res;
        }
    }
}
