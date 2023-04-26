using System;
using System.Collections.Generic;

Heap heap = new Heap();
int N = int.Parse(Console.ReadLine());
for(int i = 0; i < N; i++)
{
    string[] instruction = Console.ReadLine().Split(' ');
    if (instruction[0] == "0") heap.Insert(int.Parse(instruction[1]));
    else Console.WriteLine(heap.Extract());
}

class Heap
{
    private List<int> _tree = new List<int>();

    public void Insert(int number)
    {
        _tree.Add(number);
        int pos = _tree.Count - 1;
        while(pos > 0 && _tree[pos] > _tree[(pos - 1) / 2])
        {
            int temp = _tree[pos];
            _tree[pos] = _tree[(pos - 1) / 2];
            _tree[(pos - 1) / 2] = temp;
            pos = (pos - 1) / 2;
        }
    }

    public int Extract()
    {
        int maxElement = _tree[0];
        _tree[0] = _tree[_tree.Count - 1];
        int pos = 0;
        while(pos * 2 + 2 < _tree.Count)
        {
            int maxNeighbourIndex = pos * 2 + 1;
            if (_tree[pos * 2 + 2] > _tree[maxNeighbourIndex]) maxNeighbourIndex = pos * 2 + 2;
            if (_tree[pos] < _tree[maxNeighbourIndex])
            {
                int temp = _tree[pos];
                _tree[pos] = _tree[maxNeighbourIndex];
                _tree[maxNeighbourIndex] = temp;
                pos = maxNeighbourIndex;
            }
            else break;
        }
        _tree.RemoveAt(_tree.Count - 1);
        return maxElement;
    }
}