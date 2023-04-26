using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
int[] enteringDegree = new int[N + 1];
List<int>[] vertices = new List<int>[N + 1];
for (int i = 1; i <= N; i++) vertices[i] = new List<int>();
for (int i = 1; i <= N; i++)
{
    string[] circles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int k = int.Parse(circles[0]);
    for(int j = 0; j < k; j++)
    {
        int currentCircle = int.Parse(circles[j + 1]);
        vertices[i].Add(currentCircle);
        enteringDegree[currentCircle]++;
    }
}

PriorityQueue<int, int> pQueue = new PriorityQueue<int, int>(new Comparer());
for (int i = 1; i <= N; i++)
    if (enteringDegree[i] == 0) pQueue.Enqueue(i, i);

List<int> postOrder = new List<int>();
while(pQueue.Count != 0)
{
    int max = pQueue.Dequeue();
    postOrder.Add(max);
    for(int i = 0; i < vertices[max].Count; i++)
    {
        int neighbour = vertices[max][i];
        enteringDegree[neighbour]--;
        if (enteringDegree[neighbour] == 0) pQueue.Enqueue(neighbour, neighbour);
    }
}

for (int i = postOrder.Count - 1; i >= 0; i--) Console.Write(postOrder[i] + " ");

class Comparer : IComparer<int>
{
    public int Compare(int a, int b) => b.CompareTo(a);
}