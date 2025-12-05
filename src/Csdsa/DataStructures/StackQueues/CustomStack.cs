using System.Diagnostics.CodeAnalysis;

namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Represents a simple generic stack implementation backed by a <see cref="List{T}"/>.
/// </summary>
[SuppressMessage(
    "Usage",
    "CA1510:Use ArgumentNullException.ThrowIfNull",
    Justification = "Explicit null checks are preferred with nullable disabled.")]
public partial class CustomStackUtils<T>
{
    private readonly List<T> _list = new List<T>();

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomStackUtils{T}"/> class.
    /// </summary>
    public CustomStackUtils()
    {
    }
}
