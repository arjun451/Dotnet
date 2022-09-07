using Microsoft.AspNetCore.Identity;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountRepository(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
      public  async Task<IdentityResult> CreateAsync(SignUpModel upModel)
        {
            var user = new ApplicationUser()
            {
                Email = upModel.Email,
                UserName = upModel.Email,
                FirstName = upModel.FirstName,
                LastName = upModel.LastName,
              //  CountryOfRedience = upModel.CountryOfRedsidence,
                PhoneNumber = upModel.ContactNumber,
                ProfileImageUrl = upModel.ProfileImageUrl
            };
            var result = await _userManager.CreateAsync(user, upModel.Password);
            return result;
        }
        public async Task<SignInResult> PasswordSignInAsync(SignInModel inModel)
        {
         var result =   await  _signInManager.PasswordSignInAsync(inModel.Email, inModel.Password, true, false);
            return result;
        }
        public async Task SignOutAynac()
        {
            await _signInManager.SignOutAsync();
        }
        public  List<SignUpModel> GetAllUser()
        { 
             var users = new List<SignUpModel>();
            var  data = _userManager.Users.ToList();
            if(data.Count > 0)
            {
                foreach (var user in data)
                {
                    users.Add(new SignUpModel()
                    {
                        FirstName = user.FirstName,
                        LastName= user.LastName,
                        ProfileImageUrl =user.ProfileImageUrl,
                        Email = user.Email,

                    });

                }
            }
            return users;

        }
    }

}
