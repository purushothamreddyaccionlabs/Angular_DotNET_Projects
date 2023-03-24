using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{ 
    public class UsersdataController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersdataController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Usersdata> objUsersList = _db.UsersData;
            return View(objUsersList);
        }
        //get
        public IActionResult Create()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usersdata objuser)
        {
            if (objuser.FirstName == objuser.LastName)
            {
                ModelState.AddModelError("firstname", "The lastName cannot exactly match the FirstName.");
            }
            if (ModelState.IsValid)
            {
                _db.UsersData.Add(objuser);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objuser);
        }
            
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var userFromDb = _db.UsersData.Find(id);
            if(userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Usersdata objuser)
        {
            if (objuser.FirstName == objuser.LastName)
            {
                ModelState.AddModelError("firstname", "The lastName cannot exactly match the FirstName.");
            }
            if (ModelState.IsValid)
            {
                _db.UsersData.Update(objuser);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objuser);
        }

        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var delId = _db.UsersData.Find(id);
            if(delId == null)
            {
                return NotFound();
            }
            return View(delId);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.UsersData.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.UsersData.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       


    }

}
