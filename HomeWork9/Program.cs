
//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());


// int SumNums (int start , int end)
// {
//  	if (end == start) return end;
//  	else if (start > end) return start + SumNums(start-1, end);
//  	else  return end + SumNums(start , end-1);
// }

// Console.WriteLine($"Сумма элементов от {M} до {N} = {SumNums(M,N)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine($"Введите первое ПОЛОЖИТЕЛЬНОЕ ЦЕЛОЕ число:");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе ПОЛОЖИТЕЛЬНОЕ ЦЕЛОЕ число:");
int n =Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}