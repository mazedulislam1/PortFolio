using BdA.SocialNetwork.Web.Models;
using BdA.SocialNetWork.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BdA.SocialNetwork.Web.Controllers
{

    public class PostController : Controller
    {
        private readonly UserManager<SocialUser> _userManager;

        public PostController(UserManager<SocialUser> userManager)
        {
            _userManager = userManager;
        }
        // GET: PostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("Post/create")]
        public async Task<ActionResult> Create(UserPostModel model)
        {
            //Request.QueryString
            var user = await _userManager.GetUserAsync(User);
            model.UserId = user.Id;
            if (ModelState.IsValid)
            {
                model.CreatePost();
            }
            
            return RedirectToAction("Index", "Home");
        }



        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
