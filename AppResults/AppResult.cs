using System.Net;

namespace ResultPatternApp.AppResults;

public readonly record struct AppResult(
    bool IsSuccess,
    HttpStatusCode StatusCode,
    ErrorDetails? Error = null) : IAppResult
{
    public bool IsFailure => !IsSuccess;
    public DateTime Timestamp { get; init; } = DateTime.Now;

    public static AppResult Success()
        => new(true, HttpStatusCode.OK);

    public static AppResult SuccessCreated()
        => new(true, HttpStatusCode.Created);

    public static AppResult Failure(ErrorDetails error)
        => new(false, error.StatusCode, error);

    public static AppResult<T> Success<T>(T data)
        => new(data, true, HttpStatusCode.OK);
        
    public static AppResult<T> SuccessCreated<T>(T data)
        => new(data, true, HttpStatusCode.Created);
}

public readonly record struct AppResult<TData>(
    TData? Data,
    bool IsSuccess,
    HttpStatusCode StatusCode,
    ErrorDetails? Error = null) : IAppResult
{
    public bool IsFailure => !IsSuccess;
    public DateTime Timestamp { get; init; } = DateTime.Now;

    public static AppResult<TData> Success(TData data)
        => new(data, true, HttpStatusCode.OK);

    public static AppResult<TData> SuccessCreated(TData data)
        => new(data, true, HttpStatusCode.Created);

    public static AppResult<TData> Failure(ErrorDetails? error)
        => new(default, false, error!.StatusCode, error);

    public static implicit operator AppResult<TData>(TData? data)
        => Success(data!);

    public static implicit operator AppResult<TData>(ErrorDetails? error)
        => Failure(error);
}
