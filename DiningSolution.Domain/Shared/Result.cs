namespace DiningSolution.Domain.Shared
{
    public class Result<T>(bool isSuccess, Error error, T value) where T : class
    {
        public bool IsSuccess { get; } = isSuccess;
        public bool IsFailure => !IsSuccess;
        public Error Error { get; } = error;
        public T Value { get; } = value;
        public static Result<T> Success(T value) => new(true, Error.None, value );
        public static Result<T> Failure(Error error) => new(false, error, default!);
    }
}
