#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int a, b, c;
    cin >> a >> b >> c;

    if (c < 0) cout << "NO SOLUTION";
    else if (a == 0)
    {
        if (b == c * c) cout << "MANY SOLUTIONS";
        else cout << "NO SOLUTION";
    }
    else
    {
        float x = float(c * c - b) / a;
        if (fmod(x, 1) == 0) cout << x;
        else cout << "NO SOLUTION";
    }
}