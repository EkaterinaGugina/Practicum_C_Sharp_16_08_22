// Ex27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите число, number = ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (number >= 0)
{
    int n = number % 10;
    sum = sum + n;
    number = number / 10;
}
Console.Write("Сумма цифр этого числа равна  ");
Console.WriteLine(sum);
