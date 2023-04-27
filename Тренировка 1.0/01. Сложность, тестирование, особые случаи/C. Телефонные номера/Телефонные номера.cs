using System;

string[] numbers = new string[4];
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Console.ReadLine();
    string trimmedNumber = "";
    for (int j = 0; j < numbers[i].Length; j++)
        if (numbers[i][j] != '-' && numbers[i][j] != '+' && numbers[i][j] != '(' && numbers[i][j] != ')')
            trimmedNumber += numbers[i][j];
    numbers[i] = trimmedNumber;
    if (numbers[i].Length == 7) numbers[i] = "0495" + numbers[i];
}

for(int i = 1; i < numbers.Length; i++)
{
    bool same = true;
    for(int j = 1; j < numbers[i].Length; j++)
    {
        if (numbers[0][j] != numbers[i][j])
        {
            same = false;
            break;
        }
    }
    Console.WriteLine(same ? "YES" : "NO");
}