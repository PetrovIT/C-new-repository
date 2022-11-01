/*
///////////////////////////////////////////////////////////////////////////////////
// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] NewArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
    {
        Console.Write($"enter a {i+1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
}

int PositiveNums(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

Console.Write("Enter a size: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(m);
int count = PositiveNums(array);
//Console.WriteLine($"A positive numbers of array {ShowArray(array)} are {count}");
Console.Write("A positive numbers of array: [");
ShowArray(array);
Console.WriteLine(" ] is " + count);
*/

///////////////////////////////////////////////////////////////////////////////////
// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


x = (b2 - b1) / (k1 - k2)

y = (b1 * k2 - b2 * k1) / (k2 - k1)

k1 * x + b1 = k2 * x + b2;
