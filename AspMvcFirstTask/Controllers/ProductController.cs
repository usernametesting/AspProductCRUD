using AspMvcFirstTask.MyDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AspMvcFirstTask.Controllers
{
    public class ProductController : Controller
    {

        // GET: ProductController
        public ActionResult Index() =>

             View(ProductDb.products);



        // GET: ProductController/Create
        public ActionResult Create() =>
            View();


        // POST: ProductController/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return View(product);

            product.Id = Guid.NewGuid();
            ProductDb.products.Add(product);
            return RedirectToAction(nameof(Index));
        }


        // GET: ProductController/Edit/5
        public ActionResult Edit(string id)
        {
            var product = ProductDb.products.FirstOrDefault(pro => pro.Id.ToString() == id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]

        public ActionResult Edit(string id, Product product)
        {
            var pro = ProductDb.products.FirstOrDefault(item=>item.Id.ToString()==id);
            pro.Name = product.Name;
            pro.Description = product.Description;
            pro.Price = product.Price;
            pro.Category = product.Category;
            return RedirectToAction(nameof(Index));
        }




        // POST: ProductController/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            ProductDb.products.
                Remove(ProductDb.products.FirstOrDefault(pro => pro.Id.ToString() == id)!);
            return RedirectToAction(nameof(Index));
        }
    }
}
