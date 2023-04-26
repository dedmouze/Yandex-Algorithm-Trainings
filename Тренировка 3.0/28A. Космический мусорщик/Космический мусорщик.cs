using System;
using System.Collections.Generic;

string N = Console.ReadLine();
string S = Console.ReadLine();
string W = Console.ReadLine();
string E = Console.ReadLine();
string U = Console.ReadLine();
string D = Console.ReadLine();

string[] NSWEUD = { N, S, W, E, U, D };
Dictionary<char, int> map = new Dictionary<char, int>
{
    { 'N', 0 },
    { 'S', 1 },
    { 'W', 2 },
    { 'E', 3 },
    { 'U', 4 },
    { 'D', 5 }
};
string[] find = Console.ReadLine().Split(' ');
int parameter = int.Parse(find[1]);

int[,] dp = new int[parameter, 6];
for (int i = 0; i < 6; i++) dp[0, i] = 1;

for(int i = 1; i < parameter; i++)
{
    for(int j = 0; j < 6; j++)
    {
        int sum = 0;
        for(int k = 0; k < NSWEUD[j].Length; k++) sum += dp[i - 1, map[NSWEUD[j][k]]];
        dp[i, j] = sum + 1;
    }
}

string direction = find[0];
Console.WriteLine(dp[parameter - 1, map[direction[0]]]);