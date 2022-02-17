using System;

namespace Lesson_5Task1
{
    class L5Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для трех сторон треугольника: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Perimeter(a, b, c);
        }
        static void Perimeter (int a, int b, int c)
        {
            int perim = a + b + c;
            Console.WriteLine($"Периметр: {perim}");
        }
    }
}
