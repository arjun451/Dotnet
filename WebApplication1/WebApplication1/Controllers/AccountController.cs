using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountController(IAccountRepository accountRepository ,IWebHostEnvironment webHostEnvironment)
        {
            _accountRepository = accountRepository;
             _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel upModel)
        {
            if (upModel.ProfileImage != null)
            {
                string folder = "ProfileImage/" + Guid.NewGuid().ToString() + "_" + upModel.ProfileImage.FileName;
                upModel.ProfileImageUrl ="/"+ folder;
                string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);
                await upModel.ProfileImage.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            }
        //    if (ModelState.IsValid)
       //     {
               
                var result = await _accountRepository.CreateAsync(upModel);
                if(!result.Succeeded)
                {
                    foreach(var errorMessame in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessame.Description);
                    }
                }
                ModelState.Clear();
         //   }
            return View();
        }


        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  SignIn(SignInModel inModel)
        {
            if(ModelState.IsValid)
            {
                var result = await _accountRepository.PasswordSignInAsync(inModel);
               if(result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
                ModelState.AddModelError("", "Invalid credentials");
            }
            return View();
        }
        
        public async Task <IActionResult> Logout()
        {
          await  _accountRepository.SignOutAynac();
            return RedirectToAction("Index","Home");
        }

        [Authorize]
        public IActionResult GetAllUser()
        {
            var data = _accountRepository.GetAllUser();
            return View(data);
        }

    }
}
