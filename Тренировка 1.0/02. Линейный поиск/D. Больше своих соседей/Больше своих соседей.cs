using System;

string[] neighbours = Console.ReadLine().Split(' ');
if (neighbours.Length == 1) Console.WriteLine(0);
else
{
    int count = 0;
    for (int i = 1; i < neighbours.Length - 1; i++)
    {
        int number = int.Parse(neighbours[i]);
        if (number > int.Parse(neighbours[i - 1]) && number > int.Parse(neighbours[i + 1])) count++;
    }
    Console.WriteLine(count);
}