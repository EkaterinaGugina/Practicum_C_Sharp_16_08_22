// Ex28 - Прорамма получает на вход число и выводит произведение цифр от 1 до этого числа.
Console.Write("Введите число, num = ");
int num = Convert.ToInt32(Console.ReadLine());

void MultToNum(int num1)
{
    int result = 1; 
    for (int i = 2; i <= num1; i++)
    {
        result = result * i; 
    }
   Console.WriteLine($"Произведение цифр от 1 до данного числа равно {result}"); 
}
MultToNum(num);


// Ex28 - Прорамма получает на вход число и выводит произведение цифр  этого числа.
Console.Write("Введите число, number = ");
int number = Convert.ToInt32(Console.ReadLine());

void MultNum(int num)
{
    int result = 1; 
    while (num > 0)
    {
        int i = num % 10;
        result = result * i; 
        num = num / 10;
    }
   Console.Write($"Произведение цифр числа равно {result}"); 
}
MultNum(number);
