namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified polymorphic value to JSON using <see cref="SerializeToJson{T}(T)"/>.
    /// </summary>
    /// <typeparam name="T">The static type of the value to serialize.</typeparam>
    /// <param name="baseObject">The value to serialize.</param>
    /// <returns>The JSON representation of <paramref name="baseObject"/>.</returns>
    public static string SerializePolymorphic<T>(T baseObject)
    {
        return SerializeToJson(baseObject);
    }

    /// <summary>
    /// Deserializes the specified JSON string into a polymorphic instance of <typeparamref name="T"/>
    /// using <see cref="DeserializeFromJson{T}(string)"/>.
    /// </summary>
    /// <typeparam name="T">The target base type.</typeparam>
    /// <param name="json">The JSON payload.</param>
    /// <returns>An instance of <typeparamref name="T"/>.</returns>
    public static T DeserializePolymorphic<T>(string json)
    {
        return DeserializeFromJson<T>(json);
    }
}
