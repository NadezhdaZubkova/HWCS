// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] GetMatrix( int m , int n)
// {
//    Random num = new Random();
//    //int sign =new Random().Next(-100,100); при добавлении этой строчки выходят толькоотрицательные значения
//     double [,] matrix = new double [m , n];
//     for (int i =0; i < matrix.GetLength(0);i++)
//     {
//          for ( int j=0; j<n; j++)
//          {
//             matrix[i,j] = Math.Round(num.NextDouble()*10 , 2); //matrix[i,j] = Math.Round(num.NextDouble()*10*sign , 2);
//          }
//      }
//      return matrix;
//  }
//  void PrintMatrix(double [,] inputMatrix)
//  {
//      for ( int i=0; i<inputMatrix.GetLength(0); i++)
//      {
//          for (int j = 0; j< inputMatrix.GetLength(1); j++) 
//          {
//              Console.Write(inputMatrix[i,j] + "\t");
//          }
//          Console.WriteLine(); 
//      }
//  }

// Double [,] resultMatrix = GetMatrix (rows , colums);
// PrintMatrix(resultMatrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.Write("Введите номер строки: ");
//  int row = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Введите номер столбца: ");
//  int column = Convert.ToInt32(Console.ReadLine());

//  int[,] GetMatrix(int m, int n)
//  {
//      int [,] matrix = new int [m,n];
//      for (int i =0; i < matrix.GetLength(0);i++)
//      {
//          for ( int j=0; j<n; j++)
//          {
//              matrix[i,j] = new Random().Next(11);
//          }
//      }
//      return matrix;
//  }

//  void PrintMatrix(int [,] inputMatrix)
//  {
//      for ( int i=0; i<inputMatrix.GetLength(0); i++) 
//      {
//          for (int j = 0; j< inputMatrix.GetLength(1); j++)
//          {
//              Console.Write(inputMatrix[i,j] + "\t");
//          }
//          Console.WriteLine(); 
//      }
//  }
 
//  int [,]resultMatrix = GetMatrix(3,4);
//  PrintMatrix(resultMatrix);

// void CheckIndex (int row, int column)
// {
// bool isTrue = false;
// for ( int i=0; i<resultMatrix.GetLength(0); i++) 
//      {
//          for (int j = 0; j< resultMatrix.GetLength(1); j++)
//          {
//              if (row <= i && column<=j)
//              {
//                 isTrue = true; 
//              }
//          } 
//      }
//   Console.WriteLine($"{(isTrue ? "Да" : "Нет")}");
// }
// CheckIndex (row,column);




// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
  int rows = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите количество столбцов: ");
  int columns = Convert.ToInt32(Console.ReadLine());

  int[,] GetMatrix(int m, int n)
  {
      int [,] matrix = new int [m,n];
      for (int i =0; i < matrix.GetLength(0);i++)
      {
          for ( int j=0; j<matrix.GetLength(1); j++)
          {
              matrix[i,j] = new Random().Next(11);
          }
      }
      return matrix;
  }

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
 
  int [,]resultMatrix = GetMatrix(rows,columns);
  PrintMatrix(resultMatrix);
  average(resultMatrix);

void average(int [,] resultMatrix)
{
   for (int j =0; j<resultMatrix.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i<resultMatrix.GetLength(0); i++)
         {
           sum =sum +resultMatrix[i,j];
         }
           Console.Write(Math.Round(sum/(resultMatrix.GetLength(0)) , 1) + "\t");
    } 
}
    

