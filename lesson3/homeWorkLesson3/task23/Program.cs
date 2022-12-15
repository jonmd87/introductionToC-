// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{number} -> ");

for (int i = 0; i != number;)
{
    i++;
    if (i > 1)
        Console.Write(", ");

    Console.Write($"{Convert.ToInt32(Math.Pow(i, 3))}");
}
System.Console.WriteLine(";");