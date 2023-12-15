using System.ComponentModel.DataAnnotations;
using DesafioBlazor.Data.SharedContext;

namespace DesafioBlazor.Data.Models;

public class IBGE
{
    [Required(ErrorMessage = Const.RequiredMessage)]
    [Display(Name = "Código")]
    [MaxLength(7, ErrorMessage = Const.LengthMessage)]
    [RegularExpression(Const.OnlyNumbersExpression, ErrorMessage = Const.OnlyNumbersMessage)]
    public string Id { get; set; } = string.Empty;
    
    [Required(ErrorMessage = Const.RequiredMessage)]
    [Display(Name = "Estado")]
    [MaxLength(2, ErrorMessage = Const.LengthMessage)]
    [RegularExpression(Const.OnlyStringAndWhiteSpaceExpression, ErrorMessage = Const.OnlyLettersMessage)]
    public string  State { get; set; } = string.Empty;

    [Required(ErrorMessage = Const.RequiredMessage)]
    [Display(Name = "Cidade")]
    [MaxLength(80, ErrorMessage = Const.LengthMessage)]
    [RegularExpression(Const.OnlyStringAndWhiteSpaceExpression, ErrorMessage = Const.OnlyLettersMessage)]
    public string City { get; set; } = string.Empty;
}