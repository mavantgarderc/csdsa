namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Defines a contract for a dynamically sized, array-backed list of elements.
/// <para>
/// This interface models the same behavior as <c>ArrayListUtils&lt;T&gt;</c>,
/// including capacity management, range operations, searches, and predicate-based APIs.
/// </para>
/// </summary>
/// <typeparam name="T">The type of elements stored in the list.</typeparam>
public interface IArrayList<T>
{
    /// <summary>
    /// Gets or sets the total number of elements that the internal array can hold
    /// without resizing.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the specified capacity is less than the current <see cref="ICollection{T}.Count"/>.
    /// </exception>
    int Capacity { get; set; }

    /// <summary>
    /// Gets or sets the element at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index of the element to get or set.</param>
    /// <returns>The element at the specified index.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> is less than zero or greater than or equal to <see cref="ICollection{T}.Count"/>.
    /// </exception>
    T this[int index] { get; set; }

    /// <summary>
    /// Searches for the specified element and returns the zero-based index
    /// of the first occurrence within the list.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of the first occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    int IndexOf(T item);

    /// <summary>
    /// Returns the zero-based index of the last occurrence of a value in the entire list.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of the last occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    int LastIndexOf(T item);

    /// <summary>
    /// Returns the zero-based index of the last occurrence of a value in the list,
    /// searching backward from the specified index.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <param name="startIndex">
    /// The zero-based starting index of the backward search.
    /// </param>
    /// <returns>
    /// The zero-based index of the last occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    int LastIndexOf(T item, int startIndex);

    /// <summary>
    /// Returns the zero-based index of the last occurrence of a value in a range of
    /// elements in the list.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <param name="startIndex">
    /// The zero-based starting index of the backward search.
    /// </param>
    /// <param name="count">The number of elements in the section to search.</param>
    /// <returns>
    /// The zero-based index of the last occurrence of <paramref name="item"/>, if found;
    /// otherwise, -1.
    /// </returns>
    int LastIndexOf(T item, int startIndex, int count);

    /// <summary>
    /// Inserts an element into the list at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which the element should be inserted.</param>
    /// <param name="item">The element to insert.</param>
    void Insert(int index, T item);

    /// <summary>
    /// Removes the element at the specified index of the list.
    /// </summary>
    /// <param name="index">The zero-based index of the element to remove.</param>
    void RemoveAt(int index);

    /// <summary>
    /// Sets the capacity to the actual number of elements in the list,
    /// if that number is less than the current capacity.
    /// </summary>
    void TrimToSize();

    /// <summary>
    /// Reverses the order of the elements in the entire list.
    /// </summary>
    void Reverse();

    /// <summary>
    /// Reverses the order of the elements in the specified range of the list.
    /// </summary>
    /// <param name="index">The zero-based starting index of the range to reverse.</param>
    /// <param name="count">The number of elements in the range to reverse.</param>
    void Reverse(int index, int count);

    /// <summary>
    /// Copies the elements of the list to a new array.
    /// </summary>
    /// <returns>A new array containing copies of the elements of the list.</returns>
    T[] ToArray();

    /// <summary>
    /// Creates a shallow copy of a range of elements in the list.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range.</param>
    /// <param name="count">The number of elements in the range.</param>
    /// <returns>
    /// A new <see cref="ArrayListUtils{T}"/> containing the specified range of elements.
    /// </returns>
    ArrayListUtils<T> GetRange(int startIndex, int count);

    /// <summary>
    /// Searches for the specified element in the entire sorted list using
    /// the default comparer.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <returns>
    /// The zero-based index of <paramref name="item"/> if found; otherwise, a negative number.
    /// </returns>
    int BinarySearch(T item);

    /// <summary>
    /// Searches for the specified element in the entire sorted list using
    /// the specified comparer.
    /// </summary>
    /// <param name="item">The element to locate.</param>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    /// <returns>
    /// The zero-based index of <paramref name="item"/> if found; otherwise, a negative number.
    /// </returns>
    int BinarySearch(T item, IComparer<T> comparer);

    /// <summary>
    /// Searches a range of elements in the sorted list for the specified element
    /// using the specified comparer.
    /// </summary>
    /// <param name="index">The zero-based starting index of the range to search.</param>
    /// <param name="count">The number of elements in the range to search.</param>
    /// <param name="item">The element to locate.</param>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    /// <returns>
    /// The zero-based index of <paramref name="item"/> if found; otherwise, a negative number.
    /// </returns>
    int BinarySearch(int index, int count, T item, IComparer<T> comparer);

