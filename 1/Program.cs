// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Check(string text)
{
    if (text.Length == 5)
    {
        if (text[0] == text[4] || text[1] == text[3])
        {
            Console.WriteLine($"Число {text} -> палиндром");
        }
        else
        {
            Console.WriteLine($"Число {text} -> не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Число не правильное");
    }
}

string GetInfo(string text)
{
    Console.Write(text);
    return Console.ReadLine(); // Хотелось бы узнать как можно исправить данное предупреждение.
}

string num = GetInfo("Введите пятизначное число: ");
Check(num);
