using Microsoft.AspNetCore.Mvc;
using Film.Models.DTO;
using Film.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace Film.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authService;
        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }
        /* We will create a user with admin rights, after that we are going
          to comment this method because we need only
          one user in this application 
          If you need other users ,you can implement this registration method with view
          I have create a complete tutorial for this, you can check the link in description box
         */

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await authService.LoginAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["msg"] = "Could not logged in..";
                return RedirectToAction(nameof(Login));
            }
        }

        //public async Task<IActionResult> RegisterAdmin()
        //{
        //    RegistrationModel model = new RegistrationModel
        //    {
        //        Username = "admin",
        //        Email = "admin@gmail.com",
        //        Name = "Paweł",
        //        Password = "Admin@123",
        //        PasswordConfirm = "Admin@123"
        //    };
        //    model.Role = "admin";
        //    var result = await this.authService.RegisterAsync(model);
        //    return Ok(result);

        //}
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (!ModelState.IsValid) { return View(model); }
            model.Role = "user";
            var result = await this.authService.RegisterAsync(model);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

        //public async Task<IActionResult> Reg()
        //{
        //    var model = new RegistrationModel
        //    {
        //        Email = "pawel@gmail.com",
        //        Username = "admin",
        //        Name = "Paweł",
        //        Password = "Admin@123",
        //        PasswordConfirm = "Admin@123",

        //    };
        //    model.Role = "admin";
        //    var result = await authService.RegisterAsync(model);
        //    return Ok(result);
        //}



    }
}
