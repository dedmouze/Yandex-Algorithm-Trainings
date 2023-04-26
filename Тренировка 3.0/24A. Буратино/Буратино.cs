using System;

int N = int.Parse(Console.ReadLine());
int[] broadcasts = new int[32400];
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string[] time = input[0].Split(":");
    int seconds = int.Parse(time[0]) * 60 * 60 + int.Parse(time[1]) * 60 + int.Parse(time[2]);
    for (int j = seconds - 32400, n = int.Parse(input[1]); j < 32400; j++)
        broadcasts[j] = n;
}

int[] dp = new int[64800];
for (int i = 0; i < 14400; i++)
{
    dp[i + 1] = Math.Max(dp[i], dp[i + 1]);
    if (i + broadcasts[i] > 18000) continue;
    dp[i + broadcasts[i]] = Math.Max(dp[i + broadcasts[i]], dp[i] + 1);
}

dp[18000] = dp[14400];
for (int i = 18000; i < 32400; i++)
{
    dp[i + 1] = Math.Max(dp[i], dp[i + 1]);
    dp[i + broadcasts[i]] = Math.Max(dp[i + broadcasts[i]], dp[i] + 1);
}

Console.WriteLine(dp[32400]);
