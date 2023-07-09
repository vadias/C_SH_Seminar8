// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] FillMatrix(int row, int col, int minrange, int maxrange)
{
    int[,] tempmatrix = new int[row, col];
    Random rand = new Random();
    for(int i = 0; i < tempmatrix.GetLength(0); i++)        // запонение строк
    {
        for(int j = 0; j < tempmatrix.GetLength(1); j++)    // заполнение столбцов
        {
             tempmatrix[i,j] = rand.Next(minrange, maxrange); // генерация случайных вещественных чисел
        }
            
    }
    return tempmatrix;
}

int[,] MatrixSorting(int[,] tempmatrix)
{
    int temp = 0;
    for(int t = 0; t < tempmatrix.GetLength(0); t++ )
    {
         for (int i = 0; i < tempmatrix.GetLength(1); i++)
            {
                for (int j = i + 1; j < tempmatrix.GetLength(1); j++)
                {
                    if (tempmatrix[t,i] < tempmatrix[t,j])
                    {
                        temp = tempmatrix[t,i];
                        tempmatrix[t,i] = tempmatrix[t,j];
                        tempmatrix[t,j] = temp;
                    }                   
                }            
            }
    }
    return tempmatrix;
}

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] tempmatrix)
{
    Console.WriteLine();
     for(int i = 0; i < tempmatrix.GetLength(0); i++)        // запонение строк
    {
        for(int j = 0; j < tempmatrix.GetLength(1); j++)    // заполнение столбцов
        {
            System.Console.Write(tempmatrix[i,j] + "\t");    // печать значение через отступ с табуляцией
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
matrix = MatrixSorting(matrix);
PrintMatrix(matrix);