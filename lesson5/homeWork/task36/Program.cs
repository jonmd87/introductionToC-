// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0


Console.Clear();

System.Console.WriteLine("Enter the length of array(only possitive number): ");
int length = Convert.ToInt32(Console.ReadLine());

if (length > 0)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);

    length = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
            length += array[i];

    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"[{array[i]}] ");

    System.Console.WriteLine($" -> {length}");
}
else
    System.Console.WriteLine("Error!");