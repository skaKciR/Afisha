﻿using Afisha.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Afisha.Service;
using System.Web;
using MimeKit;
using MailKit.Net.Smtp;

namespace Afisha.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.UserName, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync(user.Email, "Подтверждение регистрации на сайте Afishes.ru", "Здравствуйте, " + user.UserName+"." +" Благодарим за регистрацию на сайте afishes.ru!" + "\r\n" + "Для завершения регистрации перейдите по ссылке: " + "https://localhost:7176/Account/ConfirmEmail?id=" + user.Id);
                    // установка куки

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        public async Task<ActionResult> ConfirmEmail(string id)
        {
            IdentityUser user = await userManager.FindByIdAsync(id);
                    user.EmailConfirmed = true;
                    await userManager.UpdateAsync(user);
                    await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
        }
        [Authorize]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }
        [Authorize]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    if (user.EmailConfirmed == true)
                    {
                        await signInManager.SignOutAsync();
                        Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                        {
                            return Redirect(model.returnUrl ?? "/");
                        }
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "BadLogin");
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [Authorize]
        public async Task<IActionResult> Profile()
        {

            return View();
        }
    }
}