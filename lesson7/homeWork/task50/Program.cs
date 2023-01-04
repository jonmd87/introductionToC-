//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateIntArray()
{

    int[,] array = new int[new Random().Next(0, 10), new Random().Next(0, 10)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" {array[i, j]} ");
        System.Console.WriteLine(";");
    }
}

// Console.Clear();

int[,] array = CreateIntArray();
PrintArray(array);

System.Console.Write("enter row: ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("enter colums: ");
int column = Convert.ToInt32(Console.ReadLine());

if ((--row > 0 && --column > 0) && (row < array.GetLength(0) && column < array.GetLength(1)))
{
    System.Console.WriteLine($"element = {array[row, column]}");
}
else
    System.Console.WriteLine("This element doesn't exist!!");
