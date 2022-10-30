//                                      Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество cтолбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine()!);

int[,] array = NewArray(size, columns, min, max);

int[,] NewArray(int size, int columns, int min, int max)
{
    int[,] mas = new int[size, columns];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
    return mas;
}


//                                      Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки: ");
int line = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столба: ");
int col = int.Parse(Console.ReadLine()!);

Ex(array, line, col);

void Ex(int[,] array, int line, int col)
{
    int[,] rez = new int[size, columns];

    if (line < size && col < columns)
    {
        rez[line, col] = array[line - 1, col - 1];
        Console.Write($"Число в этой ячейке: {rez[line, col]}");
    }
    else
    {
        Console.Write("Такого элемента ячейки не существует");
    }
}
Console.WriteLine();

//                                      Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
//                                   каждом столбце.

Average(array);

void Average(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumline = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumline = array[i, j] + sumline;
        }
        Console.WriteLine($"Сумма {j + 1} столбца равна {sumline}");

        sumline = sumline/array.GetLength(0);
        Console.WriteLine($"Cреднее арифметическое элементов в {j + 1} столбце равно {sumline}");

        Console.WriteLine();
    }
}