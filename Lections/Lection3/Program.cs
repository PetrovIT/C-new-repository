// Лекция 3 по языку программирвоания С#

/*
// Задача: Дан текст. В тексте нужно все пробелы заменить черточками
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

Console.WriteLine(text);
Console.WriteLine();

string newText = Replace(text, ' ', '|');

newText = Replace(newText, 'к', 'К');

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
*/

/*
// Задача 2. Отсортировать последовательность чисел от наименьшего к наибольшему

int[] arr={1, 2, 4, 6, 7, 5, 3, 8, 4};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

// Дополнительное задание лекции:
// Изменить последнюю программу, чтобы на выходе все числа массива располагались
// в порядке убывания

// Ответ: надо во втором методе в условии if поменять знак < на знак > 
// и тогда он начнет сравнивать числа на максимум его значения и ставить это число в начало массива

int[] arr={1, 2, 4, 6, 7, 5, 3, 8, 4};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int maxPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);