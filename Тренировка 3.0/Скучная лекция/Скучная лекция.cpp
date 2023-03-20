#include <iostream>
#include <string>
#include <fstream>

int main()
{
    std::ifstream is("input.txt");
    std::ofstream os("output.txt");
    os.clear();
    std::string word;
    is >> word;
    for (int i = 0; i < 26; ++i)
    {
        unsigned long long count = 0;
        for (int j = 0, n = word.size(); j < n; ++j)
            if (i + 'a' == word[j]) count += (unsigned long long)(j + 1) * (n - j);
        if (count != 0) os << (char)(i + 'a') << ": " << count << std::endl;
    }
    is.close();
    os.close(); 
}
