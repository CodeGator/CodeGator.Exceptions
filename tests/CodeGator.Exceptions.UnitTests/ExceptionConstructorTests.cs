namespace CodeGator.Exceptions.UnitTests;

/// <summary>
/// This class verifies constructor behavior for CodeGator exception types.
/// </summary>
/// <remarks>
/// Exercises each concrete exception type in this package using
/// <see cref="DynamicDataAttribute"/> rows from <see cref="ExceptionTypes"/>.
/// </remarks>
[TestClass]
public sealed class ExceptionConstructorTests
{
    /// <summary>
    /// This property supplies exception types used as rows for dynamic test data.
    /// </summary>
    public static IEnumerable<object[]> ExceptionTypes =>
    [
        [typeof(ApiException)],
        [typeof(ClientException)],
        [typeof(ConfigurationException)],
        [typeof(DirectorException)],
        [typeof(HandlerException)],
        [typeof(ManagerException)],
        [typeof(ProviderException)],
        [typeof(ServiceException)],
    ];

    /// <summary>
    /// This method verifies parameterless construction returns the expected type.
    /// </summary>
    /// <param name="exceptionType">The concrete exception type to construct.</param>
    [TestMethod]
    [DynamicData(nameof(ExceptionTypes))]
    public void Parameterless_ctor_creates_instance_of_expected_type(Type exceptionType)
    {
        var instance = Activator.CreateInstance(exceptionType);

        Assert.IsNotNull(instance);
        Assert.IsInstanceOfType(instance, exceptionType);
        Assert.IsInstanceOfType(instance, typeof(Exception));
    }

    /// <summary>
    /// This method verifies the message-only constructor sets Exception.Message.
    /// </summary>
    /// <remarks>
    /// Calls the <c>(string message)</c> constructor and compares <see cref="Exception.Message"/>.
    /// </remarks>
    /// <param name="exceptionType">The concrete exception type to construct.</param>
    [TestMethod]
    [DynamicData(nameof(ExceptionTypes))]
    public void Message_ctor_sets_Message(Type exceptionType)
    {
        const string message = "test message";

        var ex = (Exception)Activator.CreateInstance(exceptionType, message)!;

        Assert.AreEqual(message, ex.Message);
    }

    /// <summary>
    /// This method verifies message-plus-inner construction assigns both members.
    /// </summary>
    /// <remarks>
    /// Calls <c>(string message, Exception innerException)</c> and checks
    /// <see cref="Exception.Message"/> and <see cref="Exception.InnerException"/>.
    /// </remarks>
    /// <param name="exceptionType">The concrete exception type to construct.</param>
    [TestMethod]
    [DynamicData(nameof(ExceptionTypes))]
    public void Message_and_inner_ctor_sets_Message_and_InnerException(Type exceptionType)
    {
        const string message = "outer message";
        var inner = new InvalidOperationException("inner message");

        var ex = (Exception)Activator.CreateInstance(exceptionType, message, inner)!;

        Assert.AreEqual(message, ex.Message);
        Assert.AreSame(inner, ex.InnerException);
    }
}
