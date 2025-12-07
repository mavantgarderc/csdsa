using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value using the provided JSON converters.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <param name="converters">The converters to register in the options.</param>
    /// <returns>The JSON representation of <paramref name="data"/>.</returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="converters"/> is <see langword="null"/>.
    /// </exception>
    public static string SerializeWithConverters<T>(
        T data,
        IEnumerable<JsonConverter> converters)
    {
        ArgumentNullException.ThrowIfNull(converters);

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        foreach (JsonConverter converter in converters)
        {
            options.Converters.Add(converter);
        }

        return JsonSerializer.Serialize(data, options);
    }
}
