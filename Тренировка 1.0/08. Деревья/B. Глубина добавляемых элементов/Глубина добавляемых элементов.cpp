#include <iostream>
#include <vector>

struct node
{
	int key;
	int left;
	int right;
};

struct memory_struct
{
	std::vector<node> nodes;
	int first_free;
};

memory_struct init_memory(int n)
{
	std::vector<node> memory;
	for (int i = 0; i < n; ++i)
		memory.push_back({ 0, i + 1, 0 });
	return { memory, 0 };
}

int new_node(memory_struct& memory)
{
	int first_free = memory.first_free;
	memory.first_free = memory.nodes[memory.first_free].left;
	return first_free;
}

void delete_node(memory_struct& memory, int index)
{
	memory.nodes[index].left = memory.first_free;
	memory.first_free = index;
}

int create_fill_node(memory_struct& memory, int key)
{
	int index = new_node(memory);
	memory.nodes[index].key = key;
	memory.nodes[index].right = -1;
	memory.nodes[index].left = -1;
	return index;
}

void add(memory_struct& memory, int root, int x)
{
	int key = memory.nodes[root].key;
	if (x < key)
	{
		int left = memory.nodes[root].left;
		if (memory.nodes[root].left == -1) memory.nodes[root].left = create_fill_node(memory, x);
		else add(memory, left, x);
	}
	else if (x > key)
	{
		int right = memory.nodes[root].right;
		if (right == -1) memory.nodes[root].right = create_fill_node(memory, x);
		else add(memory, right, x);
	}
}

int find(memory_struct& memory, int root, int x)
{
	int key = memory.nodes[root].key, temp;
	if (x == key) return root;
	else if (x < key)
	{
		int left = memory.nodes[root].left;
		if (left == -1) return -1;
		else temp = find(memory, left, x);
	}
	else if (x > key)
	{
		int right = memory.nodes[root].right;
		if (right == -1) return -1;
		else temp = find(memory, right, x);
	}
	return temp;
}

int add_get_height(memory_struct& tree, int root, int x, int height = 1)
{
	int key = tree.nodes[root].key, temp;
	if (x < key)
	{
		int left = tree.nodes[root].left;
		if (tree.nodes[root].left == -1)
		{
			tree.nodes[root].left = create_fill_node(tree, x);
			return height + 1;
		}
		else temp = add_get_height(tree, left, x, height + 1);
	}
	else if (x > key)
	{
		int right = tree.nodes[root].right;
		if (right == -1)
		{
			tree.nodes[root].right = create_fill_node(tree, x);
			return height + 1;
		}
		else temp = add_get_height(tree, right, x, height + 1);
	}
	return temp;
}

int main()
{
	int number;
	std::vector<int> input;
	while (std::cin >> number)
	{
		if (number == 0) break;
		input.push_back(number);
	}

	memory_struct tree = init_memory(input.size());
	int root = create_fill_node(tree, input[0]);
	std::cout << 1 << " ";
	for (int i = 1; i < input.size(); ++i)
	{
		if (find(tree, root, input[i]) == -1) std::cout << add_get_height(tree, root, input[i]) << " ";

	}
}
