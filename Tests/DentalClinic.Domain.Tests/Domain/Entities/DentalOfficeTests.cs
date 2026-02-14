using DentalClinic.Domain.Entities;
using DentalClinic.Domain.Exceptions;

namespace DentalClinic.Domain.Tests.Domain.Entities;

[TestClass]
public class DentalOfficeTests
{
    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_NullName_Throws()
    {
        new DentalOffice(null!);
    }

}
