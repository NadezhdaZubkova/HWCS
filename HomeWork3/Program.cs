// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 Console.WriteLine ("Введите пятизначное число: ") ;
 string num = Convert.ToString(Console.ReadLine());

 if (num[0]==num[4] && num[1]==num[3])
 Console.WriteLine ($"Число {num} - полиндром");
 else 
 Console.WriteLine ($"Число {num} - не является полиндромом");

// // Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату X1: ");
// int X1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите координату Y1: ");
//  int Y1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите координату Z1: ");
//  int Z1 = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Введите координату X2: ");
//  int X2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите координату Y2: ");
//  int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z2: ");
//  int Z2 = Convert.ToInt32(Console.ReadLine());

//  double d = Math.Sqrt(Math.Pow(X2-X1, 2)+ Math.Pow(Y2-Y1, 2)+ Math.Pow(Z2-Z1, 2));
//  Console.WriteLine($"Расстояние между точками: {Math.Round(d,2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int start = 1; start <= N; start++)
// {
//     Console.WriteLine(Math.Pow(start, 3));
// }