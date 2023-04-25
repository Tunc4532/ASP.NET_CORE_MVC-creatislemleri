using Microsoft.AspNetCore.Mvc;
using OOP_DERS1.ORNEKLER;

namespace OOP_DERS1.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        //{
        //    Sınıf1 d = new Sınıf1();
        //    d.topla();
        //    d.carp();
        //}

        void mesagge()
        {
            ViewBag.m1 = "Bu bir metot içi masajıdır ";
            ViewBag.m2 = "Derslere Son Hız Devam";
        }
         int topla()
        {
            int s1 = 20;
            int s2 = 40;
            int sonuc = s1 + s2;
            return sonuc;
        }
        int fak(int p)
        {
            int s1 = 1;
            
            for (int i = 1; i < p; i++)
            {
                s1 = s1 * i;
            }
            return s1;
        }
        int tup(int s1, int s2)
        {
            int sonuç = s1 + s2;
            return sonuç;
        }
        public IActionResult Index()
        {
            mesagge();
            return View();
        }
        public IActionResult urunler()
        {
            mesagge();
            ViewBag.t = topla();
            ViewBag.f = fak(5);
            ViewBag.re = tup(45, 41);
            return View();
        }
       
        public IActionResult numara()
        {
            mesagge();
            return View();
        }
        public IActionResult deneme()
        {
            SEHİRLER sEHİRLER = new SEHİRLER();
            sEHİRLER.ID = 1;
            sEHİRLER.AD = "New York";
            sEHİRLER.NUFUS = 1500000;
            sEHİRLER.Ulke = "Amerika";
            ViewBag.e1 = sEHİRLER.ID;
            ViewBag.e2 = sEHİRLER.AD;
            ViewBag.e3 = sEHİRLER.NUFUS;
            ViewBag.e4 = sEHİRLER.Ulke;
                
           return View();
        }
        public IActionResult sınıfım()
        {
            SEHİRLER sEHİRLER = new SEHİRLER();
            sEHİRLER.ID = 1;
            sEHİRLER.AD = "New York";
            sEHİRLER.NUFUS = 1500000;
            sEHİRLER.Ulke = "Amerika";

            sEHİRLER.renk1 = "Mavi";
            sEHİRLER.renk2 = "Kırmzı";
            sEHİRLER.renk3 = "Beyaz";

            ViewBag.d1 = sEHİRLER.renk1;
            ViewBag.d2 = sEHİRLER.renk2;
            ViewBag.d3 = sEHİRLER.renk3;

            ViewBag.e1 = sEHİRLER.ID;
            ViewBag.e2 = sEHİRLER.AD;
            ViewBag.e3 = sEHİRLER.NUFUS;
            ViewBag.e4 = sEHİRLER.Ulke;
            return View();
        }



    }
}
