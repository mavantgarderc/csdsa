using System.Globalization;
using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Geometric operations for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Computes the Euclidean magnitude (length) of the vector.
    /// </summary>
    /// <returns>The length of the vector.</returns>
    public readonly T Magnitude()
    {
        T sum = T.Zero;

        foreach (T c in _components)
        {
            sum += c * c;
        }

        double doubleSum = Convert.ToDouble(sum, CultureInfo.InvariantCulture);
        double root = Math.Sqrt(doubleSum);

        return T.CreateTruncating(root);
    }

    /// <summary>
    /// Returns a normalized version of the vector (unit length).
    /// </summary>
    /// <returns>A new vector with magnitude equal to one.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when attempting to normalize the zero vector.
    /// </exception>
    public readonly Vector<T> Normalize()
    {
        T mag = Magnitude();

        if (mag == T.Zero)
        {
            throw new InvalidOperationException("Cannot normalize a zero vector.");
        }

        return Scale(T.One / mag);
    }

    /// <summary>
    /// Computes the dot product of this vector with another vector.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <returns>The dot product value.</returns>
    public readonly T DotProduct(Vector<T> other)
    {
        Vector<T> self = this;

        return ValidateDimensions(
            other,
            () =>
            {
                T result = T.Zero;

                for (int i = 0; i < self.Dimension; i++)
                {
                    result += self._components[i] * other[i];
                }

                return result;
            });
    }

    /// <summary>
    /// Computes the 3D cross product of this vector with another vector.
    /// </summary>
    /// <param name="other">The other 3D vector.</param>
    /// <returns>A new vector representing the cross product.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when either vector does not have dimension 3.
    /// </exception>
    public readonly Vector<T> CrossProduct(Vector<T> other)
    {
        ValidateDimensions(3);
        other.ValidateDimensions(3);

        return new Vector<T>(
            (_components[1] * other[2]) - (_components[2] * other[1]),
            (_components[2] * other[0]) - (_components[0] * other[2]),
            (_components[0] * other[1]) - (_components[1] * other[0]));
    }

    /// <summary>
    /// Computes the distance between this vector and another vector.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <returns>The Euclidean distance between the vectors.</returns>
    public readonly T DistanceTo(Vector<T> other)
    {
        return (this - other).Magnitude();
    }

    /// <summary>
    /// Computes the angle between this vector and another vector in radians.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <returns>The angle in radians between the two vectors.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when one of the vectors is the zero vector.
    /// </exception>
    public readonly double AngleBetween(Vector<T> other)
    {
        T magProduct = Magnitude() * other.Magnitude();

        if (magProduct.Equals(T.Zero))
        {
            throw new InvalidOperationException("Cannot compute angle with zero vector.");
        }

        double dot = Convert.ToDouble(DotProduct(other), CultureInfo.InvariantCulture);
        double denom = Convert.ToDouble(magProduct, CultureInfo.InvariantCulture);

        double cosTheta = dot / denom;
        cosTheta = Math.Clamp(cosTheta, -1.0, 1.0);

        return Math.Acos(cosTheta);
    }

    /// <summary>
    /// Determines whether this vector is orthogonal to another vector within a given tolerance.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <param name="tolerance">The numeric tolerance.</param>
    /// <returns>
    /// <see langword="true"/> if the absolute dot product is less than or equal to the tolerance;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public readonly bool IsOrthogonalTo(Vector<T> other, T tolerance)
    {
        return T.Abs(DotProduct(other)) <= tolerance;
    }

    /// <summary>
    /// Determines whether this vector is parallel to another vector within a given tolerance.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <param name="tolerance">The numeric tolerance.</param>
    /// <returns>
    /// <see langword="true"/> if the vectors are parallel within the tolerance; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    public readonly bool IsParallelTo(Vector<T> other, T tolerance)
    {
        T magProduct = Magnitude() * other.Magnitude();

        if (magProduct.Equals(T.Zero))
        {
            return true;
        }

        T diff = T.Abs(T.Abs(DotProduct(other)) - magProduct);
        return diff <= tolerance;
    }

    /// <summary>
    /// Projects this vector onto a basis vector.
    /// </summary>
    /// <param name="basis">The basis vector.</param>
    /// <returns>The projection of this vector onto <paramref name="basis"/>.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="basis"/> is the zero vector.
    /// </exception>
    public readonly Vector<T> ProjectOnto(Vector<T> basis)
    {
        T basisMagSq = basis.DotProduct(basis);

        if (basisMagSq.Equals(T.Zero))
        {
            throw new ArgumentException("Cannot project onto zero vector.", nameof(basis));
        }

        T scaleFactor = DotProduct(basis) / basisMagSq;
        return basis.Scale(scaleFactor);
    }
}
