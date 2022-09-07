using Microsoft.AspNetCore.Identity;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateAsync(SignUpModel upModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel inModel);
         Task SignOutAynac();
        List<SignUpModel> GetAllUser();
    }
}
