using System;
using System.Collections.Generic;

string[] LN = Console.ReadLine().Split(' ');
int L = int.Parse(LN[0]), N = int.Parse(LN[1]);

List<int> costs = new List<int>();
costs.Add(0);
string[] input = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++) costs.Add(int.Parse(input[i]));
costs.Add(L);

N += 2;
int[,] dp = new int[N, N];

for (int i = 2; i < N; i++)
{
    for(int j = i - 2; j >= 0; j--)
    {
        dp[j, i] = int.MaxValue;
        for(int k = j + 1; k < i; k++) dp[j, i] = Math.Min(dp[j, i], dp[j, k] + dp[k, i]);
        dp[j, i] += costs[i] - costs[j];
    }
}

Console.WriteLine(dp[0, N - 1]);