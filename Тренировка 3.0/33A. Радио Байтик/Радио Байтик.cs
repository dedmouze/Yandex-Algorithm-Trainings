using System;
using System.Linq;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
Point[] verteces = new Point[N];
for(int i = 0; i < N; i++)
{
    string[] coordinates = Console.ReadLine().Split(' ');
    verteces[i].x = int.Parse(coordinates[0]);
    verteces[i].y = int.Parse(coordinates[1]);
}

List<int> answer = new List<int>();
int left = 0, right = 20000 * 20000 * 2 + 1;
while(left + 1 < right)
{
    int mid = (left + right) / 2;
    int[] visited = new int[N];
    bool flag = true;
    for (int i = 0; i < N; i++)
    {
        if (visited[i] == 0)
        {
            DFS(i, 1);
            if (!flag) break;
        }
    }
    if (flag)
    {
        left = mid;
        answer = visited.ToList();
    }
    else right = mid;

    void DFS(int cur, int color)
    {
        if (!flag) return;
        visited[cur] = color;
        for (int i = 0; i < N; i++)
        {
            if (cur != i && SqrDist(verteces[cur], verteces[i]) < mid)
            {
                if (visited[i] == 0) DFS(i, 3 - color);
                else if (visited[cur] == visited[i])
                {
                    flag = false;
                    return;
                }
            }
        }
    }
}

Console.WriteLine(Math.Sqrt(left) / 2);
for (int i = 0; i < answer.Count; i++) Console.Write(answer[i] + " ");

int SqrDist(Point a, Point b) => (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y);

struct Point
{
    public int x;
    public int y;
};