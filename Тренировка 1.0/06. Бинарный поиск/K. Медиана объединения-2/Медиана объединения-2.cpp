#include <algorithm>
#include <iostream>
#include <vector>

int count_less(int mid, const std::vector<int>& sequence)
{
	int middle, left = 0, right = sequence.size() - 1;
	while (left < right)
	{
		middle = (left + right) / 2;
		if (sequence[middle] >= mid) right = middle;
		else left = middle + 1;
	}
	if (sequence[left] < mid) return sequence.size();
	return left;
}

int count_greater(int mid, const std::vector<int>& sequence)
{
	return sequence.size() - count_less(mid + 1, sequence);
}

int merge_sequences(const std::vector<int>& A, const std::vector<int>& B)
{
	int less, greater;
	int middle, left = std::min(A.front(), B.front()),
		right = std::max(A.back(), B.back());
	while (left < right)
	{
		middle = (left + right) / 2;
		less = count_less(middle, A) + count_less(middle, B);
		greater = count_greater(middle, A) + count_greater(middle, B);
		if (less <= A.size() - 1 && greater <= A.size()) return middle;
		if (greater > A.size()) left = middle + 1;
		if (less > A.size() - 1) right = middle - 1;
	}
	return left;
}

int main()
{
	int N, L;
	std::cin >> N >> L;

	std::vector<int> sequence;
	int x1, d1, a, c, m;
	std::vector<std::vector<int>> sequences;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> x1 >> d1 >> a >> c >> m;
		sequence = { x1 };
		int d = d1;
		for (int j = 0; j < L - 1; ++j)
		{
			sequence.push_back(sequence.back() + d);
			d = (a * d + c) % m;
		}
		sequences.push_back(sequence);
	}

	for (int i = 0; i < N; ++i)
		for (int j = i + 1; j < N; ++j)
			std::cout << merge_sequences(sequences[i], sequences[j]) << std::endl;
}
