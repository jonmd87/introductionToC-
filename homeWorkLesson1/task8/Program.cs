Console.Clear();
int number;
int count = 1;
string answer;
string space = " ";
string coma = ",";
string semicolon = ";";

Console.Write("Enter first number: ");
answer = Console.ReadLine();
number = Convert.ToInt32(answer);


while (count < number)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
    }
    if (count + 1 < number && count > 1 && count % 2 == 0)
    {
        Console.Write(coma + space);
    }
    count++;
}
if (number % 2 == 0)
{
    Console.Write(count);
}
Console.WriteLine(semicolon);
