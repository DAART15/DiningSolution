using DiningSolution.Domain.Enums;

namespace DiningSolution.Domain.Shared
{    
    public class Error(Status code, string message)
    {
        public static readonly Error None = new(Status.Ok, string.Empty);
        public static readonly Error NullValue = new(Status.Internal_Server_Error, "The specified result value is null.");
        public Status Code { get; } = code;
        public string Message { get; } = message;

    }
}
