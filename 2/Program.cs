// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenght(int xA, int yA, int xB, int yB, int zA, int zB)
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return distance;
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int xPointA = GetInfo("Введите координату Х точки А: ");
int yPointA = GetInfo("Введите координату Y точки А: ");
int zPointA = GetInfo("Введите координату Z точки A: ");
int xPointB = GetInfo("Введите координату Х точки B: ");
int yPointB = GetInfo("Введите координату Y точки B: ");
int zPointB = GetInfo("Введите координату Z точки B: ");

Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {Lenght(xPointA, yPointA, xPointB, yPointB, zPointA, zPointB)}");