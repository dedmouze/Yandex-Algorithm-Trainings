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

void inorder_traversal(memory_struct& tree, int root)
{
	if (root == -1) return;

	int left = tree.nodes[root].left, right = tree.nodes[root].right;
	inorder_traversal(tree, left);
	if (left == -1 && right != -1 || left != -1 && right == -1) std::cout << tree.nodes[root].key << std::endl;
	inorder_traversal(tree, right);
}

int main()
{
	int number;
	std::vector<int> input;
	while (std::cin >> number && number != 0) input.push_back(number);

	memory_struct tree = init_memory(input.size());
	int root = create_fill_node(tree, input[0]);
	for (int i = 1; i < input.size(); ++i)
	{
		if (find(tree, root, input[i]) == -1) add(tree, root, input[i]);
	}

	inorder_traversal(tree, root);
}
