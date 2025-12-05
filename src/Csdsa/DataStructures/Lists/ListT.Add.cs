namespace Csdsa.DataStructures.Lists;

/// <summary>
/// Provides the <see cref="Add{T}(ICollection{T}, T)"/> method
/// for adding elements to a collection.
/// </summary>
public static partial class ListT
{
    /// <summary>
    /// Adds an element to the end of the specified collection.
    /// </summary>
    /// <typeparam name="T">The element type of the collection.</typeparam>
    /// <param name="collection">The collection to which the element will be added.</param>
    /// <param name="item">The element to add.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="collection"/> is <see langword="null"/>.
    /// </exception>
    public static void Add<T>(ICollection<T> collection, T item)
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        collection.Add(item);
    }
}
