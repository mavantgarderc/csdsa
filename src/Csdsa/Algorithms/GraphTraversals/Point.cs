namespace Csdsa.Algorithms.GraphTraversal;

/// <summary>
/// Represents a point in a two-dimensional integer grid.
/// </summary>
public readonly struct Point : System.IEquatable<Point>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Point"/> struct.
    /// </summary>
    /// <param name="x">The zero-based row index.</param>
    /// <param name="y">The zero-based column index.</param>
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Gets the zero-based row index.
    /// </summary>
    public int X { get; }

    /// <summary>
    /// Gets the zero-based column index.
    /// </summary>
    public int Y { get; }

    /// <inheritdoc />
    public bool Equals(Point other) => X == other.X && Y == other.Y;

    /// <inheritdoc />
    public override bool Equals(object obj) => obj is Point other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => System.HashCode.Combine(X, Y);

    /// <summary>
    /// Determines whether two specified <see cref="Point"/> instances have the same value.
    /// </summary>
    /// <param name="left">The first point to compare.</param>
    /// <param name="right">The second point to compare.</param>
    /// <returns>
    /// <see langword="true"/> if the points are equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(Point left, Point right) => left.Equals(right);

    /// <summary>
    /// Determines whether two specified <see cref="Point"/> instances have different values.
    /// </summary>
    /// <param name="left">The first point to compare.</param>
    /// <param name="right">The second point to compare.</param>
    /// <returns>
    /// <see langword="true"/> if the points are not equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(Point left, Point right) => !left.Equals(right);
}
