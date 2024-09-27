// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).


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

void TransposeMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[,] transposedMatrix = new int[cols, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            transposedMatrix[j, i] = matrix[i, j];
        }
    }

    Console.WriteLine($"Транспортированный массив:");
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{transposedMatrix[i, j],4}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 2, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

TransposeMatrix(array2d);