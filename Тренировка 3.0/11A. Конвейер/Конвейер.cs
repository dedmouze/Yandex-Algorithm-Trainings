using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
for(int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int K = int.Parse(input[0]);
    int answer = 1;
    for(int j = 1; j < K - 1; j++)
    {
        float number = float.Parse(input[j]);
        if(number < float.Parse(input[j + 1]) && number > float.Parse(input[j + 2]))
        {
            answer = 0;
            break;
        }
    }
    Console.WriteLine(answer);
}