using System;

string[] nab = Console.ReadLine().Split(' ');
int n = int.Parse(nab[0]), a = int.Parse(nab[1]), b = int.Parse(nab[2]);

int[] dp = new int[n + 1];
for(int i = 2; i <= n; i++)
{
    int min = int.MaxValue;
    for(int k = 1; k <= i - 1; k++)
    {
        int max = Math.Max(dp[k] + a, dp[i - k] + b);
        if (min > max) min = max;
    }
    dp[i] = min;
}

Console.WriteLine(dp[n]);//