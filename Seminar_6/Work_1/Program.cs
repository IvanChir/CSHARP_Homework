// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.




  

// Метод для создания строки из двумерного массива символов
string CreateStringFrom2DArray(char[,] array)
{
    string result = "";
    // Цикл по каждому элементу в двумерном массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Добавление каждого символа в результирующую строку
            result += array[i, j];
        }
    }
    return result;
}
  // Инициализация двумерного массива символов
    char[,] charArray = new char[,] { { 'a', ',' }, { '!', 'd' } };
    // Вызов метода для создания строки из 2D массива
    string result = CreateStringFrom2DArray(charArray);
    // Вывод результата
    Console.WriteLine(result);