using System.Globalization;
using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Statistical operations for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Computes the arithmetic mean of the vector components.
    /// </summary>
    /// <returns>The arithmetic mean of the components, or <c>T.Zero</c> if empty.</returns>
    public readonly T Mean()
    {
        if (_components.Length == 0)
        {
            return T.Zero;
        }

        T sum = T.Zero;

        foreach (T item in _components)
        {
            sum += item;
        }

        return sum / T.CreateChecked(_components.Length);
    }

    /// <summary>
    /// Computes the median of the vector components.
    /// </summary>
    /// <returns>The median component value, or <c>T.Zero</c> if empty.</returns>
    public readonly T Median()
    {
        if (_components.Length == 0)
        {
            return T.Zero;
        }

        T[] sorted = _components
            .OrderBy(x => x)
            .ToArray();

        int mid = sorted.Length / 2;

        if (sorted.Length % 2 != 0)
        {
            return sorted[mid];
        }

        return (sorted[mid - 1] + sorted[mid]) / T.CreateChecked(2);
    }

    /// <summary>
    /// Computes the mode (most frequent value) of the vector components.
    /// </summary>
    /// <returns>
    /// The most frequent component value. If there are multiple, the first by
    /// grouping order is returned.
    /// </returns>
    public readonly T Mode()
    {
        return _components
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;
    }

    /// <summary>
    /// Computes the variance of the vector components.
    /// </summary>
    /// <returns>The variance of the components.</returns>
    public readonly double Variance()
    {
        double mean = Convert.ToDouble(Mean(), CultureInfo.InvariantCulture);

        return _components
            .Average(
                x =>
                {
                    double v = Convert.ToDouble(x, CultureInfo.InvariantCulture);
                    double diff = v - mean;
                    return diff * diff;
                });
    }

    /// <summary>
    /// Computes the standard deviation of the vector components.
    /// </summary>
    /// <returns>The standard deviation of the components.</returns>
    public readonly double StandardDeviation()
    {
        return Math.Sqrt(Variance());
    }

    /// <summary>
    /// Performs z-score normalization and returns a new <see cref="Vector{Double}"/>.
    /// </summary>
    /// <returns>A new vector of z-scores corresponding to each component.</returns>
    public readonly Vector<double> ZScoreNormalize()
    {
        double mean = Convert.ToDouble(Mean(), CultureInfo.InvariantCulture);
        double std = StandardDeviation();

        double[] normalized = _components
            .Select(
                x =>
                {
                    double v = Convert.ToDouble(x, CultureInfo.InvariantCulture);
                    return std != 0.0 ? (v - mean) / std : 0.0;
                })
            .ToArray();

        return new Vector<double>(normalized);
    }

    /// <summary>
    /// Returns the minimum component, or <c>default(T)</c> when the vector is empty.
    /// </summary>
    /// <returns>The minimum component value, or <c>default(T)</c> if empty.</returns>
    public readonly T Min()
    {
        if (_components.Length == 0)
        {
            return default;
        }

        return _components.Min();
    }

    /// <summary>
    /// Returns the maximum component, or <c>default(T)</c> when the vector is empty.
    /// </summary>
    /// <returns>The maximum component value, or <c>default(T)</c> if empty.</returns>
    public readonly T Max()
    {
        if (_components.Length == 0)
        {
            return default;
        }

        return _components.Max();
    }

    /// <summary>
    /// Returns the range of the components (max - min),
    /// or <c>default(T)</c> when the vector is empty.
    /// </summary>
    /// <returns>The range of component values, or <c>default(T)</c> if empty.</returns>
    public readonly T Range()
    {
        if (_components.Length == 0)
        {
            return default;
        }

        T min = _components.Min();
        T max = _components.Max();

        return max - min;
    }

    /// <summary>
    /// Computes the covariance between this vector and another vector.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <returns>The covariance value between the two vectors.</returns>
    public readonly double Covariance(Vector<T> other)
    {
        Vector<T> self = this;

        return ValidateDimensions(
            other,
            () =>
            {
                double meanX = Convert.ToDouble(self.Mean(), CultureInfo.InvariantCulture);
                double meanY = Convert.ToDouble(other.Mean(), CultureInfo.InvariantCulture);
                double sum = 0.0;

                for (int i = 0; i < self.Dimension; i++)
                {
                    double x = Convert.ToDouble(self[i], CultureInfo.InvariantCulture) - meanX;
                    double y = Convert.ToDouble(other[i], CultureInfo.InvariantCulture) - meanY;
                    sum += x * y;
                }

                return sum / self.Dimension;
            });
    }

    /// <summary>
    /// Computes the Pearson correlation coefficient between this vector
    /// and another vector.
    /// </summary>
    /// <param name="other">The other vector.</param>
    /// <returns>The correlation coefficient between the two vectors.</returns>
    public readonly double Correlation(Vector<T> other)
    {
        return Covariance(other) / (StandardDeviation() * other.StandardDeviation());
    }
}
