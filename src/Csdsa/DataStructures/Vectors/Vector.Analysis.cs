using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Analytical helpers for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Determines whether this vector equals another vector within a tolerance.
    /// </summary>
    /// <param name="other">The other vector to compare with.</param>
    /// <param name="tolerance">The numeric tolerance.</param>
    /// <returns>
    /// <see langword="true"/> if the vectors are equal within the tolerance; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    public readonly bool Equals(Vector<T> other, T tolerance)
    {
        if (Dimension != other.Dimension)
        {
            return false;
        }

        for (int i = 0; i < Dimension; i++)
        {
            if (T.Abs(_components[i] - other[i]) > tolerance)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Determines whether this vector is approximately the zero vector
    /// within a specified tolerance.
    /// </summary>
    /// <param name="tolerance">The numeric tolerance.</param>
    /// <returns>
    /// <see langword="true"/> if all components are within the tolerance of zero;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public readonly bool IsZeroVector(T tolerance)
    {
        return _components.All(x => T.Abs(x) <= tolerance);
    }

    /// <summary>
    /// Determines whether this vector is approximately a unit vector
    /// within a specified tolerance.
    /// </summary>
    /// <param name="tolerance">The numeric tolerance.</param>
    /// <returns>
    /// <see langword="true"/> if the magnitude is within the tolerance of one;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public readonly bool IsUnitVector(T tolerance)
    {
        return T.Abs(T.One - Magnitude()) <= tolerance;
    }

    /// <summary>
    /// Determines whether any components are NaN (for <see cref="double"/> or <see cref="float"/>).
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if at least one component is NaN; otherwise, <see langword="false"/>.
    /// </returns>
    public readonly bool HasNaNs()
    {
        return _components.Any(
            x =>
                (x is double d && double.IsNaN(d)) ||
                (x is float f && float.IsNaN(f)));
    }

    /// <summary>
    /// Determines whether any components are infinite (for <see cref="double"/> or <see cref="float"/>).
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if at least one component is infinite; otherwise, <see langword="false"/>.
    /// </returns>
    public readonly bool HasInfinities()
    {
        return _components.Any(
            x =>
                (x is double d && double.IsInfinity(d)) ||
                (x is float f && float.IsInfinity(f)));
    }
}
