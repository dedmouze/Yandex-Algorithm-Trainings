using System;

int K = int.Parse(Console.ReadLine());
int[][] coordinates = new int[K][];
for(int i = 0; i < K; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    coordinates[i] = new int[2];
    coordinates[i][0] = int.Parse(line[0]);
    coordinates[i][1] = int.Parse(line[1]);
}

int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;
for(int i = 0; i < coordinates.Length; i++)
{
    minX = Math.Min(minX, coordinates[i][0]);
    minY = Math.Min(minY, coordinates[i][1]);
    maxX = Math.Max(maxX, coordinates[i][0]);
    maxY = Math.Max(maxY, coordinates[i][1]);
}

Console.WriteLine(minX + " " + minY + " " + maxX + " " + maxY);