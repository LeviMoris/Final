string[] CreateArrayString(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите слово");
        arr[i] = Console.ReadLine();
    }
    return arr;
}



void PrintArray(string[] arr, string sep = ", ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
}



string[] CreateArrayThreeSymbol(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 3) count ++;
        else Console.Write($"{arr[i]} ");
    }
    return arr;
}


string[] array = CreateArrayString(5);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

Console.Write("[");
CreateArrayThreeSymbol(array);
Console.Write("]");