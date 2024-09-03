// Задание 1
// Определите, делится ли число на другое
// Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".

Console.WriteLine("Введите первое целое число:");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (secondDigit == 0)
{
    Console.WriteLine("Делить на ноль нельзя!");
}
else if (firstDigit % secondDigit == 0)
{
    Console.WriteLine("Делится!");
}
else
{
    Console.WriteLine("Не делится!");
}