using System;
using System.Numerics;

string[] NM = Console.ReadLine().Split(' ');
int N = int.Parse(NM[0]), M = int.Parse(NM[1]);

BigInteger[,] dp = new BigInteger[N + 3, M + 3];
dp[2, 2] = 1;
int i = 2, j = 2;
while(i != N + 1 || j != M + 1)
{
    int x = i, y = j;
    while(x >= 2 && y != M + 2)
    {
        dp[x, y] += dp[x - 2, y - 1] + dp[x - 2, y + 1] + dp[x - 1, y - 2] + dp[x + 1, y - 2];
        x--;
        y++;
    }
    if (i == N + 1) j++;
    else i++;
}
dp[N + 1, M + 1] += dp[N - 1, M] + dp[N - 1, M + 2] + dp[N, M - 1] + dp[N + 2, M - 1];
Console.WriteLine(dp[N + 1, M + 1]);