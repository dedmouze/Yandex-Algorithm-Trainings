using System;

int N = int.Parse(Console.ReadLine());
bool[,] visited = new bool[N, N];
for(int i = 0; i < N; i++)
{
    string row = Console.ReadLine();
    for (int j = 0; j < N; j++)
        if (row[j] == '*') visited[i, j] = true;
}

string[] input = Console.ReadLine().Split(' ');
(int, int) room = (int.Parse(input[0]), int.Parse(input[1]));

int area = 0;
int[] dR = new int[4] { 0, 0, -1, 1 };
int[] dC = new int[4] { -1, 1, 0, 0 };
DFS(room.Item1 - 1, room.Item2 - 1);
Console.WriteLine(area);

void DFS(int row, int col)
{
    area++;
    visited[row, col] = true;
    for(int i = 0; i < 4; i++)
        if (!visited[row + dR[i], col + dC[i]])
            DFS(row + dR[i], col + dC[i]);
}