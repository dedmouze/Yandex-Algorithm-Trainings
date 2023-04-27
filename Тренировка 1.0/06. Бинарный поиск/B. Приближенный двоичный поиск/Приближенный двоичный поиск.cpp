#include <iostream>
#include <vector>

int main()
{
	int N, K;
	std::cin >> N >> K;

	std::vector<int> n_vector(N);
	for (int i = 0; i < N; ++i) std::cin >> n_vector[i];

	std::pair<int, int> pair;
	int number, left, right, middle;
	for (int i = 0; i < K; ++i)
	{
		std::cin >> number;

		left = 0, right = N - 1;
		while (left < right)
		{
			middle = (left + right) / 2;
			if (n_vector[middle] > number) right = middle;
			else left = middle + 1;
		}

		if (left == 0) std::cout << n_vector[left] << std::endl;
		else std::cout << (std::abs(n_vector[left] - number) >= std::abs(n_vector[left - 1] - number)
							? n_vector[left - 1] : n_vector[left]) << std::endl;
	}
}
