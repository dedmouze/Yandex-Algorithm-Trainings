#include <iostream>

int main()
{
	unsigned long long N, A, B, W, H;
	std::cin >> N >> A >> B >> W >> H;

	unsigned long long mid, temp, left = 0, right = std::max(W, H);
	while (left != right)
	{
		mid = (left + right + 1) / 2;
		temp = std::max((W / (A + 2 * mid)) * (H / (B + 2 * mid)), (W / (B + 2 * mid)) * (H / (A + 2 * mid)));
		if (temp >= N) left = mid;
		else right = mid - 1;
	}

	std::cout << left;
}

