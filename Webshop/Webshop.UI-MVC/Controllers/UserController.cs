using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Webshop.UI_MVC.Models;

namespace Webshop.UI_MVC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext context;

        public UserController()
        {
            context = new ApplicationDbContext();
        }

        public UserController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        //
        // GET: /User/Register
        [Authorize(Roles = "Admin")]
        public ActionResult Register()
        {
            ViewBag.Name = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                .ToList(), "Name", "Name");
            return View();
        }

        //
        // POST: /User/Register
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model, Webshop.BL.EmailService service)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //  Comment the following line to prevent log in until the user is confirmed.
                    //await SignInManager.SignInAsync(user, isPersistent:false, rememberBrowser:false);

                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    service.SendMail(user.Email, user.Id, "Confirm your account",
                        "Please confirm your account by clicking " + callbackUrl);
                    //await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    //Assign Role to user Here       
                    await this.UserManager.AddToRoleAsync(user.Id, model.UserRoles);

                    ViewBag.Message = "Check your email and confirm your account, you must be confirmed "
                                      + "before you can log in.";

                    return View("Info");
                    //return RedirectToAction("Index", "Home");
                }
                ViewBag.Name = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                    .ToList(), "Name", "Name");
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}