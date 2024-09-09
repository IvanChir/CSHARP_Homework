// Задача 2: 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using System; 
 
class Program 
{ 
    static void Main() 
    {
        Console.Write("Введите координату X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Первая координатная четверть");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Вторая координатная четверть");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Третья координатная четверть");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Четвертая координатная четверть");
        }
        else 
        {
            Console.WriteLine("Точка лежит на координатной линии");
        }
    }
}
