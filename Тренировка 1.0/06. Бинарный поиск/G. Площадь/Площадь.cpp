#include <iostream>

int main()
{
	long long N, M, T;
	std::cin >> N >> M >> T;

	long long middle, temp, left = 0, right = std::min(N, M) / 2 + 1, inner_area;
	while (left < right)
	{
		middle = (left + right + 1) / 2;
		if (N - 2 * middle >= 0 && M - 2 * middle >= 0)
		{
			inner_area = (N - 2 * middle) * (M - 2 * middle);
			temp = N * M - inner_area;
			if (temp <= T) left = middle;
			else right = middle - 1;
		}
		else right = middle - 1;
	}

	std::cout << left;
}
