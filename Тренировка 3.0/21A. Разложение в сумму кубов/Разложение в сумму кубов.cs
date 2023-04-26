using System;

int N = int.Parse(Console.ReadLine());

int[] cubes = new int[100];
for (int i = 0; i < 100; i++) cubes[i] = (i + 1) * (i + 1) * (i + 1);

int[] dp = new int[N + 1];
for (int i = 0; i < N + 1; i++) dp[i] = int.MaxValue;

dp[0] = 0;
for(int i = 1; i <= N; i++)
{
    for(int j = 0; j < cubes.Length; j++)
    {
        if (cubes[j] > i) break;
        dp[i] = Math.Min(dp[i], dp[i - cubes[j]] + 1);
    }
}

Console.WriteLine(dp[N]);