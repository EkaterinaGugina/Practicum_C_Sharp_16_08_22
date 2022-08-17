// Ex27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
void SumNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int n = number % 10;
        sum = sum + n;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр этого числа равна  {sum}");
}
Console.Write("Введите число, N = ");
int N = Convert.ToInt32(Console.ReadLine());
SumNum(N);
Console.Write("Введите число, N1 = ");
int N1 = Convert.ToInt32(Console.ReadLine());
SumNum(N1);