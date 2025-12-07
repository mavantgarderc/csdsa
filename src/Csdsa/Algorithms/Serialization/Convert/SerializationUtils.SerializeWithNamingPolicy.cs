using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to JSON using a custom naming policy.
    /// Currently supports <see cref="JsonNamingPolicy.CamelCase"/>; other policies
    /// will result in a <see cref="NotSupportedException"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <param name="namingPolicy">The property naming policy to apply.</param>
    /// <returns>The JSON representation of <paramref name="data"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="namingPolicy"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// Thrown when <paramref name="namingPolicy"/> is not supported.
    /// </exception>
    public static string SerializeWithNamingPolicy<T>(T data, JsonNamingPolicy namingPolicy)
    {
        ArgumentNullException.ThrowIfNull(namingPolicy);

        if (ReferenceEquals(namingPolicy, JsonNamingPolicy.CamelCase))
        {
            return System.Text.Json.JsonSerializer.Serialize(data, CamelCaseJsonOptions);
        }

        throw new NotSupportedException(
            "Only JsonNamingPolicy.CamelCase is supported by SerializeWithNamingPolicy.");
    }
}
