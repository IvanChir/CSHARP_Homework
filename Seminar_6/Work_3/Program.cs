// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.


bool IsPolindrom(string str)
{
    str = str.Replace(" ", "").ToLower();
    char[] charArray = str.ToCharArray();
    for (int i = 0; i < charArray.Length/2; i++)
    {
        if(charArray[i] !=charArray[charArray.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();

bool result = IsPolindrom(input);

if(result)
{
    Console.WriteLine("Строка является полиндромом!");
}
else
{
    Console.WriteLine("Строка не является полиндромом!");
}


