using System;

string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int N = int.Parse(input[0]);
int K = int.Parse(input[1]);
int M = int.Parse(input[2]);

string[,] field = new string[N + 2, K + 2];
for(int i = 1; i < N + 1; i++)
    for(int j = 1; j < K + 1; j++) field[i, j] = "0";

for (int i = 0; i < M; i++)
{
    string[] minesCoordinates = Console.ReadLine().Split(' ');
    field[int.Parse(minesCoordinates[0]), int.Parse(minesCoordinates[1])] = "*";
}

int[] dRow = { 1, 1, 1, 0, 0, -1, -1, -1 };
int[] dCol = { -1, 0, 1, -1, 1, -1, 0, 1 };
for(int i = 1; i < N + 1; i++)
{
    for(int j = 1; j < K + 1; j++)
    {
        if (field[i, j] == "*")
        {
            Console.Write("* ");
            continue;
        }
        int minesCount = 0;
        for(int l = 0; l < 8; l++)
            if (field[i + dCol[l], j + dRow[l]] == "*") minesCount++;
        Console.Write(minesCount.ToString() + " ");
    }
    Console.Write('\n');
}
