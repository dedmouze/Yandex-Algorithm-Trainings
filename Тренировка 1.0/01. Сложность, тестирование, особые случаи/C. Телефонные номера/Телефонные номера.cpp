#include <iostream>

using namespace std;

int main()
{
    string numbers[4];
    for (int i = 0; i < 4; i++)
    {
        cin >> numbers[i];
        string trimmedNumber = "";
        for (int j = 0; j < numbers[i].size(); j++)
            if (numbers[i][j] != '-' && numbers[i][j] != '+' && numbers[i][j] != '(' && numbers[i][j] != ')')
                trimmedNumber += numbers[i][j];
        numbers[i] = trimmedNumber;
        if (numbers[i].size() == 7) numbers[i] = "0495" + numbers[i];
    }

    for (int i = 1; i < 4; i++)
    {
        bool same = true;
        for (int j = 1; j < numbers[i].size(); j++)
        {
            if (numbers[0][j] != numbers[i][j])
            {
                same = false;
                break;
            }
        }
        cout << (same ? "YES" : "NO") << endl;
    }
}
