﻿using DiningSolution.Domain.Enums;
using DiningSolution.Domain.Shared;

namespace DiningSolution.Domain.Errors
{
    public static class DomainErrors
    {
        public static Error PersonnelNameEmty => new(Status.Bad_Request, "Personnel name cannot be empty.");
        public static Error PersonnelNameToLong => new(Status.Bad_Request, "Personnel name cannot be more than 50 characters.");
        public static Error PersonnelPositionEmpty => new(Status.Bad_Request, "Personnel position cannot be empty.");
        public static Error PersonnelPositionIllegal => new(Status.Bad_Request, "The staff position cannot be other than a waiter or administrative position.");
    }
}
