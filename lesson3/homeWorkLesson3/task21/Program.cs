// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void readCoordinates(double[] array, string pointName)
{
    System.Console.WriteLine($"Enter coordinats for {pointName}:");
    int index = 0;
    char[] coordinates = { 'x', 'y', 'z' };

    while (index < array.Length)
    {
        System.Console.Write($"{pointName} ({coordinates[index]}): ");
        array[index] = Convert.ToDouble(Console.ReadLine());
        index++;
    }
}

double calculateCoordinates(double[] coordinatesA, double[] coordinatesB)
{
    double result = 0;

    for (int index = 0; index < coordinatesA.Length; index++)
        result += Math.Pow((coordinatesA[index] - coordinatesB[index]), 2);

    result = Math.Sqrt(result);

    return result;
}

Console.Clear();

double[] coordinatesA = new double[3];
double[] coordinatesB = new double[3];
string pointA = "point A";
string pointB = "point B";

readCoordinates(coordinatesA, pointA);
readCoordinates(coordinatesB, pointB);

double result = calculateCoordinates(coordinatesA, coordinatesB);
System.Console.WriteLine(result);
