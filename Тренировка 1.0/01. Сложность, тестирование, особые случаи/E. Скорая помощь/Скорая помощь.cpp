#include <iostream>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int k1, m, k2, p2, n2;

    cin >> k1 >> m >> k2 >> p2 >> n2;

    if (m < n2)
    {
        cout << "-1 -1";
        return 0;
    }

    vector<int> possible;
    if (p2 == 1 && n2 == 1)
    {
        if (k1 <= k2)
        {
            cout << "1 1";
            return 0;
        }
        else for (int i = k2; i <= k1; i++) possible.push_back(i);
    }
    else
    {
        int minPerFloor = k2 / (m * (p2 - 1) + n2);
        int maxPerFloor = (k2 - 1) / (m * (p2 - 1) + n2 - 1);
        for (int i = minPerFloor; i <= maxPerFloor; i++)
            if (i != 0 && (m * (p2 - 1) + n2 - 1) * i + (k2 - 1) % i == k2 - 1) possible.push_back(i);
    }

    string answer[2] = { "-1", "-1" };
    for (int i = 0; i < possible.size(); i++)
    {
        int floorIndex = ((k1 - 1 - (k1 - 1) % possible[i]) / possible[i]) + 1;
        int n1 = floorIndex % m;
        int p1 = ((floorIndex - n1) / m) + 1;
        if (n1 == 0)
        {
            n1 = m;
            p1 -= 1;
        }
        if (answer[0] == "-1" && answer[1] == "-1")
        {
            answer[0] = to_string(p1);
            answer[1] = to_string(n1);
        }
        else
        {
            if (to_string(p1) != answer[0]) answer[0] = "0";
            if (to_string(n1) != answer[1]) answer[1] = "0";
        }
    }

    cout << answer[0] + " " + answer[1];
}
