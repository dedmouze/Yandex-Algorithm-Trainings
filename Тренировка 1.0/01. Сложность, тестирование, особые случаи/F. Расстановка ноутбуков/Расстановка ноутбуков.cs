using System;
using System.IO;

int length1, length2, width1, width2;
using (TextReader reader = File.OpenText("input.txt"))
{
    string line = reader.ReadLine();
    string[] bits = line.Split(" ");
    length1 = int.Parse(bits[0]);
    width1 = int.Parse(bits[1]);
    length2 = int.Parse(bits[2]);
    width2 = int.Parse(bits[3]);
}

(int, int)[] areas = new (int, int)[4]
{
    (length1 + length2, Math.Max(width1, width2)),
    (length1 + width2, Math.Max(width1, length2)),
    (Math.Max(length1, length2), width1 + width2),
    (Math.Max(length1, width2), width1 + length2)
};

int min = 0;
for (int i = 1; i < 4; i++)
    if (areas[min].Item1 * areas[min].Item2 > areas[i].Item1 * areas[i].Item2) min = i;

Console.WriteLine(areas[min].Item1 + " " + areas[min].Item2);