/*
// Задача 0. Найти в произвольном двузначном числе наибольшую цифру

int FindBiggestDigit(int num)
{
//    int max = dec;

    int ed = num % 10;
    int dec = num / 10;
    int max = dec;
    if(ed > dec)
        max = ed;
//    else
//        max = dec;

    return max;
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Задача 1. Необходимо написать программу, которая выводит случайное трехзначное число
// и удалаяет вторую цифру этого числа.
/*
int TwoDigitNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int result = sot * 10 + ed;
    
    return result;
}

int number = new Random().Next(100,1000);
int resultNumber = TwoDigitNumber(number);

Console.WriteLine($"The twodigit number of {number} is {resultNumber}");
*/

// Задача 2. Необходимо написать программу, которая принимает на вход число некоторое целое число
// и проверяет кратно ли оно числу А и В (тоже входящие данные)

bool Kratnost(int num, int a, int b)
{
    bool result;
    
    if(num % a == 0 && num % b == 0)
    {
        result = true;
    }
    else
    {
        result = false;
    }

    return result;   
}

Console.WriteLine("Введите проверяемое на кратность число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый делитель: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй делитель: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool otvet = Kratnost(number, num1, num2);

Console.WriteLine($"Результат проверки числа {number} - {otvet}");