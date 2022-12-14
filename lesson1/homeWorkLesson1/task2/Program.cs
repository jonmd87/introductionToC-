Console.Clear();

int first = 0;
int second = 0;
string answer;

Console.Write("Enter first number: ");
answer = Console.ReadLine();
first = Convert.ToInt32(answer);

Console.Write("Enter second number: ");
answer = Console.ReadLine();
second = Convert.ToInt32(answer);

if (first == second)
{
    Console.WriteLine("This numbers are equals!!");
}

else if (first > second)
{
    Console.WriteLine(first + " bigger then " + second);
}

else
{
    Console.WriteLine(second + " bigger then " + first);
}