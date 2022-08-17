// Ex26 - Прорамма получает на вход число и выводит количество цифр этого числа.
Console.Write("Введите число, number = ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNum(int num)
{
    int count = 0; //если не выполнится цикл, будет ясно, что в него не заходили
    for (int i = 1; num >= 10; i++)
    {
        num = num / 10;
        count = i +1; 
    }
   return count; 
}
Console.Write($"Количество цифр числа {number} равна {CountNum(number)}");
