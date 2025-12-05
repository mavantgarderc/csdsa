using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Conversion helpers for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Returns a span over a copy of the internal components.
    /// </summary>
    /// <returns>A span over a copy of the vector components.</returns>
    public readonly Span<T> AsSpan()
    {
        T[] copy = _components.ToArray();
        return new Span<T>(copy);
    }

    /// <summary>
    /// Copies the components into a new array.
    /// </summary>
    /// <returns>A new array containing the components of this vector.</returns>
    public readonly T[] ToArray()
    {
        return _components.ToArray();
    }

    /// <summary>
    /// Copies the components into a new read-only list.
    /// </summary>
    /// <returns>
    /// A read-only list view over a new list containing the components.
    /// </returns>
    public readonly IReadOnlyList<T> ToList()
    {
        return new List<T>(_components);
    }

    /// <summary>
    /// Copies the components into the specified destination span.
    /// </summary>
    /// <param name="destination">
    /// The span that will receive the components. Must be at least
    /// <see cref="Dimension"/> elements long.
    /// </param>
    public readonly void CopyTo(Span<T> destination)
    {
        _components.AsSpan().CopyTo(destination);
    }

    /// <summary>
    /// Returns a column matrix representation of the vector (Dimension x 1).
    /// </summary>
    /// <returns>A two-dimensional array representing the vector as a column.</returns>
    public readonly T[,] ToColumnMatrix()
    {
        T[,] matrix = new T[Dimension, 1];

        for (int i = 0; i < Dimension; i++)
        {
            matrix[i, 0] = _components[i];
        }

        return matrix;
    }

    /// <summary>
    /// Returns a row matrix representation of the vector (1 x Dimension).
    /// </summary>
    /// <returns>A two-dimensional array representing the vector as a row.</returns>
    public readonly T[,] ToRowMatrix()
    {
        T[,] matrix = new T[1, Dimension];

        for (int i = 0; i < Dimension; i++)
        {
            matrix[0, i] = _components[i];
        }

        return matrix;
    }

    /// <summary>
    /// Returns a matrix representing this vector as a row
    /// (equivalent to <see cref="ToRowMatrix"/>).
    /// </summary>
    /// <returns>A two-dimensional array representing the transpose as a row matrix.</returns>
    public readonly T[,] TransposeAsMatrix()
    {
        return ToRowMatrix();
    }
}
