#include <iostream>
#include <unordered_map>

int main()
{
	std::string input;
	std::unordered_map<std::string, int> map;
	while (std::cin >> input) std::cout << map[std::move(input)]++ << " ";
}