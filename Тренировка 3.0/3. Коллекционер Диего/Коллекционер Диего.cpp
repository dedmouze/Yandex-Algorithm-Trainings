#include <iostream>
#include <vector>
#include <algorithm>

int main()
{
    int N;
    std::cin >> N;

    std::vector<int> v(N);
    for (int i = 0; i < N; ++i) std::cin >> v[i];
    std::sort(v.begin(), v.end());
    v.erase(std::unique(v.begin(), v.end()), v.end());

    int K;
    int number;
    std::cin >> K;
    for (int i = 0; i < K; ++i)
    {
        std::cin >> number;
        std::cout << std::distance(v.begin(), std::lower_bound(v.begin(), v.end(), number)) << std::endl;
    }
}