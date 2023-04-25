using Microsoft.AspNetCore.Mvc;
using OOP_DERS1.ENTİTY1;
using OOP_DERS1.projeCONTEXT;

namespace OOP_DERS1.Controllers
{
    public class CoustumerController : Controller
    {
        //context ten nesne türetiyoruz veri tabanına etki edbilmek için
        Contex context = new Contex();

        //listeleme
        public IActionResult Index()
        {
            var values = context.coustemers.ToList();
            return View(values);
        }
        //ekleme
        [HttpGet]
        public IActionResult AddCoustemer()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddCoustemer(coustemer p)
        {
            if(p.Name.Length>=3 && p.City !=" " && p.City.Length >=3)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
           
        }
        //silme işlemi
        public IActionResult DeleteCoustemer(int id)
        {
            var value = context.coustemers.Where(x=>x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //GÜNCELLEME İŞLEMİ 
        [HttpGet]
        public IActionResult UpdateCoustemer(int id)
        {
            var value = context.coustemers.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCoustemer(coustemer p)
        {
            var value = context.coustemers.Where(x => x.Id == p.Id).FirstOrDefault();
            value.Name = p.Name;
            value.City = p.City;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }


}


