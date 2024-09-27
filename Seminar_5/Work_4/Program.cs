// Задание 4: Замена отрицательных элементов в двумерном массиве
// Описание: Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения.


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


void ReplaceNegativeNumbers(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matrix[i, j] < 0)
            {
                matrix[i, j] = -matrix[i, j];
            }
        }
    }
    Console.WriteLine($"Массив без отрицательных чисел:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();

ReplaceNegativeNumbers(array2d);