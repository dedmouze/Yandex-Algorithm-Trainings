#include <string>
#include <climits>
#include <sstream>
#include <iostream>
#include <unordered_map>
#include <unordered_set>

void to_lower(std::string& word)
{
	for (char& c : word) c = std::tolower(c);
}

void delete_unnecessary(std::string& line)
{
	for (int i = 0; i < line.size(); ++i)
	{
		char c = line[i];
		if (c != '_' && !std::isalpha(c) && !std::isdigit(c)) line.replace(i, 1, " ");
	}
}

bool is_correct_identifier(const std::string& word, const bool can_first_digit)
{
	if (!can_first_digit && std::isdigit(word[0])) return false;
	for (const char& c : word)
		if (!std::isdigit(c)) return true;
	return false;
}


int main()
{
	int N;
	std::string C, D, line, identifier, lower_identifier;
	std::cin >> N >> C >> D;

	std::unordered_set<std::string> set;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> line;
		if (C == "no") to_lower(line);
		set.emplace(line);
	}

	unsigned number = 0;
	std::unordered_map<std::string, std::pair<unsigned, unsigned>> map;
	while (std::getline(std::cin, line))
	{
		delete_unnecessary(line);
		std::stringstream ss(line);
		while (ss >> identifier)
		{
			if (C == "no") to_lower(identifier);

			if (!set.count(identifier) && is_correct_identifier(identifier, D == "yes"))
			{
				
				if (map.count(identifier)) ++map[identifier].first;
				else
				{
					map[identifier].second = number;
					++map[identifier].first;
					++number;
				}
			}
		}
	}

	std::string max_identifier;
	unsigned max_count = 0, min_position = INT_MAX;
	for (const auto& [identifier, count_position] : map)
	{
		const auto [count, position] = count_position;
		if (max_count < count || max_count == count && min_position > position)
		{
			max_count = count;
			min_position = position;
			max_identifier = identifier;
		}
	}

	std::cout << max_identifier << std::endl;
}

