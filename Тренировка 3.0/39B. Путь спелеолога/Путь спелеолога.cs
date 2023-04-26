using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());

(int, int, int) start = (-1, -1, -1);
int[,,] distance = new int[N, N, N];
for(int i = 0; i < N; i++)
{
    Console.ReadLine();
    for(int j = 0; j < N; j++)
    {
        string row = Console.ReadLine();
        for(int k = 0; k < N; k++)
        {
            if (row[k] == '#') distance[i, j, k] = -2;
            else if (row[k] == '.') distance[i, j, k] = -1;
            else
            {
                distance[i, j, k] = 0;
                start = (i, j, k);
            }
        }
    }
}


Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
queue.Enqueue(start);
(int row, int col, int height)[] directions = { (0, 0, 1), (0, 0, -1), (0, 1, 0), (0, -1, 0), (1, 0, 0), (-1, 0, 0) };
while(queue.Count != 0)
{
    (int row, int col, int height) coord = queue.Dequeue();
    for(int i = 0; i < 6; i++)
    {
        (int row, int col, int height) next = (
                                                coord.row + directions[i].row, 
                                                coord.col + directions[i].col, 
                                                coord.height + directions[i].height);
        if (next.row < 0 || next.row >= N || next.col < 0 || next.col >= N || next.height < 0 || next.height >= N) continue;
        if (distance[next.row, next.col, next.height] != -1) continue;

        distance[next.row, next.col, next.height] = distance[coord.row, coord.col, coord.height] + 1;
        queue.Enqueue(next);
    }
}

int min = int.MaxValue;
for(int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
        if (distance[0, i, j] != -2 && distance[0, i, j] != -1 && min > distance[0, i, j]) min = distance[0, i, j];

Console.WriteLine(min);