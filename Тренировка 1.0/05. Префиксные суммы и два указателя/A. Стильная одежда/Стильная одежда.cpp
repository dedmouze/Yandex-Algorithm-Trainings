#include <iostream>
#include <vector>

int main()
{
    int N;
    std::cin >> N;
    std::vector<int> shirt(N);
    for (int i = 0; i < N; ++i) std::cin >> shirt[i];

    int M;
    std::cin >> M;
    std::vector<int> pants(M);
    for (int j = 0; j < M; ++j) std::cin >> pants[j];

    int min = 10000000;
    std::pair<int, int> answer;
    for (int i = 0, j = 0; i < N && j < M;)
    {
        int sh = shirt[i], pn = pants[j];
        int diff = std::abs(sh - pn);
        if (min > diff)
        {
            min = diff;
            answer = { sh, pn };
        }

        if (sh > pn) j++;
        else if (sh < pn) i++;
        else break;
    }

    std::cout << answer.first << " " << answer.second;
}