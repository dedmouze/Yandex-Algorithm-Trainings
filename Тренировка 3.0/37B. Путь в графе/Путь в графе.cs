using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
int[] distance = new int[N + 1];
List<int>[] verteces = new List<int>[N + 1];
for (int i = 1; i < N + 1; i++) verteces[i] = new List<int>();
for (int i = 1; i < N + 1; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 1; j < N + 1; j++)
    {
        if (int.Parse(row[j - 1]) == 1)
        {
            verteces[i].Add(j);
            verteces[j].Add(i);
        }
    }
    distance[i] = -1;
}

string[] se = Console.ReadLine().Split(' ');
int start = int.Parse(se[0]), end = int.Parse(se[1]);

int[] prev = new int[N + 1];
Queue<int> queue = new Queue<int>();
queue.Enqueue(start);
distance[start] = 0;
prev[start] = -1;
bool stop = false;
while (queue.Count != 0 && !stop)
{
    int number = queue.Dequeue();
    for (int i = 0; i < verteces[number].Count; i++)
    {
        int vertex = verteces[number][i];
        if (distance[vertex] != -1) continue;
        distance[vertex] = distance[number] + 1;
        prev[vertex] = number;
        if (vertex == end)
        {
            stop = true;
            break;
        }

        queue.Enqueue(vertex);
    }
}

List<int> path = new List<int>();
int k = end;
while (k != -1 && prev[k] != 0)
{
    path.Add(k);
    k = prev[k];
}

Console.WriteLine(distance[end]);
if(distance[end] != 0) for (int i = path.Count - 1; i >= 0; i--) Console.Write(path[i] + " ");