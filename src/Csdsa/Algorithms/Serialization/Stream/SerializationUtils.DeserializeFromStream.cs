using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Deserializes JSON from the specified stream to an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="stream">The source stream.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="stream"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when deserialization returns <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromStream<T>(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);

        T result = JsonSerializer.Deserialize<T>(stream, DefaultJsonOptions);
        if (result == null)
        {
            throw new InvalidOperationException("Deserialization produced a null result.");
        }

        return result;
    }
}
