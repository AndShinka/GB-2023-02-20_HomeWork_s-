// 4. Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника



int[,] FillTriangle(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        massive[i, 0] = 1;
        massive[i, i] = 1;
    }

    for (int i = 2; i < massive.GetLength(0); i++)
        for (int j = 1; j <= i; j++)
            massive[i, j] = massive[i - 1, j - 1] + massive[i - 1, j];
    return massive;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:D4} ");
        Console.WriteLine();
    }
}
void PrintTriangle(int[,] array)
{   
    const int cellWidth = 5;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(0); j++)
        {
            if (array[i, j] != 0)
                Console.Write($"{array[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void MagicPrintNumber(int[,] array)
{
    const int cellWidth = 3;
    int col = cellWidth * array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if(array[i, j] !=0) Console.Write($"{array[i,j],cellWidth}   ");
            col += cellWidth * 2;
        }
        col = cellWidth * array.GetLength(0) - cellWidth * (i + 1);
        Console.WriteLine();
    }

}

void MagicPrintStar(int[,] array)
{
    const int cellWidth = 1;
    int col = cellWidth * array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (array[i, j] % 2 != 0) Console.Write("*");
            col += cellWidth * 2;
        }
        col = cellWidth * array.GetLength(0) - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Программа показа треугольника Паскаля, вывод в виде равнобедренного треугольника.");
Console.WriteLine("ДЛЯ ПРОДОЛЖЕНИЯ НАЖИМАЙТЕ ЛЮБУЮ КЛАВИШУ.");
Console.ReadKey();

int row = 16;
int[,] triangle = new int[row, row];

Console.Clear();
triangle = FillTriangle(triangle);

Console.WriteLine("Показ треугольника Паскаля, вывод в виде равнобедренного треугольника  * .");
MagicPrintStar(triangle);
Console.ReadKey();
Console.Clear();

Console.WriteLine("Показ треугольника Паскаля, вывод в виде равнобедренного треугольника  цифровыми значениями .");
MagicPrintNumber(triangle);
Console.ReadKey();
Console.Clear();

PrintTriangle(triangle);
Console.ReadKey();
Console.Clear();

PrintArray(triangle);
Console.ReadKey();
Console.Clear();

Console.WriteLine("СПАСИБО ЗА ВНИМАНИЕ !");
Console.WriteLine();







