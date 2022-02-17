using System;

namespace Lesson_5Task1
{
    class L5Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для трех сторон треугольника: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр: " + Perimeter(a, b, c));
        }
        static int Perimeter(int a, int b, int c)
        {
            int perim = a + b + c;
            return perim;
        }
    }
}
