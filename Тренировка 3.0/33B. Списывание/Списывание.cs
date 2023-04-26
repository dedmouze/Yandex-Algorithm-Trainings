using System;
using System.Collections.Generic;

string[] VE = Console.ReadLine().Split(' ');
int V = int.Parse(VE[0]), E = int.Parse(VE[1]);

List<int>[] vertices = new List<int>[V + 1];
for (int i = 0; i < V + 1; i++) vertices[i] = new List<int>();
for (int i = 0; i < E; i++)
{
    string[] relations = Console.ReadLine().Split(' ');
    int a = int.Parse(relations[0]), b = int.Parse(relations[1]);
    vertices[a].Add(b);
    vertices[b].Add(a);
}

bool isBipartite = true;
bool[] visited = new bool[V + 1];
int[] colors = new int[V + 1];

for(int i = 1; i < V + 1; i++)
    if (!visited[i]) DFS(i, 1);

Console.WriteLine(isBipartite ? "YES" : "NO");

void DFS(int cur, int color)
{
    if (!isBipartite) return;

    visited[cur] = true;
    colors[cur] = color;
    for (int i = 0; i < vertices[cur].Count; i++)
    {
        if (colors[vertices[cur][i]] == color)
        {
            isBipartite = false;
            return;
        }
        if (!visited[vertices[cur][i]]) DFS(vertices[cur][i], 3 - color);
    }
}
