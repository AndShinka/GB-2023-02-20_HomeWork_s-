// 03_task_HW_2023-02-20
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Программа, которая будет находить произведение двух матриц");

void PrintMass2D(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            Console.Write($"{massive[i , j]} \t" !);
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix (int[,] massive1, int[,] massive2)
{
    int[,] multiplyMatrix = new int [massive1.GetLength(0), massive1.GetLength(0)];

    for (int i = 0; i < massive1.GetLength(0); i++)
        for (int j = 0; j < massive1.GetLength(0); j++)
            for (int k = 0; k < massive1.GetLength(0); k++)
                multiplyMatrix[i, j] += massive1[i, k] * massive2[k, j];
    return multiplyMatrix;
}


int[,] matrix1 = {
    {2 , 4},
    {3 , 2}
};
int[,] matrix2 = {
    {3 , 4},
    {3 , 3}
};

Console.WriteLine("Заданы две матрицы: ");
PrintMass2D(matrix1);
Console.WriteLine();
PrintMass2D(matrix2);

Console.WriteLine("Произведение двух заданных матриц :");
PrintMass2D(MultiplyMatrix(matrix1, matrix2));
Console.WriteLine();

