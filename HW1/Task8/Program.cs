// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N, n ;
Console.WriteLine ("Введите число: ") ;
N =Convert.ToInt32(Console.ReadLine()) ;
n = 1;
while (n <= N)
{
    if (n%2==0)
    {
    Console.WriteLine (n) ;
    }
    n+=1;
}
