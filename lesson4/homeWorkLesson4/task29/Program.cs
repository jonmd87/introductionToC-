// Так как условия задачи невнятные или допущена ошибка, условия решил подправить
// Напишите программу, которая запрашивает у пользователя размер массива
// создает массив этого размера и  заполняет массив случайными числами
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

System.Console.WriteLine("Enter the length of array(only positive number!!!): ");
int length = Convert.ToInt32(Console.ReadLine());

if (length > 0)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
        array[i] = new Random().Next();
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"[{array[i]}] ");
    System.Console.WriteLine();
}
else
    System.Console.WriteLine("Error!!!");