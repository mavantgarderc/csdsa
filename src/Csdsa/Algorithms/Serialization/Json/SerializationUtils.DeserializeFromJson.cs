using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Deserializes the specified JSON string to an instance of <typeparamref name="T"/>
    /// using <see cref="DefaultJsonOptions"/>.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="json"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when deserialization returns <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromJson<T>(string json)
    {
        ArgumentNullException.ThrowIfNull(json);

        T result = JsonSerializer.Deserialize<T>(json, DefaultJsonOptions);
        if (result == null)
        {
            throw new InvalidOperationException("Deserialization produced a null result.");
        }

        return result;
    }
}
