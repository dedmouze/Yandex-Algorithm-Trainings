using System;
using System.Collections.Generic;

string[] VE = Console.ReadLine().Split(' ');
int V = int.Parse(VE[0]), E = int.Parse(VE[1]);

List<int>[] vertices = new List<int>[V + 1];
for (int i = 0; i < V + 1; i++) vertices[i] = new List<int>();
for(int i = 0; i < E; i++)
{
    string[] relations = Console.ReadLine().Split(' ');
    int a = int.Parse(relations[0]), b = int.Parse(relations[1]);
    vertices[a].Add(b);
    vertices[b].Add(a);
}

int component = 0;
bool[] visited = new bool[V + 1];
List<List<int>> components = new List<List<int>>();
for(int i = 1; i < V + 1; i++)
{
    if (!visited[i])
    {
        components.Add(new List<int>());
        DFS(i, component);
        component++;
    }
}

Console.WriteLine(components.Count);
for (int i = 0; i < components.Count; i++)
{
    Console.WriteLine(components[i].Count);
    for (int j = 0; j < components[i].Count; j++) Console.Write(components[i][j] + " ");
    Console.WriteLine();
}

void DFS(int cur, int component)
{
    visited[cur] = true;
    components[component].Add(cur);
    for(int i = 0; i < vertices[cur].Count; i++)
        if (!visited[vertices[cur][i]]) DFS(vertices[cur][i], component);
}
