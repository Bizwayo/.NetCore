using Microsoft.AspNetCore.Mvc;
using TestBookWeb.Data;
using TestBookWeb.Models;

namespace TestBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        //variable to link to database that is connected using the container (DbContext) in Program.cs
        private readonly ApplicationDbContext _db;

        //Constructor used to create object with variable _db and link it to DbContext
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //Get List of all elements inside the Categories table 
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
