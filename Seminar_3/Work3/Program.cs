// Задание 3: Поиск среднего значения массива
// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов массива.



int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8 };

int i = 0;
double sum = 0;
double average = 0;

while (i < array.Length)
{
    sum = sum + array[i];
    i++;
}
average = sum / array.Length;

Console.WriteLine(average);