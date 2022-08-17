// Ex29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

string Print_array (int[] arr)
{
    string result = "[";  //для вывода результата в квадратных скобках
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    //заполнение строки элементами массива, первый и последний эл-т строки - квадратные скобки
    for (int i = 0; i < arr.Length -1; i++)
    {
        //string p = Convert.ToString(arr[i]) + ",";
        result = result + $"{Convert.ToString(arr[i])}" + ", ";
    }
    result = result + $"{Convert.ToString(arr[arr.Length - 1])}" + "]";
    return result;
}
int[] newarray = new int[8];
Console.WriteLine("Заполним массив. Введите 8 элементов массива через Enter"); //ввод массива с консоли
string str_array = Print_array(newarray);
Console.WriteLine(str_array);





//void Print_array (int[] arr)//
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        int num = Convert.ToInt32(Console.ReadLine());
//        arr[i] = num;
//    }
//    Console.Write("[");                             //Вывод массива на экран в квадратных скобках
//    for (int i = 0; i < arr.Length - 1; i++)
    //{
    //    Console.Write($"{arr[i]}, ");
    //}
//    int end = arr.Length - 1;
 //   Console.WriteLine($"{arr[end]}]");
//}
//int[] newarray = new int[8];
//Console.WriteLine("Заполним массив. Введите 8 элементов массива через Enter"); //ввод массива с консоли
//Print_array(newarray);
