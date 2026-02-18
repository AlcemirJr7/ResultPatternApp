using System.Net;

namespace ResultPatternApp.AppResults;

public sealed record ErrorDetails(
    string Type,
    string Message,
    HttpStatusCode StatusCode = HttpStatusCode.BadRequest);
