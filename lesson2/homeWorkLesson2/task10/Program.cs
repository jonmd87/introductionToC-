// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int getNumber()
{
    string answer = Console.ReadLine();
    return (Convert.ToInt32(answer));
}

int extractDigit(int number, int possision)
{
    int ten = 10;
    int copyOfNumber = number;
    int cell = 1;
    while (copyOfNumber > ten)
    {
        cell++;
        copyOfNumber = copyOfNumber / 10;
    }
    int[] array = new int[cell];
    while (cell > 0)
    {
        cell--;
        array[cell] = number % 10;
        number = number / 10;
    }
    return array[possision - 1];
}

Console.Clear();
int number;
int showDigit = 2;

System.Console.Write("enter number that contain 3 digids: ");
number = getNumber();

System.Console.WriteLine(number);
System.Console.WriteLine();
System.Console.WriteLine(extractDigit(number, showDigit));