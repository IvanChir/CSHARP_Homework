// Задание 4: Удаление всех отрицательных чисел
// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
// отрицательные числа из массива и возвращает новый массив, содержащий только
// неотрицательные числа.



int[] arr = { -1, 2, -3, 4, -5, 6 };
int count = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] >= 0)
    {
        count++;
    }
}

int[] nonNegativeNumbers = new int[count];
int index = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] >= 0)
    {
        nonNegativeNumbers[index] = arr[i];
        index++;
    }
}

for (int i = 0; i < nonNegativeNumbers.Length; i++)
{
    Console.Write(nonNegativeNumbers[i] + ", ");
}

