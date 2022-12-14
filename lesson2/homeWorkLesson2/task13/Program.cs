// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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
    if (cell <= possision)
        return -1;
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
int possision = 3;

System.Console.Write("enter number: ");
number = getNumber();

System.Console.WriteLine(number);
System.Console.WriteLine();
int extructedNum = extractDigit(number, possision);
if (extructedNum == -1)
    System.Console.WriteLine($"the {possision}d digit doesn't exist!");
else
    System.Console.WriteLine(extructedNum);