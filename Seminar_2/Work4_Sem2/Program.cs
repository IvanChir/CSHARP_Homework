// Задача 4:
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

using System; 
 
class Program 
{ 
    static void Main() 
    {
        Console.Write("Введите натуральное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num <= 0)
        {
            Console.Write("Ошибка. Введите натуральное число!!!");
        }
        else
        {
            string result = "";   // вводим строку для хранения (сохранения) цифр
            
            while (num > 0)  // начинаем извлекать цифры из числа
            {
               int currentDigit = num % 10; // выделяем челочисленый остаток, например 123 % 10 = 3, 345 % 10 = 5
               result = currentDigit + (result == ""?"" : ", " + result); // что творится в скобках: если result == пуст, то возвращатся пустая строка "", иначе если строка result == не пустая, то присваивается значение ", " + result 
               num /= 10; // num = num / 10, например  num = 123 / 10 = 12
            }
             
            Console.WriteLine("" + result);
        }
    }
}
