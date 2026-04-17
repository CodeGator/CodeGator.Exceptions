
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents an API related exception.
/// </summary>
public class ApiException : Exception
{
    /// <summary>
    /// This constructor initializes a new instance of the <see cref="ApiException"/> class.
    /// </summary>
    public ApiException()
    {

    }

    /// <summary>
    /// This constructor initializes a new instance of the <see cref="ApiException"/> class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public ApiException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    /// <summary>
    /// This constructor initializes a new instance of the <see cref="ApiException"/> class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public ApiException(
        string message
        ) : base(message)
    {

    }

}
