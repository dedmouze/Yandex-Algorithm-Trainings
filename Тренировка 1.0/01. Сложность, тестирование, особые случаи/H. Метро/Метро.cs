using System;

int ai = int.Parse(Console.ReadLine());
int bi = int.Parse(Console.ReadLine());
int an = int.Parse(Console.ReadLine());
int bn = int.Parse(Console.ReadLine());

int minATime = an + (an - 1) * ai;
int maxATime = an + (an + 1) * ai;
int minBTime = bn + (bn - 1) * bi;
int maxBTime = bn + (bn + 1) * bi;

int min = Math.Max(minATime, minBTime);
int max = Math.Min(maxATime, maxBTime);

if(min > max) Console.WriteLine("-1");
else Console.WriteLine(min + " " + max);
