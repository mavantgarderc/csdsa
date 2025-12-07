namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to a JSON string, ignoring properties with null values.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>
    /// A JSON representation of <paramref name="data"/> where null-valued properties are omitted.
    /// </returns>
    public static string SerializeIgnoreNulls<T>(T data)
    {
        return System.Text.Json.JsonSerializer.Serialize(data, IgnoreNullsJsonOptions);
    }
}
