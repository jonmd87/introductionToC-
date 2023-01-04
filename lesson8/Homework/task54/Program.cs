// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateArray()
{
    int rows = new Random().Next(2, 4);
    int columns = rows;

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($" {array[i, j]}");
        System.Console.WriteLine(";");
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int s = 0, b = 1; b < array.GetLength(0); b++)
        {
            System.Console.WriteLine($"b {array[i, b]}    s {array[i, s]}");

            if (array[i, b] < array[i, s])
            {
                int temp = array[i, b];
                array[i, b] = array[i, s];
                array[i, s] = temp;
            }
        }
    }
}

int[,] array = CreateArray();
PrintArray(array);
SortArray(array);
System.Console.WriteLine("array sorted:");
PrintArray(array);