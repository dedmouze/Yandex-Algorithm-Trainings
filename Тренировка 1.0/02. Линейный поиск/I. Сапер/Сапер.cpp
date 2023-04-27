#include <iostream>
#include <string>
#include <vector>
#include <array>

using namespace std;

int main()
{
    int N, K, M;
    cin >> N >> K >> M;

    vector<vector<string>> field(N + 2);
    for (int i = 0; i < N + 2; i++)
    {
        vector<string> row(K + 2);
        field[i] = row;
        for (int j = 0; j < K + 2; j++) field[i][j] = "0";
    }
        
    for (int i = 0; i < M; i++)
    {
        int x, y;
        cin >> x >> y;
        field[x][y] = "*";
    }

    int dRow[8] = {1, 1, 1, 0, 0, -1, -1, -1};
    int dCol[8] = {-1, 0, 1, -1, 1, -1, 0, 1};
    for (int i = 1; i < N + 1; i++)
    {
        for (int j = 1; j < K + 1; j++)
        {
            if (field[i][j] == "*")
            {
                cout << "* ";
                continue;
            }
            int minesCount = 0;
            for (int l = 0; l < 8; l++)
                if (field[i + dCol[l]][j + dRow[l]] == "*") minesCount++;
            cout << minesCount << " ";
        }
        cout << endl;
    }
}