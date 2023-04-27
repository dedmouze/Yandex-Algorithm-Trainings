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
    std::vector<node> nodes;
    for (int i = 0; i < n; ++i) nodes.push_back({ 0, i + 1, 0 });
    return { nodes, 0 };
}

int new_node(memory_struct& memory)
{
    int first_free = memory.first_free;
    memory.first_free = memory.nodes[first_free].left;
    return first_free;
}

void delete_node(memory_struct& memory, int index)
{
    if (index == -1) return;

    memory.nodes[index].left = memory.first_free;
    memory.first_free = index;
}

int create_fill_node(memory_struct& memory, int key)
{
    int index = new_node(memory);
    memory.nodes[index].key = key;
    memory.nodes[index].left = -1;
    memory.nodes[index].right = -1;
    return index;
}

void add(memory_struct& memory, int root, int x)
{
    int key = memory.nodes[root].key;
    if (x < key)
    {
        int left = memory.nodes[root].left;
        if (left == -1) memory.nodes[root].left = create_fill_node(memory, x);
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
    else
    {
        int right = memory.nodes[root].right;
        if (right == -1) return -1;
        else temp = find(memory, right, x);
    }

    return temp;
}

int check_balance(memory_struct& tree, int root, int height = 0)
{
    if (root == -1) return height - 1;

    int left = check_balance(tree, tree.nodes[root].left, height + 1);
    int right = check_balance(tree, tree.nodes[root].right, height + 1);

    if (left == -1 || right == -1 || std::abs(left - right) > 1) return -1;

    return std::max(left, right);
}

int main()
{
    int number;
    std::vector<int> input;
    while (std::cin >> number && number != 0) input.push_back(number);

    memory_struct tree = init_memory(input.size());
    int root = create_fill_node(tree, input[0]);
    for (int i = 1; i < input.size(); ++i)
        if (find(tree, root, input[i]) == -1) add(tree, root, input[i]);
    
    bool is_balanced = check_balance(tree, root) != -1;
    std::cout << (is_balanced ? "YES" : "NO");
}
