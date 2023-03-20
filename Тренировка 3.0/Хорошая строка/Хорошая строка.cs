using System;

int N = int.Parse(Console.ReadLine());
int[] arr = new int[N];
for (int i = 0; i < N; i++) arr[i] = int.Parse(Console.ReadLine());

long nice = 0;
for (int i = 0; i < N - 1; i++) nice += Math.Min(arr[i], arr[i + 1]);
Console.WriteLine(nice);