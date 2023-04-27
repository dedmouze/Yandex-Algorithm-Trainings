#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int N;
    double left = 30, right = 4000, prev, cur;
    string nearness;
    cin >> N >> prev;
    for (int i = 1; i < N; i++)
    {
        cin >> cur >> nearness;
        double m = (cur + prev) / 2;
        if (abs(cur - prev) < powf(10, -6)) continue;
        if (nearness == "closer")
        {
            if (cur > prev) left = max(left, m);
            else if(cur < prev) right = min(right, m);
        }
        else
        {
            if (cur < prev) left = max(left, m);
            else if(cur > prev) right = min(right, m);
        }

        prev = cur;
    }

    cout.precision(6);
    cout << fixed << left << ' ' << right;
}

/*

8
492.41504
190.62434 further
404.14365 closer
314.0718 further
104.702286 closer
145.69502 closer
27.49654 further
175.78748 closer

*/