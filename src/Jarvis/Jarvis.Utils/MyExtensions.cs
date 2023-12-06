using FluentValidation.Results;
using Jarvis.DTOs;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Jarvis.Utils;

public static class MyExtensions
{
    public static List<ValidationError>? ToDto(this ValidationResult vr)
    {
        if (vr.IsValid == false)
        {
            var result = (from i in vr.Errors
                          select
                          new ValidationError(i.ErrorCode, i.ErrorMessage, i.PropertyName))
                          .ToList();
            return result;
        }
        else
            return null;
    }

    public static void MyLogMessage(this ILogger myLogger, LogLevel logLevel, string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
    {
        myLogger.Log(logLevel, $"{memberName},{sourceFilePath},{sourceLineNumber},{message}");
    }

}