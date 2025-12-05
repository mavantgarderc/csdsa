using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Csdsa.DataStructures.Vectors;

/// <summary>
/// Functional-style operations for <see cref="Vector{T}"/>.
/// </summary>
public partial struct Vector<T>
    where T : INumber<T>
{
    /// <summary>
    /// Applies a transform function to each component and returns a new vector.
    /// </summary>
    /// <param name="func">The transform function to apply to each component.</param>
    /// <returns>A new vector containing the transformed components.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="func"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null checks are preferred with nullable disabled.")]
    public readonly Vector<T> Map(Func<T, T> func)
    {
        if (func == null)
        {
            throw new ArgumentNullException(nameof(func));
        }

        return new Vector<T>(_components.Select(func).ToArray());
    }

    /// <summary>
    /// Filters components based on a predicate and returns a new vector.
    /// </summary>
    /// <param name="predicate">The predicate used to select components.</param>
    /// <returns>A new vector containing only the components that satisfy the predicate.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="predicate"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null checks are preferred with nullable disabled.")]
    public readonly Vector<T> Filter(Func<T, bool> predicate)
    {
        if (predicate == null)
        {
            throw new ArgumentNullException(nameof(predicate));
        }

        return new Vector<T>(_components.Where(predicate).ToArray());
    }

    /// <summary>
    /// Aggregates the components using a reducer function.
    /// </summary>
    /// <param name="reducer">The reducer function to apply.</param>
    /// <returns>The aggregated result.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="reducer"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null checks are preferred with nullable disabled.")]
    public readonly T Reduce(Func<T, T, T> reducer)
    {
        if (reducer == null)
        {
            throw new ArgumentNullException(nameof(reducer));
        }

        return _components.Aggregate(reducer);
    }

    /// <summary>
    /// Performs an action on each component.
    /// </summary>
    /// <param name="action">The action to perform on each component.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="action"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null checks are preferred with nullable disabled.")]
    public readonly void ForEach(Action<T> action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        foreach (T item in _components)
        {
            action(item);
        }
    }

    /// <summary>
    /// Aggregates the components into an accumulator value.
    /// </summary>
    /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
    /// <param name="seed">The initial accumulator value.</param>
    /// <param name="func">
    /// The accumulator function that combines the current accumulator and a component.
    /// </param>
    /// <returns>The final accumulated value.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="func"/> is <see langword="null"/>.
    /// </exception>
    [SuppressMessage(
        "Usage",
        "CA1510:Use ArgumentNullException.ThrowIfNull",
        Justification = "Explicit null checks are preferred with nullable disabled.")]
    public readonly TAccumulate Aggregate<TAccumulate>(
        TAccumulate seed,
        Func<TAccumulate, T, TAccumulate> func)
    {
        if (func == null)
        {
            throw new ArgumentNullException(nameof(func));
        }

        return _components.Aggregate(seed, func);
    }
}
