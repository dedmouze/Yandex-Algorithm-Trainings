using System;
using System.Collections.Generic;

int[,] distanceRed = new int[8, 8];
int[,] distanceGreen = new int[8, 8];
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        distanceRed[i, j] = -1;
        distanceGreen[i, j] = -1;
    }
}

string[] redGreen = Console.ReadLine().Split(' ');
(int row, int col) red = (redGreen[0][1] - '1', redGreen[0][0] - 'a');
(int row, int col) green = (redGreen[1][1] - '1', redGreen[1][0] - 'a');

Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
(int row, int col)[] directions = { (2, 1), (2, -1), (-2, 1), (-2, -1), (1, 2), (1, -2), (-1, 2), (-1, -2)};
distanceRed[red.row, red.col] = 0;
queue.Enqueue(red);
while(queue.Count != 0)
{
    (int row, int col) horse = queue.Dequeue();
    for(int i = 0; i < 8; i++)
    {
        (int row, int col) next = (horse.row + directions[i].row, horse.col + directions[i].col);
        if (next.row < 0 || next.row >= 8 || next.col < 0 || next.col >= 8) continue;
        if (distanceRed[next.row, next.col] != -1) continue;
        distanceRed[next.row, next.col] = distanceRed[horse.row, horse.col] + 1;
        queue.Enqueue(next);
    }
}

distanceGreen[green.row, green.col] = 0;
queue.Enqueue(green);
while (queue.Count != 0)
{
    (int row, int col) horse = queue.Dequeue();
    for (int i = 0; i < 8; i++)
    {
        (int row, int col) next = (horse.row + directions[i].row, horse.col + directions[i].col);
        if (next.row < 0 || next.row >= 8 || next.col < 0 || next.col >= 8) continue;
        if (distanceGreen[next.row, next.col] != -1) continue;
        distanceGreen[next.row, next.col] = distanceGreen[horse.row, horse.col] + 1;
        queue.Enqueue(next);
    }
}

int min = int.MaxValue;
for(int i = 0; i < 8; i++)
{
    for(int j = 0; j < 8; j++)
        if ((distanceGreen[i, j] != -1 || distanceRed[i, j] != -1) && distanceGreen[i, j] == distanceRed[i, j])
            if (min > distanceRed[i, j]) min = distanceRed[i, j];
}

Console.WriteLine(min == int.MaxValue ? -1 : min);