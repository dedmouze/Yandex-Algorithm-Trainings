using System;

short N = short.Parse(Console.ReadLine());
string[] numbers = Console.ReadLine().Split(' ');

for(int i = 0; i < N; i++)
{
    int j = i;
    int k = N - 1;
    while(i <= k && short.Parse(numbers[j]) == short.Parse(numbers[k]))
    {
        j++;
        k--;
    }
    if(j > k)
    {
        Console.WriteLine(i);
        for (int l = i - 1; l >= 0; l--) Console.Write(numbers[l] + " ");
        return;
    }
}