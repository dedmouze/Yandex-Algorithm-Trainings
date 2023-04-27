#include <iostream>
#include <vector>

int RSQ(std::vector<int>& pref, int left, int right)
{
    return pref[right] - pref[left];
}

int main()
{
    int N, K;
    std::cin >> N >> K;

    std::vector<int> nums(N), pref(N + 1);
    for (int i = 0; i < N; ++i) std::cin >> nums[i];

    pref[0] = 0;
    for (int i = 1; i < N + 1; ++i) pref[i] = pref[i - 1] + nums[i - 1];

    int count = 0, start = 0, end = 1;
    while (start < N + 1 && end < N + 1)
    {
        int sum = RSQ(pref, start, end);
        if (sum > K) ++start;
        else if (sum < K) ++end;
        else
        {
            ++count;
            ++start;
            ++end;
        }
    }

    std::cout << count;
}
