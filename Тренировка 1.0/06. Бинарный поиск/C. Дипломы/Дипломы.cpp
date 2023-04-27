#include <iostream>

int main()
{
    unsigned long W, H, N;
    std::cin >> W >> H >> N;

    unsigned long long middle, left = 0, right = N * std::max(W, H);
    while (left != right)
    {
        middle = (left + right) / 2;
        if ((middle / W) * (middle / H) < N) left = middle + 1;
        else right = middle;
    }

    std::cout << left;
}
