using Microsoft.AspNetCore.Identity;
using Yuksi.Domain;

namespace Yuksi.WebAPI.Middlewares;

public static class ExtensionsMiddleware
{
    public static void CreateFirstUser(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            if (!userManager.Users.Any(p => p.UserName == "admin"))
            {
                AppUser user = new()
                {
                    UserName = "admin",
                    Email = "admin@example.com",
                    FirstName = "Rıdvan Berat",
                    LastName = "Calis",
                    EmailConfirmed = true
                };

                userManager.CreateAsync(user, "123456").Wait();
            }
        }
    }
}
