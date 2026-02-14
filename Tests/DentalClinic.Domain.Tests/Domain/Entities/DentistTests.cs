using DentalClinic.Domain.Entities;
using DentalClinic.Domain.Exceptions;
using DentalClinic.Domain.ValueObjects;

namespace DentalClinic.Domain.Tests.Domain.Entities;

[TestClass]
public class DentistTests
{
    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_NullName_Throws()
    {
        var email = new Email("felipe@example.com");
        new Dentist(null!, email);
    }

    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_NullEmail_Throws()
    {
        new Dentist("Felipe", email: null!);
    }

    [TestMethod]
    public void Constructor_ValidDentist_NoExceptions()
    {
        var email = new Email("felipe@example.com");
        new Dentist("Felipe", email);
    }

}
