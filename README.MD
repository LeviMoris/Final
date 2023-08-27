# Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Создаем метод, который создает массив из строк
Код метода:
```
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

```
## Создаем метод, который печатает массив
Код метода:
```
void PrintArray(string[] arr, string sep = ", ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
}

```

## Создаем метод, который решает нашу задачу
Код метода:
```
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

```

## Выводим результат
Код:
```
string[] array = CreateArrayString(5);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

Console.Write("[");
CreateArrayThreeSymbol(array);
Console.Write("]");
```