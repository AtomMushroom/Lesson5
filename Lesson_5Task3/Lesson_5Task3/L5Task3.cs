using System;

namespace Lesson_5Task3
{
    class L5Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, x2, y1, y2): ");
            int x1 = Int32.Parse(Console.ReadLine()); 
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());
            Distance(x1, x2, y1, y2);
        }
        static void Distance (int x1, int x2, int y1, int y2)
        {
            int X = x2 - x1;
            int Y = y2 - y1;
            double res = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y,2));
            Console.WriteLine($"Расстояние: {res}");
        }
    }
}
