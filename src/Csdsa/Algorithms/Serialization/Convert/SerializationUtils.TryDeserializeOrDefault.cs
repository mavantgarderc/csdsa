using System.Text.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Attempts to deserialize the specified JSON string into an instance of <typeparamref name="T"/>.
    /// Returns the provided fallback value if deserialization fails due to JSON parsing errors
    /// or unsupported types.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="json">The JSON payload.</param>
    /// <param name="fallback">The value to return if deserialization fails.</param>
    /// <returns>
    /// The deserialized value, or <paramref name="fallback"/> if deserialization fails.
    /// </returns>
    public static T TryDeserializeOrDefault<T>(string json, T fallback = default)
    {
        try
        {
            return DeserializeFromJson<T>(json);
        }
        catch (JsonException)
        {
            return fallback;
        }
        catch (NotSupportedException)
        {
            return fallback;
        }
    }
}
