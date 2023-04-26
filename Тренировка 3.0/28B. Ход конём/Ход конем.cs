using System;
using System.Collections.Generic;

string[] NM = Console.ReadLine().Split(' ');
int N = int.Parse(NM[0]), M = int.Parse(NM[1]);

int[,] dp = new int[N + 1, M + 1];
dp[1, 1] = 1;
for (int i = 2; i < N + 1; i++)
    for (int j = 2; j < M + 1; j++)
        dp[i, j] = dp[i - 1, j - 2] + dp[i - 2, j - 1];

Console.WriteLine(dp[N, M]);