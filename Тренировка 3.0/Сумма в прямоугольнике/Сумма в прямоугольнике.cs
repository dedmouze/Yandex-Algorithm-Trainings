using System;
using System.Collections.Generic;

string[] NMK = Console.ReadLine().Split(' ');

int N = int.Parse(NMK[0]);
int M = int.Parse(NMK[1]);
int[][] matrix = new int[N][];
long[][] pref = new long[N][];
for(int i = 0; i < matrix.Length; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    matrix[i] = new int[M];
    pref[i] = new long[M];
    for(int j = 0; j < matrix[i].Length; j++) matrix[i][j] = int.Parse(row[j]);
}

pref[0][0] = matrix[0][0];
for (int i = 1; i < N; i++) pref[i][0] = pref[i - 1][0] + matrix[i][0];

for (int i = 1; i < M; i++) pref[0][i] = pref[0][i - 1] + matrix[0][i];

for (int i = 1; i < N; i++)
    for (int j = 1; j < M; j++)
        pref[i][j] = pref[i - 1][j] + pref[i][j - 1] - pref[i - 1][j - 1] + matrix[i][j];


int K = int.Parse(NMK[2]);
for(int i = 0; i < K; i++)
{
    string[] coordinates = Console.ReadLine().Split(' ');
    int x1 = int.Parse(coordinates[0]) - 1, y1 = int.Parse(coordinates[1]) - 1;
    int x2 = int.Parse(coordinates[2]) - 1, y2 = int.Parse(coordinates[3]) - 1;
    long result = pref[x2][y2] - (x1 != 0 ? pref[x1 - 1][y2] : 0) -
                                 (y1 != 0 ? pref[x2][y1 - 1] : 0) +
                                 (x1 != 0 && y1 != 0 ? pref[x1 - 1][y1 - 1] : 0);

    Console.WriteLine(result);
}