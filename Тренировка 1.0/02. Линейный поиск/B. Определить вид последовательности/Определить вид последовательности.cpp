#include <iostream>

using namespace std;

int main()
{
    int curNumber, nextNumber;
    cin >> curNumber;
    cin >> nextNumber;
    bool constant, ascending, descending, weaklyAscending, weaklyDescending;
    constant = ascending = descending = weaklyAscending = weaklyDescending = true;
    while (nextNumber != -2000000000)
    {
        if (constant && nextNumber != curNumber) constant = false;
        if (ascending && nextNumber <= curNumber) ascending = false;
        if (descending && nextNumber >= curNumber) descending = false;
        if (weaklyAscending && nextNumber < curNumber) weaklyAscending = false;
        if (weaklyDescending && nextNumber > curNumber) weaklyDescending = false;

        curNumber = nextNumber;
        cin >> nextNumber;
    }

    if (constant) cout << "CONSTANT";
    else if (ascending) cout << "ASCENDING";
    else if (descending) cout << "DESCENDING";
    else if (weaklyAscending) cout << "WEAKLY ASCENDING";
    else if (weaklyDescending) cout << "WEAKLY DESCENDING";
    else cout << "RANDOM";
}
