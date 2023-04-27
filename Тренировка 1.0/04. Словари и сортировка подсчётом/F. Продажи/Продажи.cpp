#include <iostream>
#include <string>
#include <map>

int main()
{
	unsigned long count;
	std::string name, product;
	std::map<std::string, std::map<std::string, unsigned long>> map;

	while (std::cin >> name)
	{
		std::cin >> product >> count;
		map[name][product] += count;
	}

	for (const auto& [name, products] : map)
	{
		std::cout << name << ":\n";
		for (const auto& [product, count] : products)
			std::cout << product << " " << count << std::endl;
	}
}//