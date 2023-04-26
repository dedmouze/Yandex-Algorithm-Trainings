using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());

int[] distance = new int[M];
List<HashSet<int>> lines = new List<HashSet<int>>();
for (int i = 0; i < M; i++)
{
    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    HashSet<int> line = new HashSet<int>();
    for (int j = 1, n = int.Parse(input[0]); j <= n; j++) line.Add(int.Parse(input[j]));
    lines.Add(line);
    distance[i] = -1;
}

List<int>[] verteces = new List<int>[M];
for (int i = 0; i < M; i++) verteces[i] = new List<int>();
for (int i = 0; i < M; i++)
{
    foreach (int station in lines[i])
    {
        for (int j = 0; j < lines.Count; j++)
        {
            if (j == i) continue;

            if (lines[j].Contains(station))
            {
                verteces[i].Add(j);
                verteces[j].Add(i);
            }
        }
    }
}

string[] AB = Console.ReadLine().Split(' ');
int A = int.Parse(AB[0]), B = int.Parse(AB[1]);
Queue<int> queue = new Queue<int>();
for (int i = 0; i < M; i++)
{
    if (lines[i].Contains(A))
    {
        queue.Enqueue(i);
        distance[i] = 0;
    }
}

while (queue.Count != 0)
{
    int line = queue.Dequeue();
    for (int i = 0, n = verteces[line].Count; i < n; i++)
    {
        var next = verteces[line][i];
        if (distance[next] != -1) continue;

        distance[next] = distance[line] + 1;
        queue.Enqueue(next);
    }
}

int min = int.MaxValue;
for(int i = 0; i < M; i++)
{
    if (lines[i].Contains(B))
    {
        if (min == -1 || min > distance[i]) min = distance[i];
    }
}

Console.WriteLine(min);