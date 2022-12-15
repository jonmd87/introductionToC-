// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

System.Console.WriteLine("Enter the length of array(only possitive number): ");
int length = Convert.ToInt32(Console.ReadLine());

if (length > 0)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1000);

    length = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            length++;

    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"[{array[i]}] ");

    System.Console.WriteLine($" -> {length}");
}
else
    System.Console.WriteLine("Error!");