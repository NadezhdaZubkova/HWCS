// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c, max ;
Console.WriteLine ("Введите три числа: ") ;
a =Convert.ToInt32(Console.ReadLine()) ;
b = Convert.ToInt32(Console.ReadLine()) ;
c = Convert.ToInt32(Console.ReadLine()) ;
max = a ;
if (b > a)    max = b;
if (c > max)  max = c;
Console.Write ("max =") ;
    Console.WriteLine (max);