// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
System.Console.Write("Enter the day of week(digit): ");
int day = Convert.ToInt32(Console.ReadLine());
int max = 8;
if (day < max && day > 0)
{
    if (day > 5)
        System.Console.WriteLine("Weekends day");
    else
        System.Console.WriteLine("Workday");
}
else
    System.Console.WriteLine("Error!!!");