namespace Csdsa.DataStructures.Trees;

public partial class Heap<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Returns the minimum (or maximum) element in the heap without removing it.
    /// </summary>
    /// <returns>The minimum (or maximum) element in the heap.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the heap is empty.</exception>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Cannot peek at an empty heap.");
        }

        return _heap[0];
    }

    /// <summary>
    /// Builds a heap from an existing collection of elements.
    /// </summary>
    /// <param name="collection">The collection of elements to build the heap from.</param>
    public void BuildHeap(IEnumerable<T> collection)
    {
        _heap.Clear();
        _heap.AddRange(collection);

        // Heapify the entire array starting from the last non-leaf node
        for (int i = (_heap.Count / 2) - 1; i >= 0; i--)
        {
            HeapifyDown(i);
        }
    }
}
