namespace Csdsa.Algorithms.Serialization.Json;

/// <summary>
/// Provides helpers for Base64-encoding and decoding JSON-based payloads.
/// </summary>
public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to a Base64-encoded UTF-8 JSON string.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>A Base64-encoded JSON payload.</returns>
    public static string SerializeToBase64<T>(T data)
    {
        byte[] bytes = SerializeToBytes(data);
        return Convert.ToBase64String(bytes);
    }

    /// <summary>
    /// Deserializes a Base64-encoded UTF-8 JSON string into an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="base64">The Base64-encoded JSON payload.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="base64"/> is <see langword="null"/>.
    /// </exception>
    public static T DeserializeFromBase64<T>(string base64)
    {
        ArgumentNullException.ThrowIfNull(base64);

        byte[] bytes = Convert.FromBase64String(base64);
        return DeserializeFromBytes<T>(bytes);
    }
}
