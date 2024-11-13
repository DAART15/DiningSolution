using DiningSolution.Domain.Enums;

namespace DiningSolution.Domain.Shared
{    
    public class Error(Status code, string message)
    {
        public static readonly Error None = new(Status.Ok, string.Empty);
        public Status Code { get; } = code;
        public string Message { get; } = message;

    }
}
