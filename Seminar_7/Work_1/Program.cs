// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8


void PrintRange(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m}, ");
    PrintRange(m + 1, n);
}

void PrintRangeRevers(int m, int n)
{
    if (n > m) return;
    Console.Write($"{m}, ");
    PrintRangeRevers(m - 1, n);
}


Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Числа в мромежутке от M до N: ");

PrintRange(m, n);
PrintRangeRevers(m, n);



