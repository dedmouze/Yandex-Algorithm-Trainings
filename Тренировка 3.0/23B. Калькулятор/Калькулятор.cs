using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());

int[] dp = new int[N + 1];
for(int i = 2; i <= N; i++)
{
    if (i % 6 == 0) dp[i] = Math.Min(dp[i - 1], Math.Min(dp[i / 2], dp[i / 3])) + 1;
    else if (i % 3 == 0) dp[i] = Math.Min(dp[i - 1], dp[i / 3]) + 1;
    else if (i % 2 == 0) dp[i] = Math.Min(dp[i - 1], dp[i / 2]) + 1;
    else dp[i] = dp[i - 1] + 1;
}

Console.WriteLine(dp[N]);

int j = N;
List<int> recovery = new List<int>();
while (j > 1)
{
    recovery.Add(j);
    if (dp[j] == dp[j - 1] + 1) j--;
    else if (j % 2 == 0 && dp[j] == dp[j / 2] + 1) j /= 2;
    else j /= 3;
}
recovery.Add(1);

for (int i = recovery.Count - 1; i >= 0; i--) Console.Write(recovery[i] + " ");