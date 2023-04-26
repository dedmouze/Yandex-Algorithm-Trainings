using System;

string[] NM = Console.ReadLine().Split(' ');
int N = int.Parse(NM[0]), M = int.Parse(NM[1]);

int[,] map = new int[N, M];
for(int i = 0; i < N; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < M; j++)
        map[i, j] = int.Parse(row[j]);
}

int[,] dp = new int[N + 1, M + 1];
for (int i = 0; i < N + 1; i++) dp[i, 0] = int.MaxValue;
for (int i = 0; i < M + 1; i++) dp[0, i] = int.MaxValue;

for (int i = 1; i < N + 1; i++)
{
    for (int j = 1; j < M + 1; j++)
    {
        if (dp[i - 1, j] == int.MaxValue && dp[i, j - 1] == int.MaxValue) dp[i, j] = map[i - 1, j - 1];
        else dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + map[i - 1, j - 1];
    }
}

Console.WriteLine(dp[N, M]);