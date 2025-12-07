using Newtonsoft.Json;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Creates a deep clone of the specified object by serializing and deserializing it
    /// using Newtonsoft.Json with default settings.
    /// </summary>
    /// <typeparam name="T">The type of the object to clone.</typeparam>
    /// <param name="data">The object to clone.</param>
    /// <returns>A deep clone of <paramref name="data"/>.</returns>
    public static T DeepClone<T>(T data)
    {
        string json = JsonConvert.SerializeObject(data);
        return JsonConvert.DeserializeObject<T>(json)!;
    }
}
