#include <algorithm>
#include <iostream>
#include <vector>
#include <set>

typedef long long LL;

int main()
{
	int N, xi, yi;
	std::cin >> N;

	std::vector<std::pair<int, int>> points(N);
	for (int i = 0; i < N; ++i)
	{
		std::cin >> xi >> yi;
		points[i] = std::make_pair(xi, yi);
	}

	long long count = 0;
	for (int i = 0; i < N; ++i)
	{
		std::vector<long long> neighbours;
		std::set<std::pair<int, int>> used_vectors;
		for (int j = 0; j < N; ++j)
		{
			long vector_x = points[i].first - points[j].first;
			long vector_y = points[i].second - points[j].second;
			long long sqr_vector_length = LL(vector_x) * vector_x + vector_y * vector_y;
			neighbours.push_back(sqr_vector_length);

			if (used_vectors.count(std::make_pair(vector_x, vector_y))) --count;
			used_vectors.insert(std::make_pair(-vector_x, -vector_y));
		}

		std::sort(neighbours.begin(), neighbours.end());

		int right = 0;
		for (int left = 0; left < neighbours.size(); ++left)
		{
			while (right < neighbours.size() && neighbours[left] == neighbours[right]) ++right;
			count += right - left - 1;
		}
	}

	std::cout << count;
}
