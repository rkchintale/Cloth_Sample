using E_Com_Entities;
using E_Com_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloth_Sample.Controllers
{
    public class ProductController : Controller
    {
        ProductService service = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = service.GetProduct();
            if (string.IsNullOrEmpty(search)==false)
            {
                products = products.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            service.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
    }
}