using System;

string[] list = Console.ReadLine().Split(' ');

if (list.Length == 1) Console.WriteLine("YES");
else
{
    bool nonDecreasing = true;
    for(int i = 1; i < list.Length; i++)
    {
        if (int.Parse(list[i]) <= int.Parse(list[i - 1]))
        {
            nonDecreasing = false;
            break;
        }
    }
    Console.WriteLine(nonDecreasing ? "YES" : "NO");
}