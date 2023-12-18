using Microsoft.AspNetCore.Identity;
using DesafioBlazor.Data;

namespace DesafioBlazor.Components.Account;

internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
{
    public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Erro: Não é possível carregar usuário com ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }
}
