using DentalClinic.Domain.Exceptions;
using DentalClinic.Domain.ValueObjects;

namespace DentalClinic.Domain.Entities;

public class Dentist
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public Email Email { get; private set; } = null!;

    public Dentist(string name, Email email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleException($"The {nameof(name)} is required");
        }

        if (email is null)
        {
            throw new BusinessRuleException($"The {nameof(email)} is required");
        }

        Name = name;
        Email = email;
        Id = Guid.CreateVersion7();
    }

}
