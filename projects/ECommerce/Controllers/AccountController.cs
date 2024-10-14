using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    // Add Register Modelerr
    // Add Validate Token 
    
    public class AccountController:Controller
    {
         public UserManager<UserModel> _userManager;
        public SignInManager<UserModel>_signInManager;

        public AccountController(UserManager<UserModel> userManager , SignInManager<UserModel> signManager)
        {
            _signInManager = _signInManager;
            _userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register( RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new UserModel{ Name = model.Username , Email = model.Email};
                var result = await _userManager.CreateAsync(user , model.Password);
                if(result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent:false );
                    return RedirectToAction("Index" , "Home");
                }
                foreach(var er in result.Errors)
                {
                    ModelState.AddModelError(string.Empty , er.Description);
                }
            }
            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email , model.Password , model.RememberMe , lockoutOnFailure:false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index" , "Home");
                }
                ModelState.AddModelError(" " , "Log in is Invalid");
            }
            return View(model);
        }
        public async Task<IActionResult>Signout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index" , "Home");
        }
        
        

    }
}