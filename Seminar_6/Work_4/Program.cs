// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Введите предложение: ");
string str = Console.ReadLine();

string[] strSplit = str.Split();

string res = "";

for (int i = strSplit.Length - 1; i >= 0; i--)
{
    res += strSplit[i] + " ";
}

Console.WriteLine(res);