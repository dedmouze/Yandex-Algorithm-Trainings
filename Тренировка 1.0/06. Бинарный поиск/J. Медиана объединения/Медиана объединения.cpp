#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
    int N, L;
    std::cin >> N >> L;

    std::vector<std::vector<int>> vectors(N, std::vector<int>(L));
    for (int i = 0; i < N; ++i)
        for (int j = 0; j < L; ++j) std::cin >> vectors[i][j];

    for (int i = 0; i < N; ++i)
    {
        for (int j = i + 1; j < N; ++j)
        {
            std::vector<int> vector;
            for (int k = 0; k < L; ++k)
            {
                vector.push_back(vectors[i][k]);
                vector.push_back(vectors[j][k]);
            }

            std::sort(vector.begin(), vector.end());

            std::cout << vector[L - 1] << std::endl;
        }
    }
}
