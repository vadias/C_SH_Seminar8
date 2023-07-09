//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] FillMatrixSpiral(int start)
{
    int n = 4;
    int[,] matrix = new int[n,n];

     int j = 0;
     int k = 0;
     int p = n/2;

    for(k=1; k<=p; k++)/*Цикл по номеру витка*/
    {
        for (j=k-1;j<n-k+1;j++) {
                matrix[k-1,j]=start++; 
            }/*Определение значений верхнего гор столбца*/ 
        for (j=k;j<n-k+1;j++) {
                matrix[j, n-k] = start++;/* --//-- По правому вертикальному столбцу*/ 
        } 
        for (j=n-k-1;j>=k-1;--j) {
            matrix[n-k, j] = start++;/* --//-- по нижнему горизонтальному столбцу*/  
        } 
        for (j=n-k-1;j>=k;j--) {
            matrix[j, k-1] = start++;
            }/* --//-- по левому вертикальному столбцу*/
 }  
    return matrix;
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

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Start = ReadInt("Введите начальное значени: ");
int[,] matrix = FillMatrixSpiral(Start); 
PrintMatrix(matrix);