using System;
using System.Linq;
using System.Collections.Generic;

string[] NK = Console.ReadLine().Split(' ');
int N = int.Parse(NK[0]), K = int.Parse(NK[1]);
List<int>[] verteces = new List<int>[N];
(int start, int end)[] ends = new (int start, int end)[K];
for (int i = 0; i < N; i++) verteces[i] = new List<int>();
for (int i = 0; i < K; i++)
{
    string[] connection = Console.ReadLine().Split(' ');
    int a = int.Parse(connection[0]) - 1, b = int.Parse(connection[1]) - 1;
    ends[i] = (a, b);
    verteces[a].Add(b);
    verteces[b].Add(a);
}

const int max = int.MaxValue - 100000;
(int odd, int even)[,] distances = new (int odd, int even)[N, N];
for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
        distances[i, j] = (max, max);

int M = int.Parse(Console.ReadLine());
string[] starts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
List<int> startPositions = new List<int>(starts.Distinct().Select(x => int.Parse(x) - 1));
M = startPositions.Count;
for (int i = 0; i < M; i++)
{
    int startPosition = startPositions[i];
    Queue<int> queue = new Queue<int>();
    bool[] visited = new bool[N];
    queue.Enqueue(startPosition);
    visited[startPosition] = true;
    distances[i, startPosition].even = 0;
    while(queue.Count != 0)
    {
        int cur = queue.Dequeue();
        visited[cur] = false;
        for(int j = 0; j < verteces[cur].Count; j++)
        {
            int neighbour = verteces[cur][j];
            (int odd, int even) curDistance = distances[i, cur];
            (int odd, int even) neighbourDistance = distances[i, neighbour];
            if (neighbourDistance.odd > curDistance.even + 2)
            {
                distances[i, neighbour].odd = curDistance.even + 2;
                if (!visited[neighbour])
                {
                    visited[neighbour] = true;
                    queue.Enqueue(neighbour);
                }
            }
            if (neighbourDistance.even > curDistance.odd + 2)
            {
                distances[i, verteces[cur][j]].even = curDistance.odd + 2;
                if (!visited[neighbour])
                {
                    visited[neighbour] = true;
                    queue.Enqueue(neighbour);
                }
            }
        }
    }
}

float min = max;
for(int i = 0; i < N; i++)
{
    int maxOdd = 0, maxEven = 0;
    for(int j = 0; j < M; j++)
    {
        maxOdd = Math.Max(maxOdd, distances[j, i].odd);
        maxEven = Math.Max(maxEven, distances[j, i].even);
    }
    min = Math.Min(min, Math.Min(maxOdd, maxEven));
}

for (int i = 0; i < K; i++)
{
    int distance = 0;
    for (int j = 0; j < M; j++)
    {
        distance = Math.Max(distance, Math.Min(
            Math.Min(distances[j, ends[i].start].odd, distances[j, ends[i].start].even),
            Math.Min(distances[j, ends[i].end].odd, distances[j, ends[i].end].even)) + 1);
    }
    min = Math.Min(min, distance);
}

Console.WriteLine(min == max ? -1 : min / 2);