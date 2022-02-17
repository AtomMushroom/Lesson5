Console.WriteLine("Введите два двузначных числа: ");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Побитовая сумма чисел " + BitwiseSum(first, second));
static int BitwiseSum(int first, int second)
{
    int a = first / 10; //Десятки первого числа
    int b = first % 10; //Единицы первого числа

    int c = second / 10; //Десятки второго числа
    int d = second % 10; //Единицы второго числа
    int result = (a + c) * 10 + (b + d) % 10;
    return result;
}