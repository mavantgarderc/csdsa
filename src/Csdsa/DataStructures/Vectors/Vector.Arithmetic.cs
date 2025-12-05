using System.Globalization;
using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Arithmetic and geometric transformations for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Adds two vectors component-wise.
    /// </summary>
    /// <param name="a">The first vector to add.</param>
    /// <param name="b">The second vector to add.</param>
    /// <returns>A new vector representing the component-wise sum.</returns>
    public static Vector<T> operator +(Vector<T> a, Vector<T> b)
    {
        return a.Add(b);
    }

    /// <summary>
    /// Subtracts two vectors component-wise.
    /// </summary>
    /// <param name="a">The vector to subtract from.</param>
    /// <param name="b">The vector to subtract.</param>
    /// <returns>A new vector representing the component-wise difference.</returns>
    public static Vector<T> operator -(Vector<T> a, Vector<T> b)
    {
        return a.Subtract(b);
    }

    /// <summary>
    /// Adds another vector to this vector component-wise.
    /// </summary>
    /// <param name="other">The vector to add.</param>
    /// <returns>A new vector representing the component-wise sum.</returns>
    public readonly Vector<T> Add(Vector<T> other)
    {
        return BinaryOp(other, (x, y) => x + y);
    }

    /// <summary>
    /// Subtracts another vector from this vector component-wise.
    /// </summary>
    /// <param name="other">The vector to subtract.</param>
    /// <returns>A new vector representing the component-wise difference.</returns>
    public readonly Vector<T> Subtract(Vector<T> other)
    {
        return BinaryOp(other, (x, y) => x - y);
    }

    /// <summary>
    /// Scales this vector by a scalar factor.
    /// </summary>
    /// <param name="scalar">The scalar factor.</param>
    /// <returns>A new vector whose components are scaled by <paramref name="scalar"/>.</returns>
    public readonly Vector<T> Scale(T scalar)
    {
        return Map(x => x * scalar);
    }

    /// <summary>
    /// Computes the Hadamard (element-wise) product with another vector.
    /// </summary>
    /// <param name="other">The vector to multiply element-wise.</param>
    /// <returns>A new vector whose components are the element-wise products.</returns>
    public readonly Vector<T> HadamardProduct(Vector<T> other)
    {
        return BinaryOp(other, (x, y) => x * y);
    }

    /// <summary>
    /// Negates this vector (unary minus).
    /// </summary>
    /// <returns>A new vector whose components are the negated components of this vector.</returns>
    public readonly Vector<T> Negate()
    {
        return Scale(-T.One);
    }

    /// <summary>
    /// Clamps each component to the inclusive range [<paramref name="min"/>, <paramref name="max"/>].
    /// </summary>
    /// <param name="min">The minimum allowed component value.</param>
    /// <param name="max">The maximum allowed component value.</param>
    /// <returns>A new vector with each component clamped to the specified range.</returns>
    public readonly Vector<T> Clamp(T min, T max)
    {
        return Map(
            x =>
            {
                if (x < min)
                {
                    return min;
                }

                if (x > max)
                {
                    return max;
                }

                return x;
            });
    }

    /// <summary>
    /// Returns a vector whose components are the absolute values of this vector's components.
    /// </summary>
    /// <returns>A new vector with absolute-valued components.</returns>
    public readonly Vector<T> Abs()
    {
        return Map(T.Abs);
    }

    /// <summary>
    /// Applies non-uniform scaling along three axes (3D only).
    /// </summary>
    /// <param name="x">The scale factor along the X axis.</param>
    /// <param name="y">The scale factor along the Y axis.</param>
    /// <param name="z">The scale factor along the Z axis.</param>
    /// <returns>A new scaled 3D vector.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the vector dimension is not 3.
    /// </exception>
    public readonly Vector<T> ScaleNonUniform(T x, T y, T z)
    {
        ValidateDimensions(3);

        return new Vector<T>(
            _components[0] * x,
            _components[1] * y,
            _components[2] * z);
    }

    /// <summary>
    /// Rotates a 2D vector by the specified angle in radians.
    /// </summary>
    /// <param name="angleRadians">The rotation angle in radians.</param>
    /// <returns>A new vector representing the rotated 2D vector.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the vector dimension is not 2.
    /// </exception>
    public readonly Vector<T> Rotate2D(double angleRadians)
    {
        ValidateDimensions(2);

        double cos = Math.Cos(angleRadians);
        double sin = Math.Sin(angleRadians);

        double x = Convert.ToDouble(_components[0], CultureInfo.InvariantCulture);
        double y = Convert.ToDouble(_components[1], CultureInfo.InvariantCulture);

        double newX = (cos * x) - (sin * y);
        double newY = (sin * x) + (cos * y);

        return new Vector<T>(
            T.CreateTruncating(newX),
            T.CreateTruncating(newY));
    }

    /// <summary>
    /// Rotates a 3D vector around the specified axis by the given angle in radians.
    /// </summary>
    /// <param name="axis">The axis to rotate around, which will be normalized.</param>
    /// <param name="angleRadians">The rotation angle in radians.</param>
    /// <returns>A new vector representing the rotated 3D vector.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the vector dimension is not 3.
    /// </exception>
    public readonly Vector<T> Rotate3D(Vector<T> axis, double angleRadians)
    {
        ValidateDimensions(3);
        axis = axis.Normalize();

        double cos = Math.Cos(angleRadians);
        double sin = Math.Sin(angleRadians);
        double oneMinusCos = 1.0 - cos;

        double ux = Convert.ToDouble(axis[0], CultureInfo.InvariantCulture);
        double uy = Convert.ToDouble(axis[1], CultureInfo.InvariantCulture);
        double uz = Convert.ToDouble(axis[2], CultureInfo.InvariantCulture);

        double x = Convert.ToDouble(_components[0], CultureInfo.InvariantCulture);
        double y = Convert.ToDouble(_components[1], CultureInfo.InvariantCulture);
        double z = Convert.ToDouble(_components[2], CultureInfo.InvariantCulture);

        double dot = (ux * x) + (uy * y) + (uz * z);

        double rx = (x * cos) + (((uy * z) - (uz * y)) * sin) + (ux * dot * oneMinusCos);
        double ry = (y * cos) + (((uz * x) - (ux * z)) * sin) + (uy * dot * oneMinusCos);
        double rz = (z * cos) + (((ux * y) - (uy * x)) * sin) + (uz * dot * oneMinusCos);

        return new Vector<T>(
            T.CreateTruncating(rx),
            T.CreateTruncating(ry),
            T.CreateTruncating(rz));
    }

    /// <summary>
    /// Reflects this vector across a given normal vector.
    /// </summary>
    /// <param name="normal">The normal vector to reflect across.</param>
    /// <returns>The reflected vector.</returns>
    public readonly Vector<T> ReflectAcross(Vector<T> normal)
    {
        T two = T.CreateChecked(2);
        T factor = (two * DotProduct(normal)) / normal.DotProduct(normal);
        return this - normal.Scale(factor);
    }

    /// <summary>
    /// Translates this vector by another vector.
    /// </summary>
    /// <param name="translation">The translation vector.</param>
    /// <returns>The translated vector.</returns>
    public readonly Vector<T> Translate(Vector<T> translation)
    {
        return this + translation;
    }

    /// <summary>
    /// Applies a shear transformation to a 2D vector.
    /// </summary>
    /// <param name="xShear">The shear factor along the X axis.</param>
    /// <param name="yShear">The shear factor along the Y axis.</param>
    /// <returns>A new vector representing the sheared 2D vector.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the vector dimension is not 2.
    /// </exception>
    public readonly Vector<T> Shear(double xShear, double yShear)
    {
        ValidateDimensions(2);

        double x = Convert.ToDouble(_components[0], CultureInfo.InvariantCulture);
        double y = Convert.ToDouble(_components[1], CultureInfo.InvariantCulture);

        double newX = x + (xShear * y);
        double newY = y + (yShear * x);

        return new Vector<T>(
            T.CreateTruncating(newX),
            T.CreateTruncating(newY));
    }
}
