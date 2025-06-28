using Microsoft.Extensions.Logging;

namespace HuanskyFW.Exceptions;

public class BusinessException : Exception,
    IBusinessException,
    IHasErrorCode,
    IHasErrorDetails,
    IHasLogLevel
{
    public BusinessException(
        string? code = null,
        string? message = null,
        string? details = null,
        Exception? innerException = null,
        LogLevel logLevel = Microsoft.Extensions.Logging.LogLevel.Warning)
        : base(message, innerException)
    {
        this.Code = code;
        this.Details = details;
        this.LogLevel = logLevel;
    }

    public string? Code { get; set; }

    public string? Details { get; set; }

    public LogLevel? LogLevel { get; set; }
}
