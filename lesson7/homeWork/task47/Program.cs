// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// 
// m = 3, n = 4.
// 
// 0,5;    7;   -2; -0,2;
//   1; -3,3;    8; -9,9;
//   8;  7,8; -7,1;    9;


double[,] CreateDoubleArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000));
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" {array[i, j]} ");
        System.Console.WriteLine(";");
    }
}

Console.Clear();

System.Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows > 0 && columns > 0)
{
    double[,] array = CreateDoubleArray(rows, columns);
    PrintArray(array);
}