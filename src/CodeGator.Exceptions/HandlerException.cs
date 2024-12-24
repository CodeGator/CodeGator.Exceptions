
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents a handler related exception.
/// </summary>
public class HandlerException : Exception
{
    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="HandlerException"/>
    /// class.
    /// </summary>
    public HandlerException()
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="HandlerException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public HandlerException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="HandlerException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public HandlerException(
        string message
        ) : base(message)
    {

    }

    #endregion
}
