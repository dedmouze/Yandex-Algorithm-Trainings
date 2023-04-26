using System;
using System.Collections.Generic;

string start = Console.ReadLine();
string end = Console.ReadLine();

Dictionary<string, int> distance = new Dictionary<string, int>();
Dictionary<string, string> prev = new Dictionary<string, string>();
Queue<string> queue = new Queue<string>();
queue.Enqueue(start);
distance.Add(start, 0);
prev.Add(start, "-1");
while (queue.Count != 0)
{
    string number = queue.Dequeue();
    if (number == end) break;

    string next = IncreaseNumber(number);
    if (!distance.ContainsKey(next))
    {
        distance.Add(next, distance[number] + 1);
        prev.Add(next, number);
        queue.Enqueue(next);
    }

    next = DecreaseNumber(number);
    if (!distance.ContainsKey(next))
    {
        distance.Add(next, distance[number] + 1);
        prev.Add(next, number);
        queue.Enqueue(next);
    }

    next = MoveLeft(number);
    if (!distance.ContainsKey(next))
    {
        distance.Add(next, distance[number] + 1);
        prev.Add(next, number);
        queue.Enqueue(next);
    }

    next = MoveRight(number);
    if (!distance.ContainsKey(next))
    {
        distance.Add(next, distance[number] + 1);
        prev.Add(next, number);
        queue.Enqueue(next);
    }
}

List<string> result = new List<string>();
while(end != "-1")
{
    result.Add(end);
    end = prev[end];
}

for (int i = result.Count - 1; i >= 0; i--) Console.WriteLine(result[i]);


string IncreaseNumber(string number)
{
    if (number[0] != '9')
        return new string(new char[4] { (char)(number[0] + 1), number[1], number[2], number[3] });
    return number;
}

string DecreaseNumber(string number)
{
    if (number[3] != '1')
        return new string(new char[4] { number[0], number[1], number[2], (char)(number[3] - 1) });
    return number;
}

string MoveLeft(string number) => new string(new char[4] { number[3], number[0], number[1], number[2] });
string MoveRight(string number) => new string(new char[4] { number[1], number[2], number[3], number[0] });
