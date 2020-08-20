using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Totti",
                    Email = "Totti10@gmail.com",
                    UserName = "Totti10@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Franccesco",
                        LastName = "Totti",
                        Street = "Derbi del Capital",
                        City = "Roma",
                        State = "Rome",
                        ZipCode = "101624"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
     }
}