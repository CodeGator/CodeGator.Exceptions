
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents a service related exception.
/// </summary>
public class ServiceException : Exception
{
    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ServiceException"/>
    /// class.
    /// </summary>
    public ServiceException()
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ServiceException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public ServiceException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ServiceException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public ServiceException(
        string message
        ) : base(message)
    {

    }

    #endregion
}
