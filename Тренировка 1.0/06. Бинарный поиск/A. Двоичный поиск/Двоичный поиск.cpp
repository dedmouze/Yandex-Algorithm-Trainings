#include <iostream>
#include <vector>

int main()
{
    int N, K;
    std::cin >> N >> K;

    std::vector<int> n_vector(N);
    for (int i = 0; i < N; ++i) std::cin >> n_vector[i];

    bool flag;
    int number, left, right, middle;
    for (int i = 0; i < K; ++i)
    {
        std::cin >> number;

        flag = false;
        left = 0, right = N - 1;
        while (left <= right)
        {
            middle = left + (right - left) / 2;
            if (n_vector[middle] == number)
            {
                flag = true;
                break;
            }
            else if (n_vector[middle] < number) left = middle + 1;
            else right = middle - 1;
        }

        std::cout << (flag ? "YES" : "NO") << std::endl;
    }
}
