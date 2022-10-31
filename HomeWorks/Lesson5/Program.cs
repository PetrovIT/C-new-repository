/*
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int range)
{
    int index = 0;
    int[] array = new int[range];
    while (index < range)
    {
        array[index] = new Random().Next(100,1000);
        index++;
    }
    return array;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count-1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write($"{col[position]}]");
}

int TestChetn(int[] col)
{
    int result = 0;
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        if((col[position] % 2) == 0) result++;
        position++;
    }
    return result;
}
Console.WriteLine("Enter size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(m); 
int calc = TestChetn(array);
PrintArray(array);
Console.WriteLine($" -> {calc}");
*/

/*
// Задача 36:
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int range)
{
    int index = 0;
    int[] array = new int[range];
    while (index < range)
    {
        array[index] = new Random().Next(1,10);
        index++;
    }
    return array;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count-1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write($"{col[position]}]");
}

int SumNeChetn(int[] col)
{
    int result = 0;
    int position = 1;
    for (int length = col.Length; position < length; position += 2)
    {
        result += col[position];
    }
    return result;
}
Console.WriteLine("Enter size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(m); 
int sum = SumNeChetn(array);
PrintArray(array);
Console.WriteLine($" -> {sum}");
*/

// Задача 38:
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] FillArray(int range)
{
    int index = 0;
    int[] array = new int[range];
    while (index < range)
    {
        array[index] = new Random().Next(1,100);
        index++;
    }
    return array;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count-1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write($"{col[position]}]");
}

int DifferentMinMax(int[] col)
{
    int min = col[0];
    int max = col[0];
    for (int index = 1; index < col.Length; index++) 
    {
        if (col[index] > max) max = col[index];
        if (col[index] < min) min = col[index];
    }
    return (max - min);
}
Console.WriteLine("Enter size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(m); 
int different = DifferentMinMax(array);
PrintArray(array);
Console.WriteLine($" -> {different}");

// changes