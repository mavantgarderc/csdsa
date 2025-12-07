using System.Text.Json;
using System.Text.Json.Serialization;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Deserializes the specified JSON string to an instance of <typeparamref name="T"/>
    /// using the provided JSON converters.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="json">The JSON payload.</param>
    /// <param name="converters">The converters to register in the options.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="json"/> or <paramref name="converters"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when deserialization returns <see langword="null"/>.
    /// </exception>
    public static T DeserializeWithConverters<T>(
        string json,
        IEnumerable<JsonConverter> converters)
    {
        ArgumentNullException.ThrowIfNull(json);
        ArgumentNullException.ThrowIfNull(converters);

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        foreach (JsonConverter converter in converters)
        {
            options.Converters.Add(converter);
        }

        T result = JsonSerializer.Deserialize<T>(json, options);
        if (result == null)
        {
            throw new InvalidOperationException("Deserialization produced a null result.");
        }

        return result;
    }
}
