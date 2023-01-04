// // Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumbersList(int minNumber, int num)
{
    if (minNumber < num)
        Factorial(minNumber + 1, num);
    System.Console.Write($"{minNumber} ");
}


Console.Clear();

int maxNumber = Int32.MaxValue;
int minNumber = 1;
System.Console.Write($"Enter the possitive number from {minNumber} to {maxNumber}: ");
int num = Convert.ToInt32(Console.ReadLine());

// max int64 9223372036854775807
// max int32 2147483647
// max int16 32767

if (num < 1 || num > maxNumber)
{
    System.Console.WriteLine($"Numbers in range {minNumber} to {maxNumber}");
    return;
}
else
{
    System.Console.Write($"N = [{num}] -> ");
    NumbersList(minNumber, num);
    System.Console.WriteLine(";");
}