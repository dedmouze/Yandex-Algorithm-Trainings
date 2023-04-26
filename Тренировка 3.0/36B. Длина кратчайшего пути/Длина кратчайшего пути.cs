using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
int[] distance = new int[N + 1];
List<int>[] verteces = new List<int>[N + 1];
for (int i = 1; i < N + 1; i++) verteces[i] = new List<int>();
for(int i = 1; i < N + 1; i++)
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

Queue<int> queue = new Queue<int>();
queue.Enqueue(start);
distance[start] = 0;
while(queue.Count != 0)
{
    int number = queue.Dequeue();
    for(int i = 0; i < verteces[number].Count; i++)
    {
        if (distance[verteces[number][i]] != -1) continue;
        queue.Enqueue(verteces[number][i]);
        distance[verteces[number][i]] = distance[number] + 1;
    }
}

Console.WriteLine(distance[end]);