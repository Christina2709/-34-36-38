/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Задача №34");
Console.WriteLine("Введите массив из случайных положительных трехзначных чисел: ");
int[] Array = GetArray(7, 100, 999);
Console.WriteLine(String.Join(" ", Array));
int PositiveElement = 0;

int[] GetArray (int size, int minEl, int maxEl)
{
int []res = new int [size];
for (int i = 0; i < size; i ++)
    {
     res[i] = new Random().Next(minEl, maxEl + 1);
    }
return res; 
}
    foreach (var el in Array)
    {
        if (el % 2 == 0)
        {
             PositiveElement ++;
        } 
    }
Console.WriteLine($"Количество четных чисел в массиве - {PositiveElement}");*/

// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача №36");
Console.WriteLine("Введите одномерный массив из случайных чисел: ");
int[] Array = GetArray(5, 2, 15);
Console.WriteLine(String.Join(" ", Array));
int SumElementNegativeIndex = 0;

int[] GetArray (int size, int minEl, int maxEl)
{
int []res = new int [size];
for (int i = 0; i < size; i ++)
{
     res[i] = new Random().Next(minEl, maxEl + 1);
    }
return res; 
}
    int index = 0;
    for (index = 0; index<Array.Length; index++)
    {
        if (index % 2 != 0)
        {
            SumElementNegativeIndex += Array[index];
        }
    }
Console.WriteLine($"сумма элементов, стоящих на нечётных индексах - {SumElementNegativeIndex}");*/

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Задача №38");
Console.WriteLine("Введите массив из вещественных чисел: ");
double[] Massive = GetArray(8, 0,10);
Console.WriteLine(String.Join(" ", Massive));

double[] GetArray (int size, int minEl, int maxEl)
{
double []res = new double [size];
var element = new Random();
for (int i = 0; i < size; i ++)
    {
     res[i] = Convert. ToDouble(element.Next(-100, 100)/10);
    }
return res; 
}
double minmax(double[] Massive)
    {
        double min = Massive[0];
        double max = Massive[0];
    for (int Position = 0; Position<Massive.Length; Position++)
    {
        if (Massive[Position] < min) min = Massive[Position];
        if (Massive[Position] > max) max = Massive[Position];
    }
    return max - min;     
    }
Console.WriteLine($"разница: {minmax(Massive)}");

