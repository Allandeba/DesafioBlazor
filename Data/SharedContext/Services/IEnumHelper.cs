using System.ComponentModel.DataAnnotations;

namespace DesafioBlazor.Data.SharedContext.Services;

public static class EnumHelper
{
    public static string GetEnumDisplayName(Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var displayAttribute = field?.GetCustomAttributes(typeof(DisplayAttribute), false)
                                     .OfType<DisplayAttribute>()
                                     .FirstOrDefault();

        return displayAttribute?.Name ?? value.ToString();
    }
}