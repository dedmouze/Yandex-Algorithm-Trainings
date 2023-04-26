using System;
using System.Collections.Generic;

string[] NM = Console.ReadLine().Split(' ');
int N = int.Parse(NM[0]), M = int.Parse(NM[1]);
int[,] field = new int[N, M];
for(int i = 0; i < N; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < M; j++) field[i, j] = int.Parse(row[j]);
}

(int row, int col)[] directions = { (0, -1), (1, 0), (0, 1), (-1, 0) };
List<(int row, int col)>[,] vertices = new List<(int row, int col)>[N, M];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        vertices[i, j] = new List<(int row, int col)>();
        for (int k = 0; k < 4; k++)
        {
            (int row, int col) neighbour = (i + directions[k].row, j + directions[k].col);
            if (neighbour.row < 0 || neighbour.row >= N || neighbour.col < 0 || neighbour.col >= M) continue;

            if (field[i, j] > field[neighbour.row, neighbour.col] ||
                field[i, j] == field[neighbour.row, neighbour.col])
                vertices[i, j].Add((neighbour.row, neighbour.col));
        }
    }   
}

int count = 0;
bool[,] visited = new bool[N, M];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (vertices[i, j].Count == 0) count++;
        else
        {
            bool same = true;
            for (int k = 0; k < vertices[i, j].Count; k++)
            {
                if (field[i, j] != field[vertices[i, j][k].row, vertices[i, j][k].col])
                {
                    same = false;
                    break;
                }
            }

            if (same && !visited[i, j] && DFS(i, j, field[i, j])) count++;
        }
    }
}

Console.WriteLine(count);

bool DFS(int row, int col, int check)
{
    bool flag = true;
    visited[row, col] = true;
    for(int i = 0; i < vertices[row, col].Count; i++)
    {
        (int row, int col) neighbour = vertices[row, col][i];
        if (check != field[neighbour.row, neighbour.col]) return false;
        if (visited[neighbour.row, neighbour.col]) continue;

        if (!DFS(neighbour.row, neighbour.col, check)) flag = false;
    }
    return flag;
}
