Console.Clear();

int first = 0;
int second = 0;
int third = 0;
int temp;
string answer;
string space = " ";

Console.Write("Enter first number: ");
answer = Console.ReadLine();
first = Convert.ToInt32(answer);

Console.Write("Enter second number: ");
answer = Console.ReadLine();
second = Convert.ToInt32(answer);

Console.Write("Enter first number: ");
answer = Console.ReadLine();
third = Convert.ToInt32(answer);

Console.WriteLine(first + space + second + space + third);

if (second > first)
{
    temp = second;
    second = first;
    first = temp;
}

if (third > first)
{
    temp = third;
    third = first;
    first = temp;
}

Console.Write("The bigger number is -> ");
Console.WriteLine(first);