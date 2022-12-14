Console.Clear();

int number;
string answer;
string odd = " is odd number";
string even = " is even number";

Console.Write("Enter number: ");
answer = Console.ReadLine();
number = Convert.ToInt32(answer);

answer = odd;

if (number % 2 == 0)
{
    answer = even;
}

Console.WriteLine(number + answer);
