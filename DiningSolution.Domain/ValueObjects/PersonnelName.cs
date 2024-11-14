using DiningSolution.Domain.Errors;
using DiningSolution.Domain.Primitives;
using DiningSolution.Domain.Shared;
using DiningSolution.Domain.Constants;

namespace DiningSolution.Domain.ValueObjects
{
    public sealed class PersonnelName(string value) : ValueObject
    {
        public string Value { get; } = value;

        public static Result<PersonnelName> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Result.Failure<PersonnelName>(DomainErrors.PersonnelNameEmty);
            }
            if(value.Length > DomainConstants.PersonnelNameMaxLength)
            {
                return Result.Failure<PersonnelName>(DomainErrors.PersonnelNameToLong);
            }
            return new PersonnelName(value);
        }
        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
