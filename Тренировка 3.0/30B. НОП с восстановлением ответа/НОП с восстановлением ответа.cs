using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
string[] sequence = Console.ReadLine().Split(' ');
int[] s1 = new int[N];
for (int i = 0; i < N; i++) s1[i] = int.Parse(sequence[i]);
int M = int.Parse(Console.ReadLine());
sequence = Console.ReadLine().Split(' ');
int[] s2 = new int[M];
for (int i = 0; i < M; i++) s2[i] = int.Parse(sequence[i]);

int[,] dp = new int[M + 1, N + 1];
for (int i = 1; i < M + 1; i++)
{
    for (int j = 1; j < N + 1; j++)
    {
        if (s1[j - 1] == s2[i - 1]) dp[i, j] = dp[i - 1, j - 1] + 1;
        else dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
    }
}

List<int> answer = new List<int>();
int row = M, col = N;
while (dp[row, col] != 0)
{
    if (dp[row, col] == dp[row - 1, col]) row--;
    else if (dp[row, col] == dp[row, col - 1]) col--;
    else if (dp[row, col] == dp[row - 1, col - 1] + 1)
    {
        answer.Add(s1[col - 1]);
        row--;
        col--;
    }
}

for (int i = answer.Count - 1; i >= 0; i--) Console.Write(answer[i] + " ");