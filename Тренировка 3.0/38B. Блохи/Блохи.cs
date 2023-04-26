using System;
using System.Collections.Generic;

string[] NMSTQ = Console.ReadLine().Split(' ');
int N = int.Parse(NMSTQ[0]), M = int.Parse(NMSTQ[1]), 
    S = int.Parse(NMSTQ[2]), T = int.Parse(NMSTQ[3]), 
    Q = int.Parse(NMSTQ[4]);

int[,] distance = new int[N, M];
for (int i = 0; i < N; i++)
    for (int j = 0; j < M; j++)
        distance[i, j] = -1;

int[] dR = new int[8] { -1, -1, 1, 1, -2, -2, 2, 2 };
int[] dC = new int[8] { -2, 2, -2, 2, -1, 1, -1, 1 };
Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
queue.Enqueue((S - 1, T - 1));
distance[S - 1, T - 1] = 0;
while(queue.Count != 0)
{
    (int row, int col) coord = queue.Dequeue();
    for(int i = 0; i < 8; i++)
    {
        (int, int) next = (coord.Item1 + dR[i], coord.Item2 + dC[i]);
        if (next.Item1 < 0 || next.Item2 < 0 || next.Item1 >= N || next.Item2 >= M) continue;
        if (distance[next.Item1, next.Item2] != -1) continue;

        distance[next.Item1, next.Item2] = distance[coord.Item1, coord.Item2] + 1;
        queue.Enqueue(next);
    }
}

int sum = 0;
for(int i = 0; i < Q; i++)
{
    string[] coord = Console.ReadLine().Split(' ');
    (int row, int col) flea = (int.Parse(coord[0]) - 1, int.Parse(coord[1]) - 1);
    if (distance[flea.row, flea.col] == -1)
    {
        Console.WriteLine(-1);
        return;
    }
    sum += distance[flea.row, flea.col];
}
Console.WriteLine(sum);
