using System;
using System.Collections;
using System.Collections.Generic;

namespace Csdsa.DataStructures.ArrayList;

/// <summary>
/// Provides enumeration support for <see cref="ArrayList{T}"/>.
/// </summary>
public partial class ArrayList<T>
{
    /// <summary>
    /// Returns an enumerator that iterates through the list.
    /// </summary>
    /// <returns>An enumerator for the list.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return new Enumerator(this);
    }

    /// <summary>
    /// Returns a non-generic enumerator that iterates through the list.
    /// </summary>
    /// <returns>An enumerator for the list.</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Represents an enumerator for <see cref="ArrayList{T}"/>.
    /// </summary>
    private sealed class Enumerator : IEnumerator<T>
    {
        private readonly ArrayList<T> _list;
        private int _index;
        private readonly int _version;
        private T _current;

        /// <summary>
        /// Initializes a new instance of the <see cref="Enumerator"/> class
        /// for the specified list.
        /// </summary>
        /// <param name="list">The list to enumerate.</param>
        internal Enumerator(ArrayList<T> list)
        {
            _list = list;
            _index = -1;
            _version = list._version;
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the enumerator was successfully advanced
        /// to the next element; <see langword="false"/> if the enumerator has
        /// passed the end of the collection.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the list is modified after the enumerator is created.
        /// </exception>
        public bool MoveNext()
        {
            CheckVersion();

            if (_index < _list._size - 1)
            {
                _current = _list._items[++_index];
                return true;
            }

            _index = _list._size;
            _current = default;
            return false;
        }

        /// <summary>
        /// Gets the element in the collection at the current position of the enumerator.
        /// </summary>
        public T Current
        {
            get
            {
                if (_index < 0 || _index >= _list._size)
                {
                    throw new InvalidOperationException("Enumerator is in an invalid state.");
                }

                return _current;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before
        /// the first element in the collection.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the list is modified after the enumerator is created.
        /// </exception>
        public void Reset()
        {
            CheckVersion();
            _index = -1;
            _current = default;
        }

        /// <summary>
        /// Releases all resources used by the enumerator.
        /// </summary>
        public void Dispose()
        {
            _current = default;
        }

        private void CheckVersion()
        {
            if (_version != _list._version)
            {
                throw new InvalidOperationException(
                    "Collection was modified during enumeration.");
            }
        }
    }
}
