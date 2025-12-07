using Newtonsoft.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Serializes the specified value to JSON using Newtonsoft.Json,
    /// including private and compiler-generated members for diagnostics.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="data">The value to serialize.</param>
    /// <returns>
    /// A JSON representation of <paramref name="data"/> that includes
    /// private and compiler-generated members.
    /// </returns>
    public static string SerializeIncludingPrivate<T>(T data)
    {
        return JsonConvert.SerializeObject(data, NewtonsoftPrivateSerializerSettings);
    }
}
