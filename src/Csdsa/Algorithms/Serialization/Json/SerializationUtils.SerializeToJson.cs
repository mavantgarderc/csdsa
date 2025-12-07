using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to a JSON string using <see cref="DefaultJsonOptions"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value to serialize.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>The JSON representation of <paramref name="data"/>.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the serialization unexpectedly returns <see langword="null"/>.
    /// </exception>
    public static string SerializeToJson<T>(T data)
    {
        string json = JsonSerializer.Serialize(data, DefaultJsonOptions);
        if (json == null)
        {
            throw new InvalidOperationException("Serialization produced a null result.");
        }

        return json;
    }
}
