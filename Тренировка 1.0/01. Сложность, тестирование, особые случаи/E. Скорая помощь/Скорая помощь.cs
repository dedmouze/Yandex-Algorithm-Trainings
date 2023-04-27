using System;
using System.IO;
using System.Collections.Generic;

int k1, m, k2, p2, n2;

using (TextReader reader = File.OpenText("input.txt"))
{
    string text = reader.ReadLine();
    string[] bits = text.Split(' ');
    k1 = int.Parse(bits[0]);
    m = int.Parse(bits[1]);
    k2 = int.Parse(bits[2]);
    p2 = int.Parse(bits[3]);
    n2 = int.Parse(bits[4]);
}

if(m < n2)
{
    Console.WriteLine("-1 -1");
    return;
}

List<int> possible = new List<int>();
if (p2 == 1 && n2 == 1)
{
    if (k1 <= k2)
    {
        Console.WriteLine("1 1");
        return;
    }
    else for (int i = k2; i <= k1; i++) possible.Add(i);
}
else
{
    int minPerFloor = k2 / (m * (p2 - 1) + n2);
    int maxPerFloor = (k2 - 1) / (m * (p2 - 1) + n2 - 1);
    for (int i = minPerFloor; i <= maxPerFloor; i++)
        if (i != 0 && (m * (p2 - 1) + n2 - 1) * i + (k2 - 1) % i == k2 - 1) possible.Add(i);
}

string[] answer = new string[2] { "-1", "-1" };
for(int i = 0; i < possible.Count; i++)
{
    int floorIndex = ((k1 - 1 - (k1 - 1) % possible[i]) / possible[i]) + 1;
    int n1 = floorIndex % m;
    int p1 = ((floorIndex - n1) / m) + 1;
    if(n1 == 0)
    {
        n1 = m;
        p1 -= 1;
    }
    if (answer[0] == "-1" && answer[1] == "-1")
    {
        answer[0] = p1.ToString();
        answer[1] = n1.ToString();
    }
    else
    {
        if (p1.ToString() != answer[0]) answer[0] = "0";
        if (n1.ToString() != answer[1]) answer[1] = "0";
    }
}

Console.WriteLine(answer[0] + " " + answer[1]);