using System.Runtime.CompilerServices;

namespace Csdsa.Algorithms.StreamProccessing;

public static partial class StreamProcessing
{
    /// <summary>
    /// Asynchronously projects each element of the async sequence into a new form.
    /// </summary>
    /// <typeparam name="T">The source element type.</typeparam>
    /// <typeparam name="TResult">The result element type.</typeparam>
    /// <param name="source">The async sequence whose elements to transform.</param>
    /// <param name="selector">A transform function to apply to each element.</param>
    /// <param name="cancellationToken">The cancellation token used to cancel the asynchronous operation.</param>
    /// <returns>
    /// An async sequence whose elements are the result of invoking the transform function
    /// on each element of the source sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="source"/> or <paramref name="selector"/> is <see langword="null"/>.
    /// </exception>
    public static async IAsyncEnumerable<TResult> MapAsync<T, TResult>(
        this IAsyncEnumerable<T> source,
        Func<T, TResult> selector,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(selector);

        await foreach (T item in source.WithCancellation(cancellationToken))
        {
            yield return selector(item);
        }
    }
}
