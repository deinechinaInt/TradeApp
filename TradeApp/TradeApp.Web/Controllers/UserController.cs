using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TradeApp.Domain;
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
        public async Task<IActionResult> List(string sortOrder, string filterString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (filterString != null)
            {
                pageNumber = 1;
            }
            else
            {
                filterString = currentFilter;
            }

            ViewData["CurrentFilter"] = filterString;

            var pageSize = 3;
            return View(await _userService.GetAllUsersReadyAsync(sortOrder, filterString, pageNumber ?? 1, pageSize));
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,Lastname,Email")] User user)
        {           
                if (ModelState.IsValid)
                {
                user = await _userService.AddUserAsync(user);
                    return RedirectToAction(nameof(List));
                }            
            return View(user);
        }
    }
}
