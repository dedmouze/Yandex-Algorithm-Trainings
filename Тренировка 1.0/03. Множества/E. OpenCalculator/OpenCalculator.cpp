#include <set>
#include <vector>
#include <iostream>
#include <algorithm>

int main()
{
    char x, y, z;
    std::cin >> x >> y >> z;

    std::set<char> set1 = {x, y, z};
    std::set<char> set2;
    std::string number;
    std::cin >> number;
    for (int i = 0, n = number.size(); i < n; ++i) set2.emplace(number[i]);

    std::vector<int> missingDigits;
    std::set_difference(set2.begin(), set2.end(), set1.begin(), set1.end(), std::back_inserter(missingDigits));
    std::cout << missingDigits.size();
}
