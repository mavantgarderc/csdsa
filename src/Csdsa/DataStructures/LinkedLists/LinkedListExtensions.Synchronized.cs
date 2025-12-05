using System.Collections;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <c>Synchronized</c> extension for <see cref="ILinkedList{T}"/>.
/// </summary>
public static partial class LinkedListExtensions
{
    /// <summary>
    /// Creates a thread-safe wrapper around the specified linked list.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="list">The list to wrap.</param>
    /// <returns>
    /// An <see cref="ILinkedList{T}"/> that is safe for concurrent access via locking.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="list"/> is null.
    /// </exception>
    public static ILinkedList<T> Synchronized<T>(this ILinkedList<T> list)
    {
        if (list == null)
        {
            ArgumentNullException.ThrowIfNull(list);
        }

        return new SynchronizedLinkedList<T>(list);
    }

    /// <summary>
    /// Thread-safe wrapper around an <see cref="ILinkedList{T}"/> using a monitor lock.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    private sealed class SynchronizedLinkedList<T> : ILinkedList<T>
    {
        private readonly ILinkedList<T> _inner;
        private readonly object _lockObject;

        public SynchronizedLinkedList(ILinkedList<T> inner)
        {
            _inner = inner;
            _lockObject = new object();
        }

        public int Count
        {
            get
            {
                lock (_lockObject)
                {
                    return _inner.Count;
                }
            }
        }

        public void AddFirst(T item)
        {
            lock (_lockObject)
            {
                _inner.AddFirst(item);
            }
        }

        public void AddLast(T item)
        {
            lock (_lockObject)
            {
                _inner.AddLast(item);
            }
        }

        public void Clear()
        {
            lock (_lockObject)
            {
                _inner.Clear();
            }
        }

        public bool Contains(T item)
        {
            lock (_lockObject)
            {
                return _inner.Contains(item);
            }
        }

        public T PeekFirst()
        {
            lock (_lockObject)
            {
                return _inner.PeekFirst();
            }
        }

        public T PeekLast()
        {
            lock (_lockObject)
            {
                return _inner.PeekLast();
            }
        }

        public void RemoveFirst()
        {
            lock (_lockObject)
            {
                _inner.RemoveFirst();
            }
        }

        public void RemoveLast()
        {
            lock (_lockObject)
            {
                _inner.RemoveLast();
            }
        }

        public bool Remove(T item)
        {
            lock (_lockObject)
            {
                return _inner.Remove(item);
            }
        }

        public void Reverse()
        {
            lock (_lockObject)
            {
                _inner.Reverse();
            }
        }

        public ILinkedList<T> Clone()
        {
            lock (_lockObject)
            {
                return _inner.Clone();
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            lock (_lockObject)
            {
                _inner.AddRange(items);
            }
        }

        public T[] ToArray()
        {
            lock (_lockObject)
            {
                // Snapshot via enumeration to preserve original behavior.
                List<T> snapshot = new List<T>(_inner);
                return snapshot.ToArray();
            }
        }

        public bool HasCycle()
        {
            lock (_lockObject)
            {
                return _inner.HasCycle();
            }
        }

        public IEnumerable<T> ReverseIterator()
        {
            lock (_lockObject)
            {
                return _inner.ReverseIterator();
            }
        }

        public (int Length, int MidIndex) GetStructuralInfo()
        {
            lock (_lockObject)
            {
                return _inner.GetStructuralInfo();
            }
        }

        public int GetNodeDepth(T item)
        {
            lock (_lockObject)
            {
                return _inner.GetNodeDepth(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] snapshot;
            lock (_lockObject)
            {
                List<T> list = new List<T>(_inner);
                snapshot = list.ToArray();
            }

            return ((IEnumerable<T>)snapshot).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
