using System;
using System.Collections.Generic;

string[] VE = Console.ReadLine().Split(' ');
int V = int.Parse(VE[0]), E = int.Parse(VE[1]);

List<int>[] vertices = new List<int>[V + 1];
for (int i = 0; i < V + 1; i++) vertices[i] = new List<int>();
for (int i = 0; i < E; i++)
{
    string[] relations = Console.ReadLine().Split(' ');
    vertices[int.Parse(relations[0])].Add(int.Parse(relations[1]));
}

bool loop = false;
int[] colors = new int[V + 1];
List<int> postOrder = new List<int>();
for (int i = 1; i < V + 1; i++)
    if (colors[i] == 0) DFS(i);

if(loop)
{
    Console.WriteLine(-1);
    return;
}

for (int i = postOrder.Count - 1; i >= 0; i--)
    Console.Write(postOrder[i] + " ");

void DFS(int cur)
{
    if (loop) return;

    colors[cur] = 1;
    for (int i = 0; i < vertices[cur].Count; i++)
    {
        if (colors[vertices[cur][i]] == 0) DFS(vertices[cur][i]);
        else if (colors[vertices[cur][i]] == 1)
        {
            loop = true;
            return;
        }
    }
    postOrder.Add(cur);
    colors[cur] = 2;
}
