// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

System.Console.WriteLine("Enter the length of array(only possitive number): ");
int length = Convert.ToInt32(Console.ReadLine());

if (length > 0)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * (new Random().Next(1, 10));

    length = 0;
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"[{array[i]}] ");
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    System.Console.WriteLine($" ->{max - min}");
}
else
    System.Console.WriteLine("Error!");