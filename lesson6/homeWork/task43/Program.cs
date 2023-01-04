// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double b1 = 0,
        b2 = 0,
        k1 = 0,
        k2 = 0;

System.Console.Write("Enter b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter k2: ");
k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

System.Console.WriteLine($"intersection ({x};{y})");