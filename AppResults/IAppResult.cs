using System.Net;

namespace ResultPatternApp.AppResults;

public interface IAppResult
{
    bool IsSuccess { get; }
    HttpStatusCode StatusCode { get; }
    ErrorDetails? Error { get; }
    DateTime Timestamp { get; }
}
