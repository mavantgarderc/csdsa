namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Projects each element of the sequence into a new form.
    /// </summary>
    /// <typeparam name="T">The source element type.</typeparam>
    /// <typeparam name="TResult">The result element type.</typeparam>
    /// <param name="source">The sequence whose elements to transform.</param>
    /// <param name="selector">A transform function to apply to each element.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> whose elements are the result of invoking the transform function.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="selector"/> is <see langword="null"/>.
    /// </exception>
    public static IEnumerable<TResult> Map<T, TResult>(
        this IEnumerable<T> source,
        Func<T, TResult> selector)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(selector);

        foreach (T item in source)
        {
            yield return selector(item);
        }
    }
}
