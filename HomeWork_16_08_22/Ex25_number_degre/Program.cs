// Ex25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

Console.WriteLine("Введите два числа");          //ввод данных
Console.Write("A =");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B =");
int num2 = Convert.ToInt32(Console.ReadLine());

void Num1DegreeNum2(int n1, int n2)             //метод возведения n1 в степень n2
{
    int result = 1;
    for (int i = 1; i <= n2; i++)
    {
        result = result * n1;
    }
    Console.WriteLine($"{n1} ^ {n2} = {result}");
}
Num1DegreeNum2(A, B);