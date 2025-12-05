using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Provides swap operations for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Swaps this vector instance with another by reference.
    /// </summary>
    /// <param name="other">The vector to swap with this instance.</param>
    public void Swap(ref Vector<T> other)
    {
        (this, other) = (other, this);
    }
}
