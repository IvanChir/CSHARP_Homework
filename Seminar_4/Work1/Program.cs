// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.





while (true)
{
    Console.Write("Введите целое число (или 'q' для выхода): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "q")
    {
        break;
    }

    if (int.TryParse(input, out int number))
    {
        if (SumOfDigits(number) % 2 == 0)
        {
            Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод, пожалуйста, введите целое число или 'q'.");
    }
}

static int SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += Math.Abs(number % 10);
        number /= 10;
    }
    return sum;
}