    /// <summary>
    /// Adds the elements of the specified collection to the end of the list.
    /// </summary>
    /// <param name="collection">The collection whose elements should be added.</param>
    void AddRange(IEnumerable<T> collection);

    /// <summary>
    /// Inserts the elements of a collection into the list at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which to insert the new elements.</param>
    /// <param name="collection">The collection whose elements should be inserted.</param>
    void InsertRange(int index, IEnumerable<T> collection);

    /// <summary>
    /// Removes a range of elements from the list.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range to remove.</param>
    /// <param name="count">The number of elements to remove.</param>
    void RemoveRange(int startIndex, int count);

    /// <summary>
    /// Sets a contiguous range of elements in the list from the specified collection.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the range to set.</param>
    /// <param name="collection">The collection providing the elements.</param>
    void SetRange(int startIndex, ICollection<T> collection);

    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate, and returns the zero-based index of the first occurrence.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The zero-based index of the first element that matches the predicate,
    /// if found; otherwise, -1.
    /// </returns>
    int FindIndex(Predicate<T> match);

    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate, starting at the specified index.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The zero-based index of the first element that matches the predicate,
    /// if found; otherwise, -1.
    /// </returns>
    int FindIndex(int startIndex, Predicate<T> match);

    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate within the specified range.
    /// </summary>
    /// <param name="startIndex">The zero-based starting index of the search.</param>
    /// <param name="count">The number of elements in the range to search.</param>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The zero-based index of the first element that matches the predicate,
    /// if found; otherwise, -1.
    /// </returns>
    int FindIndex(int startIndex, int count, Predicate<T> match);

    /// <summary>
    /// Searches for an element that matches the conditions defined by the specified
    /// predicate, and returns the first occurrence.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// The first element that matches the predicate, if found; otherwise,
    /// the default value of the element type.
    /// </returns>
    T Find(Predicate<T> match);

    /// <summary>
    /// Retrieves all elements that match the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// A new <see cref="ArrayListUtils{T}"/> containing all matching elements.
    /// </returns>
    ArrayListUtils<T> FindAll(Predicate<T> match);

    /// <summary>
    /// Determines whether the list contains an element that matches
    /// the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// <see langword="true"/> if an element that matches the predicate is found;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    bool Exists(Predicate<T> match);

    /// <summary>
    /// Determines whether every element in the list matches the conditions
    /// defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements.</param>
    /// <returns>
    /// <see langword="true"/> if every element matches the predicate
    /// or the list is empty; otherwise, <see langword="false"/>.
    /// </returns>
    bool TrueForAll(Predicate<T> match);

    /// <summary>
    /// Performs the specified action on each element of the list.
    /// </summary>
    /// <param name="action">The action to perform on each element.</param>
    void ForEach(Action<T> action);

    /// <summary>
    /// Removes all the elements that match the conditions defined by the specified predicate.
    /// </summary>
    /// <param name="match">The predicate to test elements to be removed.</param>
    /// <returns>
    /// The number of elements removed from the list.
    /// </returns>
    int RemoveAll(Predicate<T> match);

    /// <summary>
    /// Ensures that the list can hold at least the specified number of elements
    /// without resizing.
    /// </summary>
    /// <param name="minCapacity">The minimum required capacity.</param>
    void EnsureCapacity(int minCapacity);

    /// <summary>
    /// Copies the entire list to a compatible one-dimensional array, starting
    /// at the specified index of the target array.
    /// </summary>
    /// <param name="array">The destination array.</param>
    /// <param name="arrayIndex">
    /// The zero-based index in <paramref name="array"/> at which copying begins.
    /// </param>
    void CopyTo(T[] array, int arrayIndex);

    /// <summary>
    /// Sorts the elements in the entire list using the default comparer.
    /// </summary>
    void Sort();

    /// <summary>
    /// Sorts the elements in the entire list using the specified comparer.
    /// </summary>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    void Sort(IComparer<T> comparer);

    /// <summary>
    /// Sorts the elements in a range of the list using the specified comparer.
    /// </summary>
    /// <param name="index">The zero-based starting index of the range to sort.</param>
    /// <param name="count">The number of elements in the range to sort.</param>
    /// <param name="comparer">
    /// The comparer to use, or <see langword="null"/> to use <see cref="Comparer{T}.Default"/>.
    /// </param>
    void Sort(int index, int count, IComparer<T> comparer);
}
