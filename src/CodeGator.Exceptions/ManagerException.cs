
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents a manager related exception.
/// </summary>
public class ManagerException : Exception
{
    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ManagerException"/>
    /// class.
    /// </summary>
    public ManagerException()
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ManagerException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public ManagerException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="ManagerException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public ManagerException(
        string message
        ) : base(message)
    {

    }

    #endregion
}
