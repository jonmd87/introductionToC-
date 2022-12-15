string[,] table = new string[2, 3];

table[1, 2] = "table";

// for (int x = 0; x < 2; x++)
// {
// for (int y = 0; y < 3; y++)
// string temp = word + x + y;
// table[x][y] = temp;
// }
// 
for (int x = 0; x < 2; x++)
{
    for (int y = 0; y < 3; y++)
        System.Console.WriteLine(table[x, y]);
}

