using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Csdsa.Algorithms.Serialization.Json;

public static partial class SerializationUtils
{
    /// <summary>
    /// Gets the default JSON serialization options used by this module.
    /// Includes fields and writes indented JSON.
    /// </summary>
    public static JsonSerializerOptions DefaultJsonOptions { get; } =
        new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };

    /// <summary>
    /// Gets the JSON serialization options that ignore null values when writing.
    /// </summary>
    public static JsonSerializerOptions IgnoreNullsJsonOptions { get; } =
        new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

    /// <summary>
    /// Gets JSON serialization options that use camelCase property naming.
    /// </summary>
    public static JsonSerializerOptions CamelCaseJsonOptions { get; } =
        new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

    /// <summary>
    /// Gets Newtonsoft.Json serializer settings configured to include
    /// private and compiler-generated members for diagnostics and deep cloning.
    /// </summary>
    public static JsonSerializerSettings NewtonsoftPrivateSerializerSettings { get; } =
        new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new DefaultContractResolver
            {
                SerializeCompilerGeneratedMembers = true,
            },
        };
}
