using System;

string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

int number1 = int.Parse(numbers[0]), number2 = int.Parse(numbers[1]);
int max1 = Math.Max(number1, number2), max2 = Math.Min(number1, number2);
int min1 = max2, min2 = max1;

for (int i = 2; i < numbers.Length; i++)
{
    int number = int.Parse(numbers[i]);
    if (number >= 0)
    {
        if (number > max1) (max1, max2) = (number, max1);
        else if (number > max2) max2 = number;
    }
    else
    {
        if (number < min1) (min1, min2) = (number, min1);
        else if (number < min2) min2 = number;
    }
}

Console.WriteLine((long)max1 * max2 > (long)min1 * min2 ? $"{max2} {max1}" : $"{min1} {min2}");