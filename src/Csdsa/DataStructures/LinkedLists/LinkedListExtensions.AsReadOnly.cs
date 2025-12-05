using System.Collections;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>AsReadOnly</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Creates a read-only wrapper around the specified linked list.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to wrap.</param>
    /// <returns>
    /// An <see cref="IReadOnlyCollection{T}"/> that provides read-only access
    /// to the underlying list.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is null.
    /// </exception>
    public static IReadOnlyCollection<T> AsReadOnly<T>(this ILinkedList<T> list)
    {
        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        return new ReadOnlyLinkedListWrapper<T>(list);
    }

    /// <summary>
    /// Read-only wrapper around an <see cref="ILinkedList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    private sealed class ReadOnlyLinkedListWrapper<T> : IReadOnlyCollection<T>
    {
        private readonly ILinkedList<T> _inner;

        public ReadOnlyLinkedListWrapper(ILinkedList<T> inner)
        {
            _inner = inner;
        }

        public int Count
        {
            get { return _inner.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _inner.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
