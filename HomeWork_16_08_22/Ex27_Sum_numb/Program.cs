// Ex27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите число, number = ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    while (num >= 0)
    {
        int n = num % 10;
        sum += n;
        num /= 10;
    }
   return sum; 
}
int s = SumNum(number);
Console.Write("Сумма цифр этого числа равна  ");
Console.WriteLine(s);
