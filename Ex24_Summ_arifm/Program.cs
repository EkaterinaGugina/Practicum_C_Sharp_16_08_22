// Ex24 - Программа получает на вход число N и выводит сумму чисел от 1 до этого числа N.
Console.Write("Введите число, number = ");
int number = Convert.ToInt32(Console.ReadLine());

int SumToNum(int num)
{
    int sum = 0;
    for (int i = 1; i<= num; i++)
    {
        sum = sum + i;
    }
   return sum; 
}
int s = SumToNum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {s}");

// Второй способ - с помощью формулы арифметической прогрессии
Console.Write("Введите число, num = ");
int num = Convert.ToInt32(Console.ReadLine());   
    
int sum = (((1 + num) * num) * 5) / 10;
Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
    