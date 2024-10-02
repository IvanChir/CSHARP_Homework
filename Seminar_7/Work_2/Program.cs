// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.



int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return 0;

}

Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
