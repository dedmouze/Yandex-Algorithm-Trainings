using System;

int n, k, m;
string[] numbers = Console.ReadLine().Split(" ");
n = int.Parse(numbers[0]);
k = int.Parse(numbers[1]);
m = int.Parse(numbers[2]);

int detailsPerBar = k / m;
if (detailsPerBar == 0)
{
    Console.WriteLine(0);
    return;
}
int details = 0;
int detailsWeightPerBar = detailsPerBar * m;
while(n >= k)
{
    int barsCount = n / k;
    n -= barsCount * detailsWeightPerBar;
    details += barsCount * detailsPerBar;
}

Console.WriteLine(details);