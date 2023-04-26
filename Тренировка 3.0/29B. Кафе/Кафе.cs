using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
int[] costs = new int[N];
for(int i = 0; i < N; i++) costs[i]= int.Parse(Console.ReadLine());
if(N < 2)
{
    if(N == 0)
    {
        Console.WriteLine(0);
        Console.WriteLine("0 0");
    }
    else if(N == 1)
    {
        Console.WriteLine(costs[0]);
        if (costs[0] > 100) Console.Write("1 ");
        else Console.Write("0 ");
        Console.WriteLine("0");
    }
    return;
}

int[,] dp = new int[N + 1, N + 2];
for (int i = 0; i < N + 2; i++) dp[0, i] = int.MaxValue - 100000;
for (int i = 0; i < N + 1; i++)
{
    dp[i, 0] = int.MaxValue - 100000;
    dp[i, N + 1] = int.MaxValue - 100000;
}
dp[0, 1] = 0;
for(int i = 1; i < N + 1; i++)
{
    for(int j = 1; j < N + 1; j++)
    {
        if (costs[i - 1] > 100) dp[i, j] = Math.Min(dp[i - 1, j + 1], dp[i - 1, j - 1] + costs[i - 1]);
        else dp[i, j] = Math.Min(dp[i - 1, j + 1], dp[i - 1, j] + costs[i - 1]);
    }   
}

int min = int.MaxValue;
int couponsLeft = -1;
for (int i = 1; i < N + 1; i++)
{
    if (min >= dp[N, i])
    {
        min = dp[N, i];
        couponsLeft = i - 1;
    }
}

List<int> couponDays = new List<int>();
int row = N, col = couponsLeft + 1;
while(row != 0 && col != 0)
{
    if (costs[row - 1] > 100)
    {
        if (dp[row - 1, col + 1] < dp[row - 1, col - 1] + costs[row - 1])
        {
            if (dp[row - 1, col + 1] == dp[row, col]) couponDays.Add(row);
            col++;
        }
        else col--;
    }
    else
    {
        if (dp[row - 1, col + 1] < dp[row - 1, col] + costs[row - 1])
        {
            if (dp[row - 1, col + 1] == dp[row, col]) couponDays.Add(row);
            col++;
        }
    }
    row--;
}

Console.WriteLine(min);
Console.WriteLine(couponsLeft + " " + couponDays.Count);
for (int i = couponDays.Count - 1; i >= 0; i--) Console.WriteLine(couponDays[i]);