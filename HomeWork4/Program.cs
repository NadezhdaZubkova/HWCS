// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {A} в степени {B} равно {GetExp(A,B)}");

// int GetExp (int A, int B)
// {
//     int count = 0;
//     int result=1;
//     while (count<B)
//     {
//         count++;
//         result=result*A;
//     }
//     return result;
// }


// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int Num = Convert.ToInt32(Console.ReadLine());
// int Sum=0;
// while (Num>0)
// {
//     Sum= Sum +Num%10;
//     Num=Num/10;
// }
// Console.WriteLine(Sum);



// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

   int [] array =new int[8];
     for (int i =0; i<array.Length; i++)
     {
         array[i]= new Random().Next(-100,100);
     }
     
  Console.WriteLine($"Result array: [{String.Join(";", array)}]");

