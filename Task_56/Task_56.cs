// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
}

void GetMinRow(int[,] tempmatrix)
{   
    int min = 0xFFFF;
    int index = 0;
    int temp = 0;
    int[] array = new int[tempmatrix.GetLength(1)];

    for(int t = 0; t < tempmatrix.GetLength(0); t++ )
    {
         for (int i = 0; i < tempmatrix.GetLength(1); i++)
            {
                array[t] = array[t] + tempmatrix[t,i];          
            }
    }

    for(index = 0; index < array.Length; index++)
    {
        if(min > array[index]) {
            temp = index;
        }
    }
     System.Console.Write($"Наименьшая сумма во {temp} строке");
}

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Введите число строк: ");
int cols = ReadInt("Введите число столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
GetMinRow(matrix);