// Ex29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

   // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

   // 6, 1, 33 -> [6, 1, 33]

//Ввод массива с консоли
Console.WriteLine("Заполним массив. Введите 8 элементов массива через Enter");
int[] newarray = new int[8];
for (int index = 0; index < newarray.Length; index++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        newarray[index] = num;
    } 
    
//Вывод массива на экран в квадратных скобках
int count = newarray.Length;
Console.Write("[");
for (int position = 0; position < 7; position++)
    {
        Console.Write($"{newarray[position]}, ");
    } 
Console.WriteLine($"{newarray[7]}]"); 
