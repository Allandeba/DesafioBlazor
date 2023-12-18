using System.ComponentModel.DataAnnotations;

namespace DesafioBlazor.Data.SharedContext;

public static class Enums
{
    public enum SearchType
    {
        [Display(Name = "Código")]
        Code,
        [Display(Name = "Cidade")]
        City,
        [Display(Name = "Estado")]
        State
    }
}