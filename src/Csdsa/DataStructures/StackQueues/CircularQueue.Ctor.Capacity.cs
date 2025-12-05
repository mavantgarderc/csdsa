namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides constructors for <see cref="CircularQueueUtils{T}"/>.
/// </summary>
public partial class CircularQueueUtils<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CircularQueueUtils{T}"/> class
    /// with the specified capacity.
/// </summary>
/// <param name="capacity">The number of elements the queue can hold.</param>
/// <exception cref="ArgumentException">
/// Thrown when <paramref name="capacity"/> is less than or equal to zero.
/// </exception>
    public CircularQueueUtils(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must be positive.");
        }

        _buffer = new T[capacity];
        _head = 0;
        _tail = 0;
        _size = 0;
    }
}
