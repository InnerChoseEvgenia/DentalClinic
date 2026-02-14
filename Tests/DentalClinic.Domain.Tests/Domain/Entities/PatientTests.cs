using DentalClinic.Domain.Entities;
using DentalClinic.Domain.Exceptions;
using DentalClinic.Domain.ValueObjects;

namespace DentalClinic.Domain.Tests.Domain.Entities;

[TestClass]
public class PatientTests
{
    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_NullName_Throws()
    {
        var email = new Email("felipe@example.com");
        var patient=new Patient(null!, email);
        Assert.ThrowsException<BusinessRuleException>(()=> patient);
    }

    [TestMethod]
    [ExpectedException(typeof(BusinessRuleException))]
    public void Constructor_NullEmail_Throws()
    {
        new Patient("Felipe", email: null!);
    }

    [TestMethod]
    public void Constructor_ValidPatient_NoExceptions()
    {
        var email = new Email("felipe@example.com");
        new Patient("Felipe", email);
    }
}
