using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());

int[] arr = new int[N];
string[] stringArray = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++) arr[i] = int.Parse(stringArray[i]);

ArrayHeap heap = new ArrayHeap();
heap.HeapSort(arr);
for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

class ArrayHeap
{
    private List<int> _tree = new List<int>();

    public void HeapSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++) _tree.Add(array[i]);
        for (int i = _tree.Count / 2; i >= 0; i--) Heapify(i);

        for (int i = array.Length - 1; i >= 0; i--)
        {
            int temp = _tree[0];
            _tree[0] = _tree[_tree.Count - 1];
            _tree.RemoveAt(_tree.Count - 1);
            array[i] = temp;
            Heapify(0);
        }
    }

    private void Heapify(int pos)
    {
        while (true)
        {
            int l = 2 * pos + 1, r = 2 * pos + 2, maxElement = pos;
            if (l < _tree.Count && _tree[l] > _tree[maxElement]) maxElement = l;
            if (r < _tree.Count && _tree[r] > _tree[maxElement]) maxElement = r;
            if (maxElement == pos) break;

            int temp = _tree[pos];
            _tree[pos] = _tree[maxElement];
            _tree[maxElement] = temp;
            pos = maxElement;
        }
    }
}