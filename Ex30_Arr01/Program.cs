// Ex30 - Программа получает на вход массив из 8 элементов, заполняет его 0 и 1 случайным образом и выводит его на экран.
int[] newarray = new int[8];
void ArrayIn01(int arr01)
{
    for (int i = 0; i < arr01.Length; i++)
    {
        arr01[i] =  new Random().Next(0, 2);
        Console.Write($"{arr01[i]} ");
    } 
}   

Console.Write("[");
ArrayIn01(newarray);
Console.Write("]");
