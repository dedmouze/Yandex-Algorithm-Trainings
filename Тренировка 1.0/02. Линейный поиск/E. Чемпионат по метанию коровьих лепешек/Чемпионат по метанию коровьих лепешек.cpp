#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int n;
    cin >> n;

    vector<short> results;
    int bestThrowIndex = 0;
    short bestThrow = -1;
    for (int i = 0; i < n; i++)
    {
        short number;
        cin >> number;
        results.push_back(number);

        if (number > bestThrow)
        {
            bestThrow = number;
            bestThrowIndex = i;
        }
    }

    short vasyaThrow = -1;
    for (int i = bestThrowIndex + 1; i < n - 1; i++)
    {
        short throwResult = results[i];
        if (throwResult % 10 == 5 && throwResult > results[i + 1] && vasyaThrow < throwResult) vasyaThrow = throwResult;
    }

    if (vasyaThrow == -1) cout << 0;
    else
    {
        int position = 1;
        for (int i = 0; i < n; i++)
            if (vasyaThrow < results[i]) position++;

        cout << position;
    }
}