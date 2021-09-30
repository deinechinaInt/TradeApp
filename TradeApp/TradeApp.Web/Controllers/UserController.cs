using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeApp.Services;

namespace TradeApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        //GET: Users
        public async Task<IActionResult> List()
        {
            return View(await _userService.GetAllUsersAsync());
        }
        //public ViewResult List()
        //{
        //    return View(_userService.GetAllUsers());
        //}

    }
}
