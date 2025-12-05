using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Advanced product operations for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Computes the outer product of this vector with another vector,
    /// producing a matrix of size <see cref="Dimension"/> x <c>other.Dimension</c>.
    /// </summary>
    /// <param name="other">The other vector used to form the outer product.</param>
    /// <returns>
    /// A two-dimensional array where the element at [i, j] is
    /// <c>this[i] * other[j]</c>.
    /// </returns>
    public readonly T[,] OuterProduct(Vector<T> other)
    {
        T[,] result = new T[Dimension, other.Dimension];

        for (int i = 0; i < Dimension; i++)
        {
            for (int j = 0; j < other.Dimension; j++)
            {
                result[i, j] = _components[i] * other[j];
            }
        }

        return result;
    }

    /// <summary>
    /// Computes the Kronecker product of this vector with another vector.
    /// </summary>
    /// <param name="other">The other vector used to form the Kronecker product.</param>
    /// <returns>
    /// A new <see cref="Vector{T}"/> whose components contain the Kronecker product.
    /// </returns>
    public readonly Vector<T> KroneckerProduct(Vector<T> other)
    {
        T[] result = new T[Dimension * other.Dimension];

        for (int i = 0; i < Dimension; i++)
        {
            for (int j = 0; j < other.Dimension; j++)
            {
                int index = (i * other.Dimension) + j;
                result[index] = _components[i] * other[j];
            }
        }

        return new Vector<T>(result);
    }
}
