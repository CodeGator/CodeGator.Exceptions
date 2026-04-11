namespace CodeGator.Exceptions.UnitTests;

/// <summary>
/// Verifies constructor behavior for all <see cref="CodeGator.Exceptions"/> exception types.
/// </summary>
[TestClass]
public sealed class ExceptionConstructorTests
{
    /// <summary>
    /// Exception types under test (one row per type for <see cref="DynamicDataAttribute"/>).
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
    /// Parameterless constructor yields an instance of the concrete exception type.
    /// </summary>
    /// <param name="exceptionType">The exception type to construct.</param>
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
    /// <c>(string message)</c> constructor sets <see cref="Exception.Message"/>.
    /// </summary>
    /// <param name="exceptionType">The exception type to construct.</param>
    [TestMethod]
    [DynamicData(nameof(ExceptionTypes))]
    public void Message_ctor_sets_Message(Type exceptionType)
    {
        const string message = "test message";

        var ex = (Exception)Activator.CreateInstance(exceptionType, message)!;

        Assert.AreEqual(message, ex.Message);
    }

    /// <summary>
    /// <c>(string message, Exception innerException)</c> sets message and inner exception.
    /// </summary>
    /// <param name="exceptionType">The exception type to construct.</param>
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
