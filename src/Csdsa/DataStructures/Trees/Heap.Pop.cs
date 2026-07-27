namespace Csdsa.DataStructures.Trees;

public partial class Heap<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Removes and returns the minimum (or maximum) element from the heap.
    /// </summary>
    /// <returns>The minimum (or maximum) element in the heap.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the heap is empty.</exception>
    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Cannot pop from an empty heap.");
        }

        T root = _heap[0];

        // Move the last element to the root
        T lastElement = _heap[_heap.Count - 1];
        _heap[0] = lastElement;
        _heap.RemoveAt(_heap.Count - 1);

        // If heap is not empty, restore heap property by bubbling down
        if (_heap.Count > 0)
        {
            HeapifyDown(0);
        }

        return root;
    }

    /// <summary>
    /// Maintains the heap property by moving an element down the heap.
    /// </summary>
    /// <param name="index">The index of the element to bubble down.</param>
    private void HeapifyDown(int index)
    {
        int leftChildIndex = (2 * index) + 1;
        int rightChildIndex = (2 * index) + 2;
        int smallestIndex = index;

        // Check if left child exists and is smaller (or larger for max-heap)
        if (leftChildIndex < _heap.Count &&
            _comparer.Compare(_heap[leftChildIndex], _heap[smallestIndex]) < 0)
        {
            smallestIndex = leftChildIndex;
        }

        // Check if right child exists and is smaller (or larger for max-heap)
        if (rightChildIndex < _heap.Count &&
            _comparer.Compare(_heap[rightChildIndex], _heap[smallestIndex]) < 0)
        {
            smallestIndex = rightChildIndex;
        }

        // If the smallest is not the current node, swap and continue
        if (smallestIndex != index)
        {
            Swap(index, smallestIndex);
            HeapifyDown(smallestIndex);
        }
    }
}
