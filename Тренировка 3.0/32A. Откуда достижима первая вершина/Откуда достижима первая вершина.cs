using System;
using System.Collections.Generic;

string[] VE = Console.ReadLine().Split(' ');
int V = int.Parse(VE[0]), E = int.Parse(VE[1]);
List<int>[] vertices = new List<int>[V + 1];
for (int i = 1; i < V + 1; i++) vertices[i] = new List<int>();
for (int i = 0; i < E; i++)
{
    string[] relation = Console.ReadLine().Split(' ');
    vertices[int.Parse(relation[0])].Add(int.Parse(relation[1]));
}

List<int> answer = new List<int>();
answer.Add(1);
bool[] visited = new bool[V + 1];
for(int i = 2; i < V + 1; i++)
{
    DFS(i);
    if (visited[1]) answer.Add(i);
    for (int j = 0; j < V + 1; j++) visited[j] = false;
}

for (int i = 0; i < answer.Count; i++) Console.Write(answer[i] + " ");

void DFS(int cur)
{
    visited[cur] = true;
    for (int i = 0; i < vertices[cur].Count; i++)
        if (!visited[vertices[cur][i]]) DFS(vertices[cur][i]);
}