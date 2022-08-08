int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

void GetStrings(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю строку:");
        stringArray[i] = Console.ReadLine();
    }
}

void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine(stringArray[i]);
    }
}

string[] FilterStringsArray(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if ((stringArray[i]).Length > 3) count++;
    }
    string[] newArrayOfString = new string[stringArray.Length - count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if ((stringArray[i]).Length <= 3)
        {
            newArrayOfString[j] = stringArray[i];
            j++;
        }
    }
    return newArrayOfString;
}

int m = GetNumber("Введите количество строк в массиве строк m:");

string[] arrayOfStrings = new string[m];
GetStrings(arrayOfStrings);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine();
PrintArray(arrayOfStrings);
string[] newArrayOfStrings = FilterStringsArray(arrayOfStrings);
Console.WriteLine();
Console.WriteLine("Новый массив:");
Console.WriteLine();
PrintArray(newArrayOfStrings);