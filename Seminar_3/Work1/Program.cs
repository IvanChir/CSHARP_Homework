// Задание 1: Поиск элемента в массиве
// Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести: Присутствует/Не присутствует.

int[] array = { 1, 23, 4, 5, 10 };
int num = 3;

bool isExistNum = false;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] == num)
    {
        isExistNum = true;
        break; 
    }

}

string result = isExistNum ? "Присутствует" : "Не присутствует";  
Console.WriteLine(result);

