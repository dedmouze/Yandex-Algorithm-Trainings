#include <iostream>

using namespace std;

int main()
{
    int A, B, C, D, E;
    cin >> A >> B >> C >> D >> E;

    if (A > B)
    {
        A = A ^ B;
        B = B ^ A;
        A = A ^ B;
    }
    if (B > C)
    {
        B = B ^ C;
        C = C ^ B;
        B = B ^ C;
    }
    if (A > B)
    {
        A = A ^ B;
        B = B ^ A;
        A = A ^ B;
    }
    if (D > E)
    {
        E = E ^ D;
        D = D ^ E;
        E = E ^ D;
    }

    if (A <= D && B <= E) cout << "YES";
    else cout << "NO";
}