using DiningSolution.Domain.Constants;
using DiningSolution.Domain.Primitives;
using DiningSolution.Domain.Shared;

namespace DiningSolution.Domain.ValueObjects
{
    public sealed class PersonnelID(int value) : ValueObject
    {
        public int Value { get; } = value;

        public static Result<PersonnelID> Create()
        {
            var random = new Random();
            var value1 = random.Next(DomainConstants.PersonnelIDFirstTwoDigitsStart, DomainConstants.PersonnelIDFirstTwoDigitsFinish);
            var value2 = random.Next(DomainConstants.PersonnelIDLastThreeDigitsStart, DomainConstants.PersonnelIDLastThreeDigitsFinish);
            var stringValue = value1.ToString() + value2.ToString();
            return new PersonnelID(int.Parse(stringValue));
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
