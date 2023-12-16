namespace DesafioBlazor.Data.SharedContext;

public static class Const
{
    public const string LengthMessage = "{0} precisa ter menos de {1} caracteres";
    public const string RequiredMessage = "{0} não pode ser vazio";
    public const string OnlyNumbersMessage = "O campo {0} deve conter somente números";
    public const string OnlyLettersMessage = "O campo {0} deve conter somente letras";
    public const string OnlyNumbersExpression = @"^[0-9]+$";
    public const string OnlyStringAndWhiteSpaceExpression = @"^[a-zA-Z ]+$";
}