// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

//методы для ввода и вывода массива из случайных чисел в консоль
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
}

// решение задачи

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) return;
    Console.Write(array[index]);
    if (index > 0) Console.Write(", ");
    PrintArrayReverse(array, index - 1);
}


Console.WriteLine("Произвольный массив:");
int[] arr = CreateArrayRndInt(7, 1, 10);
PrintArray(arr);

Console.WriteLine();

Console.WriteLine("Массив в обратном порядке:");
PrintArrayReverse(arr, arr.Length - 1);
