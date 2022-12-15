// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (без использования Math.Pow).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberInDegree(int number, int degree)
{
    if (degree == 1)
        return number;
    else
        return number * numberInDegree(number, degree - 1);
}

Console.Clear();

System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter the degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(numberInDegree(number, degree));