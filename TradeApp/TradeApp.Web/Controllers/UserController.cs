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

        // POST: Users/Create
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

        // GET: Users/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        // GET: Users/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //POST: Users/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _userService.DeleteUserAsync(id);
            return RedirectToAction(nameof(List));
        }


        // GET: Users/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,FirstName,Lastname,Email")] User user)
        {            
            if (ModelState.IsValid)
            {
                await _userService.UpdateUserAsync(user);
                return RedirectToAction(nameof(List));
            }
            return View(user);
        }

    }
}
