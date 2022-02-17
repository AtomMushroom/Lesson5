int number = Int32.Parse(Console.ReadLine());
ChangeDigits(number);
static void ChangeDigits(int number)
{
    int a = number/10; //Десятки
    int b = number%10; //Единицы
    Console.WriteLine(b * 10 + a);
}