#include <iostream>
#include <vector>

using namespace std;

int main()
{
    vector<int> list;
    do
    {
        int number;
        cin >> number;
        list.push_back(number);
    } while (cin.get() != '\n');

    if (list.size() <= 2) cout << 0;
    else
    {
        int count = 0;
        for (int i = 1, n = list.size(); i < n - 1; i++)
            if (list[i] > list[i - 1] && list[i] > list[i + 1]) count++;
        
        cout << count;
    }
}
