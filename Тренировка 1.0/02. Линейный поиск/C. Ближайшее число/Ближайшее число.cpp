#include <iostream>
#include <cmath>
#include <vector>

using namespace std;

int main()
{
    short N;
    vector<short> list;
    cin >> N;
    while (N > 0)
    {
        short number;
        cin >> number;
        list.push_back(number);
        N--;
    }

    short x, closest = list[0];
    cin >> x;
    for (int i = 1, n = list.size(); i < n; i++)
    {
        if (list[i] == x)
        {
            closest = list[i];
            break;
        }
        else if (abs(closest - x) > abs(list[i] - x)) closest = list[i];
    }

    cout << closest;
}