namespace Csdsa.DataStructures.StackQueues;

/// <summary>
/// Provides internal helper methods for <see cref="TwoStackQueueUtils{T}"/>.
/// </summary>
public partial class TwoStackQueueUtils<T>
{
    /// <summary>
    /// Transfers elements from the input stack to the output stack when needed.
    /// </summary>
    private void Transfer()
    {
        if (_output.Count == 0)
        {
            while (_input.Count > 0)
            {
                _output.Push(_input.Pop());
            }
        }
    }
}
