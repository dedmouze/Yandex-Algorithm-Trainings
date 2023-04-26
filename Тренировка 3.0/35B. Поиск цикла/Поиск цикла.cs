using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
List<int>[] vertices = new List<int>[N + 1];
for (int i = 0; i < N; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    vertices[i + 1] = new List<int>();
    for (int j = 0; j < N; j++)
    {
        if (int.Parse(row[j]) == 0) continue;
        vertices[i + 1].Add(j + 1);
    }
}

int[] colors = new int[N + 1];
List<int> loop = new List<int>();
int loopNumber = -1;
for (int i = 1; i < N + 1; i++)
    if (colors[i] == 0) DFS(i, -1);

if (loopNumber == -1)
{
    Console.WriteLine("NO");
    return;
}

Console.WriteLine("YES");
Console.WriteLine(loop.Count);
for (int i = 0; i < loop.Count; i++) Console.Write(loop[i] + " ");

void DFS(int cur, int prev)
{
    if (loopNumber == -2) return;
    colors[cur] = 1;
    for (int i = 0; i < vertices[cur].Count; i++)
    {
        if (loopNumber != -1) continue;
        if (colors[vertices[cur][i]] == 0) DFS(vertices[cur][i], cur);
        else if (colors[vertices[cur][i]] == 1)
        {
            if (vertices[cur][i] == prev) continue;
            loopNumber = vertices[cur][i];
            loop.Add(cur);
            return;
        }
        if (loopNumber == -2) return;
    }

    if (loopNumber != -1)
    {
        loop.Add(cur);
        if (cur == loopNumber)
        {
            loopNumber = -2;
            return;
        }
    }

    colors[cur] = 2;
}
