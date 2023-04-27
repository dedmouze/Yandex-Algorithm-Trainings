#include <unordered_map>
#include <unordered_set>
#include <iostream>

int to_lower(std::string& word)
{
	int count = 0;
	for (char& c : word)
	{
		if (std::isupper(c))
		{
			c = std::tolower(c);
			count++;
		}
	}
	return count;
};

int main()
{
	unsigned N;
	std::string word, wordWithoutEmphasis;
	std::cin >> N;
	std::unordered_map<std::string, std::unordered_set<std::string>> dictionary;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> word;
		wordWithoutEmphasis = word;
		to_lower(wordWithoutEmphasis);
		dictionary[wordWithoutEmphasis].emplace(word);
	}

	unsigned count = 0;
	while (std::cin >> word)
	{
		wordWithoutEmphasis = word;
		int emphasisCount = to_lower(wordWithoutEmphasis);

		if (emphasisCount == 0) count++;
		else if (dictionary.count(wordWithoutEmphasis))
		{
			if (!dictionary[wordWithoutEmphasis].count(word)) count++;
		}
		else if (emphasisCount > 1) count++;
	}

	std::cout << count << std::endl;
}
