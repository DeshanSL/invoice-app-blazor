namespace Invoicing.Domain;

public readonly struct Result<TValue, TError> where TError : Error
{
    public TValue? Value { get; }
    public TError? Error { get; }
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;

    private Result(TValue value)
    {
        Value = value;
        Error = default;
        IsSuccess = true;
    }
    private Result(TError error)
    {
        Error = error;
        Value = default;
        IsSuccess = false;
    }
    public static implicit operator Result<TValue, TError>(TValue value) => new Result<TValue, TError>(value);
    public static implicit operator Result<TValue, TError>(TError error) => new Result<TValue, TError>(error);

    public static Result<TValue, TError> Failure(TError error) => new Result<TValue, TError>(error);
    public static Result<TValue, TError> Success(TValue value) => new Result<TValue, TError>(value);

}

public readonly struct Result<TValue>
{
    public TValue? Value { get; }
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error? ErrorType { get; }


    private Result(TValue value)
    {
        Value = value;
        ErrorType = default;
        IsSuccess = true;
    }
    public Result(Error error)
    {
        ErrorType = error;
        Value = default;
        IsSuccess = false;
    }

    public static implicit operator Result<TValue>(TValue value) => new Result<TValue>(value);

    public static implicit operator Result<TValue>(Error error) => new Result<TValue>(error);


    public static Result<TValue> Success(TValue value) => new Result<TValue>(value);
    public static Result<TValue> Failure(Error error) => new Result<TValue>(error);

}
