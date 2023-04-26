using System;
using System.Collections.Generic;

string[] NM = Console.ReadLine().Split(' ');
int N = int.Parse(NM[0]), M = int.Parse(NM[1]);
int[,] distance = new int[N, M];
List<(int row, int col)> ends = new List<(int row, int col)>();
for (int i = 0; i < N; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < M; j++)
    {
        int number = int.Parse(row[j]);
        if (number == 0 || number == 2)
        {
            distance[i, j] = -1;
            if(number == 2) ends.Add((i, j));
        }
        else distance[i, j] = -2;
    }
}

(int row, int col)[] directions = { (0, 1), (0, -1), (1, 0), (-1, 0) };
Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
queue.Enqueue((0, 0));
distance[0, 0] = 0;
while (queue.Count != 0)
{
    (int row, int col) ball = queue.Dequeue();
    for(int i = 0; i < 4; i++)
    {
        (int row, int col) next = (ball.row + directions[i].row, ball.col + directions[i].col);
        if (next.row < 0 || next.row >= N || next.col < 0 || next.col >= M) continue;
        if (distance[next.row, next.col] != -1) continue;

        while(!(next.row < 0 || next.row >= N || next.col < 0 || next.col >= M))
        {
            if (distance[next.row, next.col] == -2) break;
            if (distance[next.row, next.col] == -1)
                distance[next.row, next.col] = distance[ball.row, ball.col] + 1;
            next = (next.row + directions[i].row, next.col + directions[i].col);
        }
        next = (next.row - directions[i].row, next.col - directions[i].col);
        queue.Enqueue(next);
    }
}

int min = int.MaxValue;
for(int i = 0; i < ends.Count; i++)
{
    (int row, int col) end = ends[i];
    if (min > distance[end.row, end.col]) min = distance[end.row, end.col];
}

Console.WriteLine(min);