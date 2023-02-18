//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateArray(int m)
// {
//     int[] array = new int[m];
//     Console.Write("Поочередно через Enter введите все элементы массива:" + "\r\n");
//     for(int i = 0; i < m; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowResult(int[] array)
// {
//     int counter = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//         if(array[i] > 0) counter++;
//     }
//     Console.Write("-> " + counter);
// }

// Console.WriteLine("Каков размер массива? ");
// ShowResult(CreateArray(Convert.ToInt32(Console.ReadLine())));

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] CreateArray()
{
    double[] array = new double[4];
    Console.Write("Поочередно через Enter введите значения b1, b2, k1 и k2:" + "\r\n");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double CalcX(double[] array)
{
    return (array[0] - array[1]) / (-1 * array[2] + array[3]);
}

double CalcY(double[] array, double x)
{
    return (array[3] * x + array[1]);
}

double[] array = CreateArray();
double x = CalcX(array);
Console.Write("(" + x + ";" + CalcY(array, x) + ")");