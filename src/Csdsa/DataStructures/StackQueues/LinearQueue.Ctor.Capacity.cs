using System;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides constructors for <see cref="LinearQueueUtils{T}"/>.
/// </summary>
public partial class LinearQueueUtils<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LinearQueueUtils{T}"/> class
    /// with the specified capacity.
    /// </summary>
    /// <param name="capacity">The maximum number of elements the queue can hold.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="capacity"/> is less than or equal to zero.
    /// </exception>
    public LinearQueueUtils(int capacity = 8)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must be positive.", nameof(capacity));
        }

        _items = new T[capacity];
        _front = 0;
        _rear = 0;
        _count = 0;
    }
}
