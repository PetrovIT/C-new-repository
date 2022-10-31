/*

// Задача 1. Сравнить два числа: является ли первое число квадратом второго?

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

*/
/*
// Задача 2. Необхожимо написать программу где на выходе все числа в промежутке от -n до n

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}

*/

/*

// Задача 3. 

253 % 10 -> 3
253 % 100 -> 53
253 % 1000 -> 253

253 / 10 -> 25
253 / 100 -> 2
253 / 1000 -> 0

4827
4827 / 10 % 100 -> 82

*/

/*
// Задача 4. Напиши программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("Input three-digit number ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int LastDigit = n % 10;
    Console.WriteLine($"Last digit of {n} is {LastDigit}");
}
else
{
    Console.WriteLine("Uncorrent input!");
}
*/