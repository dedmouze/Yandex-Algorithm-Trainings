#include <cmath>
#include <iostream>

using namespace std;

int main()
{
    int t1, t2;
    string s;
    
    cin >> t1 >> t2 >> s;
    
    if(s == "freeze") cout << min(t1, t2);
    else if(s == "heat") cout << max(t1, t2);
    else if(s == "auto") cout << t2;
    else cout << t1;
}