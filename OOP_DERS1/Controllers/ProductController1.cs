using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OOP_DERS1.ENTİTY1;
using OOP_DERS1.projeCONTEXT;

namespace OOP_DERS1.Controllers
{
    public class ProductController1 : Controller
    {

       Contex context = new Contex();
        //LİSTELEME İŞLEMİ
        public IActionResult Index()
        {
            var values = context.products.ToList(); 
            return View(values);
        }
        //EKLEME İŞLEMİ
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //SİLME İŞLEMİ
        public IActionResult DeleteProduct(int id)
        {
            var value = context.products.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");   
        }
        //GÜNCELLEME İŞLEMİ
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.products.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var value = context.products.Where(x => x.Id ==p.Id).FirstOrDefault();
            value.Name= p.Name;
            value.Stock= p.Stock;
            value.price = p.price;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
