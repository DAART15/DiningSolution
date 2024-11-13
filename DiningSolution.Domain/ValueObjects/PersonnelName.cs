﻿using DiningSolution.Domain.Errors;
using DiningSolution.Domain.Primitives;
using DiningSolution.Domain.Shared;

namespace DiningSolution.Domain.ValueObjects
{
    public sealed class PersonnelName(string value) : ValueObject
    {
        public string Value { get; } = value;

        public static Result<PersonnelName> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Result<PersonnelName>.Failure(DomainErrors.PersonnelNameEmty);
            }
            if(value.Length > 50)//<<< contant padaryti
            {
                return Result<PersonnelName>.Failure(DomainErrors.PersonnelNameToLong);
            }
            return Result<PersonnelName>.Success( new PersonnelName(value));
        }
        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}