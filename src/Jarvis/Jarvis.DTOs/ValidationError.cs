namespace Jarvis.DTOs;

public record ValidationError
{
    
    public string? ErrorCode { get; init; }
    public string? ErrorMessage { get; init; }
    public string? PropertyName { get; init; }

    public ValidationError(string errorCode, string errorMessage, string propertyName)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
        PropertyName = propertyName;
    }

}