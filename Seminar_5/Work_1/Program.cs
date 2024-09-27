// Задание 1: Поиск максимального элемента в каждой строке
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит максимальный элемент в каждой строке массива и выводит его.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }

}


void FindMaxNumInRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxNum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (maxNum < matrix[i, j])
            {
                maxNum = matrix[i, j];
            }
        }
        Console.WriteLine($"Максимальное число в строке {i}: {maxNum}");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

FindMaxNumInRow(array2d);


