#include <iostream>
#include <vector>

bool match(const std::vector<int>& first, const std::vector<int>& second)
{
	for (int i = 0; i < 58; ++i)
		if (first[i] != second[i]) return false;
	return true;
};

int main()
{
	int G, S;
	std::string word1, word2;
	std::cin >> G >> S >> word1 >> word2;
	std::vector<int> map1(58, 0), map2(58, 0);
	for (const auto c : word1) map1[c - 'A']++;
	for (int i = 0; i < word1.size(); ++i) map2[word2[i] - 'A']++;

	int count = 0;
	for (int i = 0; i < word2.size() - word1.size(); ++i)
	{
		if (match(map1, map2)) count++;
		map2[word2[i + word1.size()] - 'A']++;
		map2[word2[i] - 'A']--;
	}
	if (match(map1, map2)) count++;
	std::cout << count;
}
