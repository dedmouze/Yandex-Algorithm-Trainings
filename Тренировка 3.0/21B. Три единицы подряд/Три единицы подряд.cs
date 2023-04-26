using System;

int N = int.Parse(Console.ReadLine());

if (N == 1) Console.WriteLine(2);
else if (N == 2) Console.WriteLine(4);
else if (N == 3) Console.WriteLine(7);
else
{
    int[] dp = new int[N];
    dp[0] = 2;
    dp[1] = 4;
    dp[2] = 7;
    for (int i = 3; i < N; i++)
        dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];

    Console.WriteLine(dp[N - 1]);
}
