#include <unordered_set>
#include <algorithm>
#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int number;
    unordered_set<int> set;
    do
    {
        cin >> number;
        set.insert(number);
    } while (cin.get() != '\n');

    vector<int> intersect;
    do
    {
        cin >> number;
        if (set.count(number)) intersect.push_back(number);
    } while (cin.get() != '\n');

    sort(intersect.begin(), intersect.end());
    for (int i = 0, number = intersect.size(); i < number; i++) cout << intersect[i] << ' ';
}
