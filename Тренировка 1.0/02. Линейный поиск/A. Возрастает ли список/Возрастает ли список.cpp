#include <iostream>

using namespace std;

int main()
{
    char oneElement;
    int curNumber;
    cin >> curNumber;
    cin.get(oneElement);
 
    bool nonDecreasing = true;
    if (oneElement != '\n')
    {
        do
        {
            int newNumber;
            cin >> newNumber;
            if (newNumber <= curNumber)
            {
                nonDecreasing = false;
                break;
            }
            curNumber = newNumber;
        } while (cin.get() != '\n');
    }
    cout << (nonDecreasing ? "YES" : "NO");
}