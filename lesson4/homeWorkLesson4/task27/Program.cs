// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int countSumOfDigits(int number)
{
    int ten = 10;
    if (number < ten)
        return number;
    else
        return (number % ten + countSumOfDigits(number / ten));
}

Console.Clear();

System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(countSumOfDigits(number));