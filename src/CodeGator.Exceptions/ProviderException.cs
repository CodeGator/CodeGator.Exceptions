
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents a provider related exception.
/// </summary>
public class ProviderException : Exception
{
    /// <summary>
    /// This constructor initializes a new instance of the <see cref="ProviderException"/> class.
    /// </summary>
    public ProviderException()
    {

    }

    /// <summary>
    /// This constructor initializes a new instance of the <see cref="ProviderException"/> class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public ProviderException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    /// <summary>
    /// This constructor initializes a new instance of the <see cref="ProviderException"/> class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public ProviderException(
        string message
        ) : base(message)
    {

    }

}
