// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// преобразуем число в массив, если в числе не 5ть цифр возвращаем null
int[] numberToArray(int number, int lenth)
{
    int[] array = new int[5];
    int ten = 10;
    int index = 4;

    int cells = 1;
    int copyOfNumber = number;
    while (copyOfNumber > ten)
    {
        cells++;
        copyOfNumber = copyOfNumber / ten;
    }
    if (cells != lenth)
        return null;
    while (number > ten)
    {
        array[index] = number % ten;
        number = number / ten;
        index--;
    }
    array[index] = number;
    return array;
}



string checkIfPalindrom(int[] array)
{
    int head = 0;
    int tail = array.Length - 1;
    string answer = " isn't palindrom.";

    if (array[head] == array[tail])
    {
        head++;
        tail--;
        if (array[head] == array[tail])
            answer = " is a palindrom.";
    }


    return answer;
}

Console.Clear();
System.Console.WriteLine("Please enter the number that contain 5 digits!!!");

int lenth = 5;
int number = Convert.ToInt32(Console.ReadLine());
int[] array = numberToArray(number, lenth);
int index = 0;

if (array != null)
{
    System.Console.WriteLine($"{number} {checkIfPalindrom(array)}");
}
else
    System.Console.WriteLine($"You must entered the number that contain 5 digits");