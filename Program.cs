/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

Console.Clear();

string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[][] matrix = new string[][] { array1, array2, array3 };

PrintMatrix(matrix);


void PrintMatrix(string[][] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        ShowArray(matrix[i]);
        arraySymbolLimit3(matrix[i]);
        Console.WriteLine();
    }
}

void arraySymbolLimit3(string[] arr)
{
    Console.Write(" -> [");
    string[] res = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res[j] = arr[i];
            j++;
            if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
            else Console.Write($"\"{arr[i]}\"");
        }
    }
    Console.Write("]");
}

void ShowArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}
