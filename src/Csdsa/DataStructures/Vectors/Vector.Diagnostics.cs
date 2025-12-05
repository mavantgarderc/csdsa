using System.Diagnostics;
using System.Globalization;
using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Diagnostic and debugging helpers for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Benchmarks repeated magnitude computations and writes the elapsed time to the console.
    /// </summary>
    /// <param name="iterations">The number of iterations to run.</param>
    public readonly void BenchmarkOperations(int iterations = 1_000_000)
    {
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < iterations; i++)
        {
            _ = Magnitude();
        }

        sw.Stop();
        Console.WriteLine(
            "Magnitude x " + iterations + ": " + sw.ElapsedMilliseconds + "ms");
    }

    /// <summary>
    /// Returns a formatted string of components with a fixed precision.
    /// </summary>
    /// <param name="precision">The number of fractional digits to display.</param>
    /// <returns>A formatted string representing the vector components.</returns>
    public readonly string ToDebugString(int precision = 4)
    {
        string format = "F" + precision.ToString(CultureInfo.InvariantCulture);

        return string.Join(
            ", ",
            _components.Select(
                x => Math.Round(
                         Convert.ToDouble(x, CultureInfo.InvariantCulture),
                         precision)
                     .ToString(format, CultureInfo.InvariantCulture)));
    }

    /// <summary>
    /// Writes the string representation of the vector to the console.
    /// </summary>
    public readonly void DumpToConsole()
    {
        Console.WriteLine(ToString());
    }

    /// <inheritdoc />
    public override readonly string ToString()
    {
        return "Vector<" + typeof(T).Name + ">[" + string.Join(", ", _components) + "]";
    }

    /// <summary>
    /// Visualizes the components as a simple ASCII bar chart.
    /// </summary>
    /// <param name="maxWidth">The maximum width, in characters, of the bar.</param>
    public readonly void VisualizeAsBarChart(int maxWidth = 50)
    {
        if (_components.Length == 0)
        {
            return;
        }

        double max = Convert.ToDouble(Max(), CultureInfo.InvariantCulture);
        double min = Convert.ToDouble(Min(), CultureInfo.InvariantCulture);
        double range = max - min;

        if (range == 0.0)
        {
            range = 1.0;
        }

        foreach (T value in _components)
        {
            double val = Convert.ToDouble(value, CultureInfo.InvariantCulture);
            double normalized = (val - min) / range;
            int width = (int)(normalized * maxWidth);

            Console.WriteLine(new string('■', width));
        }
    }

    /// <summary>
    /// Computes a hash-based checksum of the vector components.
    /// </summary>
    /// <returns>An integer representing the checksum value.</returns>
    public readonly int Checksum()
    {
        HashCode hash = default;

        foreach (T item in _components)
        {
            hash.Add(item);
        }

        return hash.ToHashCode();
    }
}
