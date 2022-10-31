
/*
// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

string TestPolindrom(int number)
{
    string str = Math.Abs(number).ToString();
    int j = str.Length - 1;
    int i = 0;
    int count = 0;
    int countMax = str.Length / 2;
    string result = "error";
    while(count < countMax)
    {
        if(str[i] == str[j])
        {
            result = "yes";
            i++;
            j--;
            count++;
        }
        else 
        {
            result = "no";
            break;
        }
    }
    return result;
}
Console.WriteLine("Enter number to test for polindromnost: ");
int number = Convert.ToInt32(Console.ReadLine());
string answer = TestPolindrom(number);
Console.WriteLine(answer);
*/

// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
/*
double RasstPoints(double ax, double ay, double az, double bx, double by, double bz)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2)),3);
    return result;
}

Console.WriteLine("Enter position A (x .. ..): ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter position A (.. y ..): ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter position A (.. .. z): ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter position B (x .. ..): ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter position B (.. y ..): ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter position B (.. .. z): ");
double zb = Convert.ToDouble(Console.ReadLine());

double answer = RasstPoints(xa, ya, za, xb, yb, zb);
Console.WriteLine("Rasstoyanie ot A do B is: " + answer);
*/

// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// Math.Pow(a,b)

void CubeOfNumber(double number)
{
    Console.WriteLine($"Cube's table of numbers before {number} is: ");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} in cube = {Math.Pow(i,3)}");
    }
}

Console.WriteLine("Enter a number for job: ");
double N = Convert.ToDouble(Console.ReadLine());

CubeOfNumber(N);
