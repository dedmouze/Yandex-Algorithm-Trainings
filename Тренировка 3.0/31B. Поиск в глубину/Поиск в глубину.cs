using System;
using System.Collections.Generic;

string[] VE = Console.ReadLine().Split(' ');
int V = int.Parse(VE[0]), E = int.Parse(VE[1]);

List<int>[] vertices = new List<int>[V + 1];
for (int i = 0; i < V + 1; i++) vertices[i] = new List<int>();

for(int i = 0; i < E; i++)
{
    string[] relation = Console.ReadLine().Split(' ');
    int a = int.Parse(relation[0]), b = int.Parse(relation[1]);
    vertices[a].Add(b);
    vertices[b].Add(a);
}

bool[] visited = new bool[V + 1];
List<int> components = new List<int>();
DFS(1);

void DFS(int cur)
{
    visited[cur] = true;
    components.Add(cur);
    for (int i = 0; i < vertices[cur].Count; i++)
    {
        if (!visited[vertices[cur][i]]) DFS(vertices[cur][i]);
    }
}

components.Sort();
Console.WriteLine(components.Count);
for (int i = 0; i < components.Count; i++) Console.Write(components[i] + " ");