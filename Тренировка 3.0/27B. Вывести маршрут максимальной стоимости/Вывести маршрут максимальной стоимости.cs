using System;
using System.Collections.Generic;

string[] NM = Console.ReadLine().Split(' ');
int N = int.Parse(NM[0]), M = int.Parse(NM[1]);

int[,] map = new int[N, M];
for(int i = 0; i < N; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for(int j = 0; j < M; j++)
        map[i, j] = int.Parse(row[j]);
}

int[,] dp = new int[N + 1, M + 1];
for(int i = 1; i < N + 1; i++)
    for(int j = 1; j < M + 1; j++)
        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + map[i - 1, j - 1];

List<char> path = new List<char>();
for(int i = N, j = M;;)
{
    if (i == 1 && j == 1) break;
    if (dp[i - 1, j] >= dp[i, j - 1])
    {
        path.Add('D');
        if(i != 1) i--;
    }
    else
    {
        path.Add('R');
        if(j != 1) j--;
    }
}
path.Reverse();

Console.WriteLine(dp[N, M]);
for (int i = 0; i < path.Count; i++) Console.Write(path[i] + " ");