
namespace CodeGator.Exceptions;

/// <summary>
/// This class represents an adpater related exception.
/// </summary>
public class AdapterException : Exception
{
    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="AdapterException"/>
    /// class.
    /// </summary>
    public AdapterException()
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="AdapterException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    /// <param name="innerException">An optional inner exception reference.</param>
    public AdapterException(
        string message,
        Exception innerException
        ) : base(message, innerException)
    {

    }

    // *******************************************************************

    /// <summary>
    /// This constructor creates a new instance of the <see cref="AdapterException"/>
    /// class.
    /// </summary>
    /// <param name="message">The message to use for the exception.</param>
    public AdapterException(
        string message
        ) : base(message)
    {

    }

    #endregion
}
