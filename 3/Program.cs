// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Sqr(int n)
{
    Console.Write($"{n} -> ");
    for (int i = 1; i < n; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine($"{Math.Pow(n, 3) + ". "}");
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine()); 
}

int n = GetInfo("Введите число N: ");
Sqr(n);
