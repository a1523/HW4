// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся 
// пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] InputArray ()
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

    void PrintArrayToConsole(int[] array)
{
    Console.Write("Массив из 8 элементов: ");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
       for(int i = array.Length-1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    } 
}

int[] array = InputArray();
PrintArrayToConsole(array);
