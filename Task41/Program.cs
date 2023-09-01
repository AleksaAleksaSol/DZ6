// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Clear();
int CountOfElements(string message = "")
{
    Console.Write($"{message}Введите количество элементов в массиве:\t");
    int elementsCount = int.Parse(Console.ReadLine());
    return elementsCount;
}
int[] array = new int[CountOfElements()];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nСоздан массив:");
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

int CountPositivElements(int[] array)
{
    int countPositiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countPositiv++;
        }
    }
    return countPositiv;
}
Console.WriteLine($"В данном массиве количество чисел больше ноля равно: {CountPositivElements(array)} ");
Console.WriteLine();