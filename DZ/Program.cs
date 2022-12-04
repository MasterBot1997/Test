// Задача: Напишите программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа. Первоначально массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуеца пользоватся коллекциями, либо обойтись исключительно массивами.

string[] NewArray(int size)
{
    string[] str = new string[size];
    for (int i = 0; i < str.Length; i++)
    {
        str[i] = Console.ReadLine();
    }
    return str;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int Size(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] Sort(string[] arr, int k)
{
    string[] newArray = new string[k];
    int z = 0;
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArray[z] = arr[i];
                z++;
            }
        }

    }
    return newArray;
}

Console.Write("Введите размер вашего массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = NewArray(n);
PrintArray(array);
int z = Size(array);
Console.WriteLine("Новый массив который содержит только элементы которые меньше либо равны 3 символам:");
string[] newArray = Sort(array, z);
PrintArray(newArray);
