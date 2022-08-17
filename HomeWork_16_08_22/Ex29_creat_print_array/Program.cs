// Ex29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void Print_array (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
    Console.Write("[");                             //Вывод массива на экран в квадратных скобках
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[i]}]");
}


int[] newarray = new int[8];
Console.WriteLine("Заполним массив. Введите 8 элементов массива через Enter"); //ввод массива с консоли
Print_array(newarray);






//for (int i = 0; i < length; i++)
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//       array[i] = num;
//   }
//    int count = length;       //Вывод массива на экран в квадратных скобках
//    Console.Write("[");
//    for (int position = 0; position < 7; position++)
//    {
//        Console.Write($"{newarray[position]}, ");
//    }
//    Console.WriteLine($"{newarray[7]}]");
//}

//int[] newarray = new int[8];
