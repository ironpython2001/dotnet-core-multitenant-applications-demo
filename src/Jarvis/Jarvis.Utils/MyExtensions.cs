using FluentValidation.Results;
using Jarvis.DTOs;

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

}