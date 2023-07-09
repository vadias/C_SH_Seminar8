// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] GetMult(int[,] A, int[,] B) {
    int[,] C = new int[A.GetLength(0) , A.GetLength(1)];
    for(int i = 0; i < A.GetLength(1); i++)
    {
        for(int j = 0; j < A.GetLength(0); j++)
        {
        C[i,j] = 0;
            for(int k = 0; k < A.GetLength(0); k++) {
                C[i,j] += A[i,k] * B[k,j];
            }
        }
    }

    return C;
}

void PrintMatrix(int[,] tempmatrix)
{
     for(int i = 0; i < tempmatrix.GetLength(0); i++)        // запонение строк
    {
        for(int j = 0; j < tempmatrix.GetLength(1); j++)    // заполнение столбцов
        {
            System.Console.Write(tempmatrix[i,j] + "\t");    // печать значение через отступ с табуляцией
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Введите число строк: ");
int cols = ReadInt("Введите число столбцов: ");
int[,] matrixA = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrixA);
int[,] matrixB = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrixB);
int[,] matrixC = GetMult(matrixA, matrixB);
PrintMatrix(matrixC);