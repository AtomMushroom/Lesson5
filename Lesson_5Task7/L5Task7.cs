int positive = 0;
int negative = 0;

PosNegSeq(ref positive, ref negative);

static void PosNegSeq(ref int positive, ref int negative)
{
    int number = 0;
    do
    {
        number = int.Parse(Console.ReadLine());
        if (number>0)
        {
            positive++;
        }
        else if (number<0)
        {
            negative++;
        }
    } while (number!=0);
    Console.WriteLine($"Положительные: {positive}");
    Console.WriteLine($"Отрицательные: {negative}");
}