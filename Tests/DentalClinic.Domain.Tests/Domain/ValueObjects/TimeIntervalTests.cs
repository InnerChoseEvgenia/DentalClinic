using DentalClinic.Domain.Exceptions;
using DentalClinic.Domain.ValueObjects;

namespace DentalClinic.Domain.Tests.Domain.ValueObjects;

[TestClass]
public class TimeIntervalTests
{
    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_StartIsAfterEnd_Throws()
    {
        new TimeInterval(DateTime.UtcNow, DateTime.UtcNow.AddDays(-1));
    }

    [TestMethod]
    public void Constructor_ValidTimeInterval_NoExceptions()
    {
        new TimeInterval(DateTime.UtcNow, DateTime.UtcNow.AddHours(1));
    }
}
