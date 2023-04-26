using System;

string[] MN = Console.ReadLine().Split(' ');
int M = int.Parse(MN[0]), N = int.Parse(MN[1]);

long[,] dp = new long[M, N];
for (int i = 0; i < M; i++) dp[i, 0] = 1;
for (int i = 0; i < N; i++) dp[0, i] = 1;

for(int i = 1; i < M; i++)
    for(int j = 1; j < N; j++)
        dp[i, j] = dp[i - 1, j] + dp[i, j - 1] + dp[i - 1, j - 1];

Console.WriteLine(dp[M - 1, N - 1]);