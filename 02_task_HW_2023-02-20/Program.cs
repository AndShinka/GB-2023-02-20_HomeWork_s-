// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Программа подсчёта суммы элементов в каждой строке и вывода номера строки с наименьшей суммой элементов.");
Console.WriteLine();

void PrintMass2D(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            Console.Write($"{massive[i , j]} \t" !);
        Console.WriteLine();
    }
}

int[,] CreateMass(int sizeR, int sizeC)
{   
    int[,] massive = new int[sizeR, sizeC];
    Random rnd = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
        for (int j = 0; j < massive.GetLength(1); j++)
            massive[i , j] = rnd.Next(0 , 11);
    return massive;
}

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FindMinimumRow (int[,] massive)
{
    int minSummRow = 0;
    int indexminSummRow = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {                   
        int summRow = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
            summRow = summRow + massive[i,j];
        if (i == 0)
            minSummRow = summRow;
        if (minSummRow > summRow)
        {
            minSummRow = summRow;
            indexminSummRow = i;
        }
    }
    return indexminSummRow;
}

int numberRows= ReadNum("Enter number of rows:"!);
int numberСolumns= ReadNum("Enter number of columns:"!);
int[,] array = CreateMass(numberRows, numberСolumns);


Console.WriteLine("Задача: подсчитать суммы элементов в каждой строке и вывести номера строки с наименьшей суммой элементов.");
PrintMass2D(array);
Console.WriteLine();
Console.WriteLine($" Номер строки с наименьшей суммой элементов в заданном массиве: {FindMinimumRow(array)} ");

//PrintMass2D(MinMaxRow(array));
Console.WriteLine();