#include <iostream>
#include <cmath>
#include <string>

using namespace std;

int main()
{
    int length1, length2, width1, width2;
    cin >> length1 >> width1 >> length2 >> width2;

    int combinations[4][2] =
    {
        {length1 + length2, max(width1, width2)},
        {length1 + width2, max(width1, length2)},
        {max(length1, length2), width1 + width2},
        {max(length1, width2), width1 + length2},
    };

    int min = 0;
    for (int i = 1; i < 4; i++)
        if (combinations[min][0] * combinations[min][1] > combinations[i][0] * combinations[i][1]) min = i;

    cout << to_string(combinations[min][0]) + " " + to_string(combinations[min][1]);
}