// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)//
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] FillMatrix3D(int row, int col, int floor, int minrange, int maxrange)
{
    int[,,] tempmatrix = new int[row, col, floor];
    Random rand = new Random();
    for(int f = 0; f < tempmatrix.GetLength(2); f++) 
    {
        for(int i = 0; i < tempmatrix.GetLength(1); i++)        // запонение строк
        {
            for(int j = 0; j < tempmatrix.GetLength(0); j++)    // заполнение столбцов
            {
                tempmatrix[f,i,j] = rand.Next(minrange, maxrange); // генерация случайных вещественных чисел
            }
        }
    }
    return tempmatrix;
}

void PrintMatrix3D(int[,,] tempmatrix)
{
    for(int f = 0; f < tempmatrix.GetLength(2); f++)
    {
        for(int i = 0; i < tempmatrix.GetLength(1); i++)        // запонение строк
        {
            for(int j = 0; j < tempmatrix.GetLength(0); j++)    // заполнение столбцов
            {
                System.Console.Write(tempmatrix[f,i,j] );    // печать значение через отступ с табуляцией
                System.Console.Write($"({i}, {j}, {f})" + "\t");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] matrix = FillMatrix3D(2, 2, 2, 0, 99);
PrintMatrix3D(matrix);