using E_Com_Entities;
using E_Com_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloth_Sample.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryService service = new CategoryService();


        [HttpGet]
        // GET: Category
        public ActionResult Index()
        {
            IList<Category> categories = service.GetCategory();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            service.SaveCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {

            var cat = service.GetCategoryById(ID);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            service.UpdateCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var Category = service.GetCategoryById(ID);
            return View(Category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            var cat = service.GetCategoryById(category.ID);
            service.DeleteCategory(cat);
            return RedirectToAction("Index");
        }
    }
}