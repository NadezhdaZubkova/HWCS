// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n];
//      for (int i =0; i < matrix.GetLength(0);i++)
//      {
//          for ( int j=0; j<matrix.GetLength(1); j++)
//          {
//              matrix[i,j] = new Random().Next(10);
//          }
//      }
//      return matrix;
// }

// void PrintMatrix(int [,] inputMatrix)
// {
//     for ( int i=0; i<inputMatrix.GetLength(0); i++)
//      {
//          for (int j = 0; j< inputMatrix.GetLength(1); j++)
//          {
//              Console.Write(inputMatrix[i,j] + "\t");
//          }
//          Console.WriteLine(); 
//      }
// }


// int [,] BubleSorte(int [,] resultMatrix)
// {
//    int [,] SortMatrix = resultMatrix;
//     for (int i=0; i<resultMatrix.GetLength(0);i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < resultMatrix.GetLength(1) - 1; z++)
//             {
//                 if (resultMatrix[i,z]< resultMatrix[i,z+1])
//                 {
//                     int tmp = resultMatrix[i,z];
//                     resultMatrix[i, z] = resultMatrix[i,z+1];
//                     resultMatrix[i,z+1]= tmp;
//                 }
//             }        
//         }     
//     }
//     return SortMatrix;
// }

// int [,] resultMatrix = GetMatrix(5,8);
// PrintMatrix(resultMatrix);

// Console.WriteLine();
// int [,]SortMatrix = BubleSorte(resultMatrix);
// PrintMatrix(SortMatrix);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GetMatrix(int m, int n) 
// {
//     int[,] matrix = new int[m,n];
//      for (int i =0; i < matrix.GetLength(0);i++)
//      {
//          for ( int j=0; j<matrix.GetLength(1); j++)
//          {
//              matrix[i,j] = new Random().Next(10);
//          }
//      }
//      return matrix;
// }

// void PrintMatrix(int [,] inputMatrix)
// {
//     for ( int i=0; i<inputMatrix.GetLength(0); i++)
//      {
//          for (int j = 0; j< inputMatrix.GetLength(1); j++)
//          {
//              Console.Write(inputMatrix[i,j] + "\t");
//          }
//          Console.WriteLine(); 
//      }
// }

// int [,] resultMatrix = GetMatrix(4,4);
// PrintMatrix(resultMatrix);

// int minSum = Int32.MaxValue;
// int indexLine = 0;
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {   
//     int sum = 0;
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//         sum = sum + resultMatrix[i, j];
//     }
//     if (sum < minSum)
//     {
//         minSum = sum;
//         indexLine++;
//     }
// }


// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexLine},сумма равна: {minSum}" );






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] GetMatrix(int m, int n) 
// {
//     int[,] matrix = new int[m,n];
//      for (int i =0; i < matrix.GetLength(0);i++)
//      {
//          for ( int j=0; j<matrix.GetLength(1); j++)
//          {
//              matrix[i,j] = new Random().Next(10);
//          }
//      }
//      return matrix;
// }

// void PrintMatrix(int [,] inputMatrix)
// {
//     for ( int i=0; i<inputMatrix.GetLength(0); i++)
//      {
//          for (int j = 0; j< inputMatrix.GetLength(1); j++)
//          {
//              Console.Write(inputMatrix[i,j] + "\t");
//          }
//          Console.WriteLine(); 
//      }
// }
// int n =2;
// int [,] firstMatrix = GetMatrix(n,n);
// int [,] secondMatrix = GetMatrix(n,n);
// PrintMatrix(firstMatrix);
// Console.WriteLine();
// PrintMatrix(secondMatrix);


// int[,] resultMatrix = new int[n,n];
//      for (int i =0; i <n;i++)
//      {
//          for ( int j=0; j<n; j++)
//          {
//             for (int k =0; k < n; k++)
//             {
//                 resultMatrix[i,j] = resultMatrix[i,j] + (firstMatrix[i,k]*secondMatrix[k,j]);
//             }
//          }
//      }

// System.Console.WriteLine($"Произведение матриц: ");
// PrintMatrix(resultMatrix);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7



void PrintMatrix(int [,] inputMatrix)
{
    for ( int i=0; i<inputMatrix.GetLength(0); i++)
     {
         for (int j = 0; j< inputMatrix.GetLength(1); j++)
         {
             Console.Write(inputMatrix[i,j] + "\t");
         }
         Console.WriteLine(); 
     }
}

int[,] GetMatrix(int n) 
{
    int[,] matrix = new int [n,n];
    int num =1;
    int i = 0;
    int j = 0; 
    while (num <= n*n)
    {
        matrix[i,j]=num;
        if (i<=j+1 && i+j< n-1)
        j++;
        else if (i<j && i+j >= n-1)
        i++;
        else if (i>=j && i+j >n-1)
        j--;
        else
        i--;
        num++;
    }   
    return matrix;
}

int [,] Matrix = GetMatrix(4);
PrintMatrix(Matrix);
