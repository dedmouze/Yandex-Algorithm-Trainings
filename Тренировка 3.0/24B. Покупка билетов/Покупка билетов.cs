using System;

int N = int.Parse(Console.ReadLine());
int[] dp = new int[N + 3];
int[][] abcDP = new int[N + 3][];
dp[0] = dp[1] = dp[2] = 0;
abcDP[0] = abcDP[1] = abcDP[2] = new int[3] { int.MaxValue, int.MaxValue, int.MaxValue };
for(int i = 3; i < N + 3; i++)
{
    string[] ABC = Console.ReadLine().Split(' ');
    abcDP[i] = new int[3] { int.Parse(ABC[0]), int.Parse(ABC[1]), int.Parse(ABC[2]) };
}

for (int i = 3; i < N + 3; i++)
    dp[i] = Math.Min(dp[i - 1] + abcDP[i][0], Math.Min(dp[i - 2] + abcDP[i - 1][1], dp[i - 3] + abcDP[i - 2][2]));

Console.WriteLine(dp[N + 2]);