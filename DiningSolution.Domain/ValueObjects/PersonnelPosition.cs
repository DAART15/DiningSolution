﻿using DiningSolution.Domain.Constants;
using DiningSolution.Domain.Errors;
using DiningSolution.Domain.Primitives;
using DiningSolution.Domain.Shared;

namespace DiningSolution.Domain.ValueObjects
{
    public sealed class PersonnelPosition(string value) : ValueObject
    {
        public string Value { get; } = value;

        public static Result<PersonnelPosition> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Result.Failure<PersonnelPosition>(DomainErrors.PersonnelPositionEmpty);
            }
            if (value != DomainConstants.Waiter && value != DomainConstants.Administration)
            {
                return Result.Failure<PersonnelPosition>(DomainErrors.PersonnelPositionIllegal);
            }            
            return new PersonnelPosition(value);
        }
        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
