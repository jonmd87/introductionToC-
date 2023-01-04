// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateIntArray()
{

    int[,] array = new int[new Random().Next(0, 10), new Random().Next(0, 10)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
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

void ShowArithmeticEachColumn(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            summ += array[j, i];
        double num = Convert.ToDouble(summ) / Convert.ToDouble(array.GetLength(1));
        System.Console.WriteLine($" Arithmetic mean of {i + 1} column = {num}");
    }
}

int[,] array = CreateIntArray();
PrintArray(array);
ShowArithmeticEachColumn(array);