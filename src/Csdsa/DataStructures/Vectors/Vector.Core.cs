using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Core implementation for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T> : IEquatable<Vector<T>>
    where T : INumber<T>
{
    private readonly T[] _components;

    /// <summary>
    /// Initializes a new instance of the <see cref="Vector{T}"/> struct
    /// from the specified components.
    /// </summary>
    /// <param name="components">The components that define the vector.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="components"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null check avoids CA2264 under nullable disabled.")]
    public Vector(params T[] components)
    {
        if (components == null)
        {
            throw new ArgumentNullException(nameof(components));
        }

        _components = components.ToArray();
    }

    /// <summary>
    /// Gets the dimension (number of components) of the vector.
    /// </summary>
    public readonly int Dimension => _components.Length;

    /// <summary>
    /// Gets the component at the specified index.
    /// </summary>
    /// <param name="index">The zero-based component index.</param>
    /// <returns>The component value at the specified index.</returns>
    public readonly T this[int index] => _components[index];

    private readonly Vector<T> BinaryOp(Vector<T> other, Func<T, T, T> op)
    {
        ValidateDimensions(other);

        T[] result = new T[Dimension];

        for (int i = 0; i < Dimension; i++)
        {
            result[i] = op(_components[i], other[i]);
        }

        return new Vector<T>(result);
    }

    private readonly void ValidateDimensions(int expected)
    {
        if (Dimension != expected)
        {
            throw new InvalidOperationException(
                "Operation requires vector dimension " + expected + ".");
        }
    }

    private readonly void ValidateDimensions(Vector<T> other)
    {
        if (Dimension != other.Dimension)
        {
            throw new ArgumentException("Vectors must have the same dimension.", nameof(other));
        }
    }

    private readonly TResult ValidateDimensions<TResult>(
        Vector<T> other,
        Func<TResult> operation)
    {
        ValidateDimensions(other);
        return operation();
    }

    /// <summary>
    /// Determines whether this vector is equal to another vector by comparing
    /// all components for exact equality.
    /// </summary>
    /// <param name="other">The other vector to compare with.</param>
    /// <returns>
    /// <see langword="true"/> if both vectors have the same dimension and all
    /// corresponding components are equal; otherwise, <see langword="false"/>.
    /// </returns>
    public readonly bool Equals(Vector<T> other)
    {
        if (Dimension != other.Dimension)
        {
            return false;
        }

        for (int i = 0; i < Dimension; i++)
        {
            if (!_components[i].Equals(other[i]))
            {
                return false;
            }
        }

        return true;
    }

    /// <inheritdoc/>
    public override readonly bool Equals(object obj)
    {
        return obj is Vector<T> other && Equals(other);
    }

    /// <inheritdoc/>
    public override readonly int GetHashCode()
    {
        HashCode hash = default;
        hash.Add(Dimension);

        foreach (T item in _components)
        {
            hash.Add(item);
        }

        return hash.ToHashCode();
    }

    /// <summary>
    /// Determines whether two vectors are equal.
    /// </summary>
    /// <param name="left">The first vector to compare.</param>
    /// <param name="right">The second vector to compare.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="left"/> and <paramref name="right"/>
    /// are equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(Vector<T> left, Vector<T> right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Determines whether two vectors are not equal.
    /// </summary>
    /// <param name="left">The first vector to compare.</param>
    /// <param name="right">The second vector to compare.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="left"/> and <paramref name="right"/>
    /// are not equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(Vector<T> left, Vector<T> right)
    {
        return !left.Equals(right);
    }
}
