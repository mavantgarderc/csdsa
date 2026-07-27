using System.Collections;

namespace Csdsa.DataStructures.Trees;

/// <summary>
/// Represents a generic binary heap data structure that can function as either a min-heap or max-heap.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>
///     Binary heap property: parent nodes have values that are either greater than (max-heap) or less than (min-heap) their children.
///     </description>
///   </item>
///   <item>
///     <description>
///     Implemented as an array-based structure with implicit parent-child relationships.
///     </description>
///   </item>
///   <item>
///     <description>
///     Supports efficient insertion and removal of the minimum/maximum element with O(log n) time complexity.
///     </description>
///   </item>
///   <item>
///     <description>
///     Used as the underlying structure for priority queues.
///     </description>
///   </item>
/// </list>
/// <para>
/// Key practices:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Encapsulation of heap structure behind methods and read-only views.</description>
///   </item>
///   <item>
///     <description>Self-contained methods for individual operations.</description>
///   </item>
///   <item>
///     <description>
///     Clear exception behavior for error conditions.
///     </description>
///   </item>
///   <item>
///     <description>
///     Forward-looking design that can be extended with advanced algorithms
///     or specialized operations.
///     </description>
///   </item>
///   <item>
///     <description>Generic support and serialization helpers.</description>
///   </item>
/// </list>
/// </summary>
/// <typeparam name="T">
/// The value type stored in the heap. Values must be comparable and equatable
/// to support ordering and dictionary keys.
/// </typeparam>
public partial class Heap<T> : IEnumerable<T>
    where T : IComparable<T>, IEquatable<T>
{
    private readonly bool _isMaxHeap;
    private readonly IComparer<T> _comparer;
    private List<T> _heap;

    /// <summary>
    /// Gets the number of elements in the heap.
    /// </summary>
    public int Count => _heap.Count;

    /// <summary>
    /// Gets a value indicating whether the heap is empty.
    /// </summary>
    public bool IsEmpty => _heap.Count == 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="Heap{T}"/> class as a min-heap.
    /// </summary>
    public Heap()
        : this(false)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Heap{T}"/> class.
    /// </summary>
    /// <param name="isMaxHeap">
    /// <see langword="true"/> to create a max-heap; <see langword="false"/> to create a min-heap.
    /// </param>
    public Heap(bool isMaxHeap)
    {
        _heap = new List<T>();
        _isMaxHeap = isMaxHeap;
        _comparer = isMaxHeap ? Comparer<T>.Create((x, y) => y.CompareTo(x)) : Comparer<T>.Default;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Heap{T}"/> class with the specified comparer.
    /// </summary>
    /// <param name="isMaxHeap">
    /// <see langword="true"/> to create a max-heap; <see langword="false"/> to create a min-heap.
    /// </param>
    /// <param name="comparer">The comparer to use for comparing elements.</param>
    public Heap(bool isMaxHeap, IComparer<T> comparer)
    {
        _heap = new List<T>();
        _isMaxHeap = isMaxHeap;
        _comparer = comparer;
    }

    /// <summary>
    /// Returns an enumerator that iterates through the heap.
    /// </summary>
    /// <returns>An enumerator for the heap.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return _heap.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
