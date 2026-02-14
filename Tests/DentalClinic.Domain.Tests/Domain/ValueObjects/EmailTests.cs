using DentalClinic.Domain.Exceptions;
using DentalClinic.Domain.ValueObjects;

namespace DentalClinic.Domain.Tests.Domain.ValueObjects;

[TestClass]
public class EmailTests
{
    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_NullEmail_Throws()
    {
        new Email(null!);
    }

    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_EmailWithoutAt_Throws()
    {
        new Email("felipe.com");
    }

    [TestMethod]
    public void Constructor_ValidEmail_NoExceptions()
    {
        new Email("felipe@example.com");
    }
}
