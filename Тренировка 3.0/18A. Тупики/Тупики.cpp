#include <vector>
#include <iostream>

int main()
{
    int K, N;
    std::cin >> K >> N;
    std::vector<int> result;
    std::vector<std::pair<bool, int>> vector;
    for (int i = 0; i < K; ++i) vector.push_back(std::make_pair(false, 0));

    int number1, number2;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> number1 >> number2;
        for (int j = 0; j < K; ++j)
        {
            if (!vector[j].first)
            {
                vector[j].first = true;
                vector[j].second = number2;
                result.push_back(j + 1);
                break;
            }
            else if (vector[j].second < number1)
            {
                vector[j].second = number2;
                result.push_back(j + 1);
                break;
            }
            else if(j == K - 1)
            {
                std::cout << 0 << " " << i + 1 << std::endl;
                return 0;
            }
        }
    }

    for (int i = 0; i < result.size(); ++i) std::cout << result[i] << std::endl;
}