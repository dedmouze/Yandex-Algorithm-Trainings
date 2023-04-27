#include <iostream>

using namespace std;

int main()
{
    int n, k, m;
    cin >> n >> k >> m;
    if (k / m == 0)
    {
        cout << 0;
        return 0;
    }
    int details = 0;
    while (n >= k)
    {
        details += k / m;
        n += k % m - k;
    }

    cout << details;
}