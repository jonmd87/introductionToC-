// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void CheckNumbersOrder(ref int first, ref int second)
{
    if (first > second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}


int Summ(int first, int second)
{
    if (first == second)
        return first;
    return first + Summ(first + 1, second);
}


Console.Clear();

System.Console.Write("Enter first number(only positive number): ");
int first = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second number(only positive number): ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > 0 && second > 0)
{
    CheckNumbersOrder(ref first, ref second);
    System.Console.WriteLine($"M = [{first}]; N = [{second}]; summ = {Summ(first, second)};");
}
else
    System.Console.WriteLine("Only positive numbers!!");
