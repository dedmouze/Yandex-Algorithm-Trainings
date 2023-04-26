using System;

string[] NK = Console.ReadLine().Split(' ');
int N = int.Parse(NK[0]), K = int.Parse(NK[1]);

int[] dp = new int[N];
dp[0] = 1;
for (int i = 1; i < N; i++)
    for(int j = i - 1; j >= 0 && j >= i - K; j--) dp[i] += dp[j];

Console.WriteLine(dp[N - 1]);