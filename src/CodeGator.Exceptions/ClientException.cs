
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents a client related exception.
/// </summary>
public class ClientException : Exception
{
    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ClientException"/>
    /// class.
    /// </summary>
    public ClientException()
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ClientException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public ClientException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ClientException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public ClientException(
        string message
        ) : base(message)
    {

    }

    #endregion
}
