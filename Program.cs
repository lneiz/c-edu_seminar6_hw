//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateRandomArray(int m)
{
    int[] array = new int[m];
    Console.Write("Поочередно через Enter введите все элементы массива:" + "\r\n");
    for(int i = 0; i < m; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowResult(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if(array[i] > 0) counter++;
    }
    Console.Write("-> " + counter);
}

Console.WriteLine("Каков размер массива? ");
ShowResult(CreateRandomArray(Convert.ToInt32(Console.ReadLine())));