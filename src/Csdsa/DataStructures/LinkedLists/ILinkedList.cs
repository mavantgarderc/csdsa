namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Defines a common contract for linked list implementations.
/// <para>
/// Concepts:
/// </para>
/// <list type="bullet">
///   <item>
///     <description>Multiple linked list variants with specialized implementations.</description>
///   </item>
///   <item>
///     <description>
///     Interface-based abstraction that standardizes the API surface
///     across different list variants.
///     </description>
///   </item>
///   <item>
///     <description>
///     Strict separation of concerns: node types, core list, iterators,
///     and extension helpers.
///     </description>
///   </item>
///   <item>
///     <description>
///     Functional-style operators such as map, filter, reduce, foreach, and partition.
///     </description>
///   </item>
///   <item>
///     <description>
///     Thread-safety via synchronized wrappers and snapshot-based iteration.
///     </description>
///   </item>
///   <item>
///     <description>
///     Structural diagnostics including cycle detection and positional analysis.
///     </description>
///   </item>
/// </list>
/// </summary>
/// <typeparam name="T">The type of elements stored in the list.</typeparam>
public interface ILinkedList<T> : IEnumerable<T>
{
    /// <summary>
    /// Inserts an element at the beginning of the list.
    /// </summary>
    /// <param name="item">The element to insert.</param>
    void AddFirst(T item);

    /// <summary>
    /// Inserts an element at the end of the list.
    /// </summary>
    /// <param name="item">The element to insert.</param>
    void AddLast(T item);

    /// <summary>
    /// Removes the first element of the list.
    /// </summary>
    void RemoveFirst();

    /// <summary>
    /// Removes the last element of the list.
    /// </summary>
    void RemoveLast();

    /// <summary>
    /// Removes the first occurrence of a specific element from the list.
    /// </summary>
    /// <param name="item">The element to remove.</param>
    /// <returns>
    /// <see langword="true"/> if the element was found and removed; otherwise, <see langword="false"/>.
    /// </returns>
    bool Remove(T item);

    /// <summary>
    /// Determines whether the list contains a specific value.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// <see langword="true"/> if the element is found; otherwise, <see langword="false"/>.
    /// </returns>
    bool Contains(T item);

    /// <summary>
    /// Gets the number of elements contained in the list.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Returns the first element in the list without removing it.
    /// </summary>
    /// <returns>The first element in the list.</returns>
    T PeekFirst();

    /// <summary>
    /// Returns the last element in the list without removing it.
    /// </summary>
    /// <returns>The last element in the list.</returns>
    T PeekLast();

    /// <summary>
    /// Removes all elements from the list.
    /// </summary>
    void Clear();

    /// <summary>
    /// Reverses the order of the elements in the list in-place.
    /// </summary>
    void Reverse();

    /// <summary>
    /// Creates a shallow copy of the list.
    /// </summary>
    /// <returns>A new <see cref="ILinkedList{T}"/> that contains the same elements.</returns>
    ILinkedList<T> Clone();

    /// <summary>
    /// Appends the elements of the specified sequence to the end of the list.
    /// </summary>
    /// <param name="items">The sequence whose elements should be added.</param>
    void AddRange(IEnumerable<T> items);

    /// <summary>
    /// Copies the elements of the list to a new array.
    /// </summary>
    /// <returns>An array containing copies of the elements of the list.</returns>
    T[] ToArray();

    /// <summary>
    /// Determines whether the list contains a structural cycle.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the list contains a cycle; otherwise, <see langword="false"/>.
    /// </returns>
    bool HasCycle();

    /// <summary>
    /// Returns an enumerable that yields the elements of the list in reverse order.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> that iterates the list in reverse.</returns>
    IEnumerable<T> ReverseIterator();

    /// <summary>
    /// Gets diagnostic information about the structure of the list.
    /// </summary>
    /// <returns>
    /// A tuple whose <c>Length</c> is the number of elements and whose <c>MidIndex</c>
    /// is the index of the middle element, or -1 if the list is empty.
    /// </returns>
    (int Length, int MidIndex) GetStructuralInfo();

    /// <summary>
    /// Gets the zero-based index of the first node whose value equals the specified item.
    /// </summary>
    /// <param name="item">The value to locate.</param>
    /// <returns>
    /// The zero-based index of the node if found; otherwise, -1.
    /// </returns>
    int GetNodeDepth(T item);
}
