#include <iostream>
#include <vector>

using namespace std;

int main()
{
    short N;
    cin >> N;
    vector<short> numbers(N);
    for (int i = 0; i < N; i++)
    {
        short number;
        cin >> number;
        numbers[i] = number;
    }

    for (int i = 0; i < N; i++)
    {
        int j = i;
        int k = N - 1;
        while (i <= k && numbers[j] == numbers[k])
        {
            j++;
            k--;
        }
        if (j > k)
        {
            cout << i << endl;
            for (int l = i - 1; l >= 0; l--) cout << numbers[l] << " ";
            return 0;
        }
    }
}
