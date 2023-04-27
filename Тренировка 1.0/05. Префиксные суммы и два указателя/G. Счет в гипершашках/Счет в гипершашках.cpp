#include <unordered_map>
#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
	int N, K;
	std::cin >> N >> K;

	int point;
	std::vector<int> unique_points;
	std::unordered_map<int, int> points_count;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> point;
		if (!points_count.count(point)) unique_points.push_back(point);
		points_count[point]++;
	}

	std::sort(unique_points.begin(), unique_points.end());

	unsigned int duplicates = 0;
	unsigned long long count = 0;
	for (int left = 0, right = 0; left < unique_points.size(); ++left)
	{
		while (right < unique_points.size() &&  long(unique_points[left]) * K >= unique_points[right])
		{
			if (points_count[unique_points[right]] >= 2) ++duplicates;
			++right;
		}

		unsigned long long range_length = right - left;
		if (points_count[unique_points[left]] >= 2)
		{
			count += (range_length - 1) * 3;
			--duplicates;
		}
		if (points_count[unique_points[left]] >= 3) ++count;
		count += (range_length - 1) * (range_length - 2) * 3;
		count += long(duplicates) * 3;
	}

	std::cout << count;
}
