#include <iostream>
#include <cmath>

int main()
{
    int ai, bi, an, bn;
    std::cin >> ai >> bi >> an >> bn;

    int minATime = an + (an - 1) * ai;
    int maxATime = an + (an + 1) * ai;
    int minBTime = bn + (bn - 1) * bi;
    int maxBTime = bn + (bn + 1) * bi;

    int min = std::max(minATime, minBTime);
    int max = std::min(maxATime, maxBTime);

    if (min > max) std::cout << "-1";
    else std::cout << min << " " << max;
}
