using System;

string start = Console.ReadLine();
string end = Console.ReadLine();

int M = start.Length + 1, N = end.Length + 1;
int[,] dp = new int[M, N];
for (int i = 1; i < M; i++) dp[i, 0] = dp[i - 1, 0] + 1;
for (int i = 1; i < N; i++) dp[0, i] = dp[0, i - 1] + 1;

for(int i = 1; i < M; i++)
{
    for(int j = 1; j < N; j++)
    {
        if (start[i - 1] == end[j - 1]) dp[i, j] = dp[i - 1, j - 1];
        else dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1])) + 1;
    }
}

Console.WriteLine(dp[M - 1, N - 1]);