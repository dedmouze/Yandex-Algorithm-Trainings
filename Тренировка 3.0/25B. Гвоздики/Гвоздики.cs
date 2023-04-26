using System;

int N = int.Parse(Console.ReadLine());
string[] sNails = Console.ReadLine().Split(' ');

int[] nails = new int[N];
for (int i = 0; i < N; i++) nails[i] = int.Parse(sNails[i]);

Array.Sort(nails);

int[] dp = new int[N + 1];
dp[0] = 0;
dp[1] = nails[1] - nails[0];
for (int i = 2; i <= N; i++)
    dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + Math.Abs(nails[i - 1] - nails[i - 2]);

Console.WriteLine(dp[N]); 