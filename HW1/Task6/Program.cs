// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
int a;
Console.WriteLine ("Введите число: ") ;
a =Convert.ToInt32(Console.ReadLine()) ;
if ( a%2== 0 ) 
{
    Console.Write ("Четное") ;
}
else
{
    Console.Write ("НЕчетное") ;
}
