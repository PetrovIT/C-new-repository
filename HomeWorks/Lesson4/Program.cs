// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

/*
double Stepen(double a, int b)
{
    int i = 1;
    double result = a;
    while (i < b)
    {
        result *= a;
        i++;
    }
    return result;
}

Console.WriteLine("Enter a number: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a stepen: ");
int B = Convert.ToInt32(Console.ReadLine());

double answer = Stepen(A, B);
Console.WriteLine(answer);
*/
/*
// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummaDigits(int number)
{
    int num = number;
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;   
}
Console.WriteLine("Enter a number: ");
int numer = Convert.ToInt32(Console.ReadLine());

int answer = SummaDigits(numer);
Console.WriteLine(answer);
*/

// Задача 29: 
// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

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
Console.WriteLine("Enter size of array: ");
int m = Convert.ToInt32(Console.ReadLine());

PrintArray(FillArray(m));
Console.WriteLine();