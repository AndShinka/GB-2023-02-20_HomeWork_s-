// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

void PrintMass3D(int[,,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(0); j++)
        {   for (int k = 0; k < massive.GetLength(0); k++)
                Console.Write($"{massive[i , j , k]}({i},{j},{k})  " !);
            Console.WriteLine();
        } 
        Console.WriteLine();   
    }
}

int[,,] CreateMass3D(int sizeR)
{   
    int[,,] massive = new int[sizeR, sizeR , sizeR];
    int completion = 10;
    int length = massive.GetLength(0);
    for (int i = 0; i < length; i++)
        for (int j = 0; j < length; j++)
            for (int k = 0; k < length; k++)
            {
                massive[i , j , k] = completion; 
                completion++;
            }
            
    return massive;
}

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int numberRows = 0;
while (numberRows < 2 || numberRows > 4)
    numberRows = ReadNum("введите размерность трёхмерного массива от 2 до 4 :"!);

int[,,] array = CreateMass3D(numberRows);
//int[,,] massive = new int[numberRows, numberRows , numberRows];

Console.WriteLine("Задача: построчно выводить массив, добавляя индексы каждого элемента");
PrintMass3D(array);
