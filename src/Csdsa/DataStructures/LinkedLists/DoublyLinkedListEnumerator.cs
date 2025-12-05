using System.Collections;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Enumerates the elements of a doubly linked list with version checking.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public sealed class DoublyLinkedListEnumerator<T> : IEnumerator<T>
{
    private readonly LinkedListNode<T> _start;
    private readonly Func<int> _getVersion;
    private readonly int _initialVersion;

    private LinkedListNode<T> _current;

    /// <summary>
    /// Initializes a new instance of the <see cref="DoublyLinkedListEnumerator{T}"/> class.
    /// </summary>
    /// <param name="start">The first node of the list.</param>
    /// <param name="getVersion">
    /// A delegate that returns the current version of the underlying list.
    /// If <see langword="null"/>, a constant zero is used.
    /// </param>
    public DoublyLinkedListEnumerator(
        LinkedListNode<T> start,
        Func<int> getVersion = null)
    {
        _start = start;
        _getVersion = getVersion ?? (() => 0);
        _initialVersion = _getVersion();
    }

    /// <inheritdoc />
    public T Current
    {
        get
        {
            if (_current == null)
            {
                throw new InvalidOperationException("Enumerator is not positioned on an element.");
            }

            return _current.Value;
        }
    }

    object IEnumerator.Current => Current;

    /// <inheritdoc />
    public bool MoveNext()
    {
        if (_initialVersion != _getVersion())
        {
            throw new InvalidOperationException("Collection was modified.");
        }

        if (_current == null)
        {
            _current = _start;
            return _current != null;
        }

        _current = _current.Next;
        return _current != null;
    }

    /// <inheritdoc />
    public void Reset()
    {
        if (_initialVersion != _getVersion())
        {
            throw new InvalidOperationException("Collection was modified.");
        }

        _current = null;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
