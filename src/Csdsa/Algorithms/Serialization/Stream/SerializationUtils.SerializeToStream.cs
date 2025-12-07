using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to the provided stream as JSON.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <param name="stream">The target stream.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="stream"/> is <see langword="null"/>.
    /// </exception>
    public static void SerializeToStream<T>(T data, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);

        JsonSerializer.Serialize(stream, data, DefaultJsonOptions);
    }
}
