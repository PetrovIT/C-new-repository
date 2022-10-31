// Урок 2.
/*
// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа.

int ThreeDigitNumber(int num)
{
    int dec = num / 10;
    int secondDigit = dec % 10;
    return secondDigit;
}

Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = ThreeDigitNumber(number);

Console.WriteLine($"Second digit of {number} is {secondDigit}");
*/
/*
// Задача 13. Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

// Команду Math.Abs(n) в интернете подсмтрел

int ThirdDigitOfNumber(int num)
{
    int i = 0;
    for (i = 100; num / i > 0; i *= 10)
    {
    }

    int count = i / 1000;
    int thirdDigit = (num / count) % 10;
    return thirdDigit;
}

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) > 99)
{
    int thirdDigit = ThirdDigitOfNumber(Math.Abs(number));
    Console.WriteLine($"Third digit of {number} is {thirdDigit}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
*/

// Задача 15. Напишите программу, которая принимает на фход цифру,
// обозначающую день недели, и проверяет, является ли этот день выхордным

string DayOfWeek(int day)
{
    string result = String.Empty;
    if(day < 6) result = "нет";
    else result = "да";
    return result;
}
Console.WriteLine("Enter number day of week: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if (weekday > 0 && weekday < 8) Console.WriteLine(DayOfWeek(weekday));
else Console.WriteLine("wrong day");