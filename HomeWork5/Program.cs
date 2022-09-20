// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int size = 4;
// int countEvenNumbers=0;
// int [] array = new int [size];
// for (int i =0; i< array.Length; i++)
// {
//     array[i]= new Random().Next(100,1000);
    
//     if (array[i] % 2 == 0) countEvenNumbers+=1; 
// }
// Console.Write($" array: [{String.Join(", " , array)}] ");
// Console.WriteLine($"Количество четных чисел = {countEvenNumbers} ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int size = 4;
// int Sum =0;
// int [] array = new int [size];
// for (int i =0; i< array.Length; i++)
// {
//     array[i]= new Random().Next(-15,16);
// }
// for (int i = 1; i< array.Length; i+=2)
// {
//     Sum= Sum+array[i];
// }
// Console.WriteLine($" Array: [{String.Join(", " , array)}]  Sum = {Sum} ");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = {3, 7, 22, 2, 78};
double diff = 0;
double min= array[0];
double max = array[0];
for (int i =1; i< array.Length; i++)
{
if (array[i] > max) max = array [i];
else if (array [i]< min) min= array[i];
}
diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным значением равна {diff}");