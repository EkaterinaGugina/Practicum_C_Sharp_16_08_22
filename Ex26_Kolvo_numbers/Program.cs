// Ex26 - Прорамма получает на вход число и выводит количество цифр этого числа.
Console.Write("Введите число, number = ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNum(int num)
{
    int count = 0; 
    while (num >= 0)
    {
        num = num / 10;
        count += 1; 
    }
   return count; 
}
Console.Write($"Количество цифр числа {number} равно {CountNum(number)}");
