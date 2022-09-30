/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/
Console.Clear();

string[] CreateArray(int size)
{
    string[] Array = new string[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        Array[i] = Convert.ToString(Console.ReadLine());
    }
    return Array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

void ThreeSymbolsArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int len = 3;
        if (array[i].Length <= len)
            Console.Write(array[i] + ", ");
    }
}

Console.WriteLine("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);

Console.WriteLine("Новый массив элементов, состоящих из трех и меньше символов: ");
ThreeSymbolsArray(myArray);
Console.WriteLine();