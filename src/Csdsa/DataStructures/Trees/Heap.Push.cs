namespace Csdsa.DataStructures.Trees;

public partial class Heap<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Adds an element to the heap.
    /// </summary>
    /// <param name="item">The element to add to the heap.</param>
    public void Push(T item)
    {
        // Add the item to the end of the list
        _heap.Add(item);

        // Restore heap property by bubbling up
        HeapifyUp(_heap.Count - 1);
    }

    /// <summary>
    /// Maintains the heap property by moving an element up the heap.
    /// </summary>
    /// <param name="index">The index of the element to bubble up.</param>
    private void HeapifyUp(int index)
    {
        // If we're at the root, we're done
        if (index == 0)
        {
            return;
        }

        // Calculate the parent index
        int parentIndex = (index - 1) / 2;

        // If the heap property is violated, swap and continue
        if (_comparer.Compare(_heap[index], _heap[parentIndex]) < 0)
        {
            Swap(index, parentIndex);
            HeapifyUp(parentIndex);
        }
    }

    /// <summary>
    /// Swaps two elements in the heap array.
    /// </summary>
    /// <param name="i">The index of the first element.</param>
    /// <param name="j">The index of the second element.</param>
    private void Swap(int i, int j)
    {
        T temp = _heap[i];
        _heap[i] = _heap[j];
        _heap[j] = temp;
    }
}
