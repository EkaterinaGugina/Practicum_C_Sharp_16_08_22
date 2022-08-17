// Ex25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите два числа");
Console.Write("num1 =");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("num1 =");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int count = 1; count <= num2; count++)
    {
        result = result * num1;
    } 
Console.WriteLine($"{num1}^{num2} = {result}");
