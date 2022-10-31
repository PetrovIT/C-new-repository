/*
//Задача 2. Напишите программу, которая на вход принимает два числа и выдает, 
//какое число больше, а какое меньше

Console.WriteLine("Enter a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b = ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) max = b;

Console.WriteLine(max);
*/

/*
// Задача 4. Напишите программу, которая принимает на вход три числа и выдает
// максимальное из этих чисел

Console.WriteLine("Input three numbers: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.WriteLine("Maximum is " + max);
*/

/*
// Задача 6. Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
int ostat = num % 2;

if(ostat == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

/*
// Задача 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(N > 2)
{
    Console.Write("All even nambers, before N is: ");
    while(count <= N)
    {
    Console.Write(count + ", ");
    count += 2;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("ERROR: invalid volume! Please enter correct number.");
}
*/
