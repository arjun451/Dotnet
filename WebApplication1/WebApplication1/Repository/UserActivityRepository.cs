using Microsoft.AspNetCore.Identity;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Repository
{
    public class UserActivityRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly UserService _userService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public UserActivityRepository(UserManager<ApplicationUser> userManager, ApplicationDbContext db, UserService userService, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _db = db;
            _userService = userService;
            _signInManager = signInManager;
        }
        //public async void Addfollow(int id)
        //{
        //    var uresid = _userService.GetUserId();
        //    var user = await _userManager.FindByIdAsync(uresid);
        //    var toFollowUser = await _userManager.FindByIdAsync(id.ToString());
        //    var follow = new UserFollow()
        //    {
        //        Id = uresid,
        //        FollowUserName = toFollowUser.FirstName,
        //        FallowUserProfileUrl = toFollowUser.ProfileImageUrl
        //    };
        //}
    }
}
