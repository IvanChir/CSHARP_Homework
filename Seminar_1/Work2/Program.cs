// Задание 2
// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).


Console.WriteLine("Введите три числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
{
    Console.WriteLine($"Cреднее из этих чисел (то есть не самое большое и не самое маленькое): {num1}");
}
else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
{
    Console.WriteLine($"Cреднее из этих чисел (то есть не самое большое и не самое маленькое): {num2}");
}
else 
{
    Console.WriteLine($"Cреднее из этих чисел (то есть не самое большое и не самое маленькое): {num3}");
}