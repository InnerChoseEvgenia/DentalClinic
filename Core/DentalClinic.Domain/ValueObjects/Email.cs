using DentalClinic.Domain.Exceptions;

namespace DentalClinic.Domain.ValueObjects;

public record Email
{
    public string Value { get; } = null!;

    public Email(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new BusinessRuleException($"The {nameof(email)} is required");
        }

        if (!email.Contains("@"))
        {
            throw new BusinessRuleException($"The {nameof(email)} is not valid");
        }

        Value = email;

    }
}
