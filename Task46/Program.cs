// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int SetNumbers(string message = " ")
{
    Console.Write($"{message}");
    int variable = int.Parse(Console.ReadLine());
    return variable;
}
Console.Clear();

Console.WriteLine("Дано два уровнения прямых линий:  ");
Console.WriteLine("\n1) y = k1 * x + b1");
Console.WriteLine("2) y = k2 * x + b2");
Console.WriteLine();

double b1 = SetNumbers("Введите переменную b1: ");
double k1 = SetNumbers("Введите переменную k1: ");
double b2 = SetNumbers("Введите переменную b2: ");
double k2 = SetNumbers("Введите переменную k2: ");

//Решая систему уровнений получаем координаты точки пересечения х=(b2-b1)/(k1-k2); y=k1*((b2-b1)/(k1-k2))+b1

double x = (b2-b1)/(k1-k2);
double y = k1*((b2-b1)/(k1-k2))+b1;
Console.WriteLine($"\nКоординаты точки пересечения: ({x}, {y})");
Console.WriteLine();
Console.WriteLine();
