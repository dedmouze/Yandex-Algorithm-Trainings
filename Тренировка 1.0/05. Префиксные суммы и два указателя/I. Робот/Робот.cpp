#include <iostream>

int main()
{
    int K, N;
    std::string operations;
    std::cin >> K >> operations;
    N = operations.size();

    long count = 0;
    int prev_length = 0;
    for (int i = K; i < N; ++i)
    {
        if (operations[i] == operations[i - K])
        {
            ++prev_length;
            count += prev_length;
        }
        else prev_length = 0;
    }

    std::cout << count;
}
