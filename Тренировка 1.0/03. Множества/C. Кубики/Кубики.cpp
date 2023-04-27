#include <algorithm>
#include <iostream>
#include <vector>
#include <set>

void print(const std::vector<int>& list)
{
	std::cout << list.size() << std::endl;
	for (const auto& elem : list) std::cout << elem << ' ';
	std::cout << std::endl;
}

int main()
{
	int N, M;
	std::cin >> N >> M;

	std::set<int> set1;
	std::set<int> set2;

	int number;
	for (int i = 0; i < N; i++)
	{
		std::cin >> number;
		set1.insert(number);
	}
	for (int i = 0; i < M; i++)
	{
		std::cin >> number;
		set2.insert(number);
	}

	std::vector<int> intersection;
	std::set_intersection(set1.begin(), set1.end(), set2.begin(), set2.end(), std::back_inserter(intersection));
	print(intersection);

	std::vector<int> notInAnn;
	std::set_difference(set1.begin(), set1.end(), set2.begin(), set2.end(), std::back_inserter(notInAnn));
	print(notInAnn);

	std::vector<int> notInBorya;
	std::set_difference(set2.begin(), set2.end(), set1.begin(), set1.end(), std::back_inserter(notInBorya));
	print(notInBorya);
}
