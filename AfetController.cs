using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AfetKayit1.Models.Entity;


namespace AfetKayit1.Controllers
{
    public class AfetController : Controller
    {
        Afet_kayitEntities db = new Afet_kayitEntities();

        // GET: Afet
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AfetListele()
        {

            var afet = db.AfetDB.ToList();
            return View(afet);
        }
        [HttpGet]
        public ActionResult YeniAfet()
        {
            List<SelectListItem> degerafet = (from a in db.Afet_turDB.ToList()
                                            select new SelectListItem
                                            {
                                                Text=a.afet_tur_adi,
                                                Value=a.afet_tur_id.ToString()
                                            }
                                            
                                            ).ToList();
            ViewBag.dgrafet = degerafet;

            List<SelectListItem> degeril = (from i in db.iller.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.il,
                                                Value = i.il_id.ToString()
                                            }).ToList();
            ViewBag.dgril = degeril;
            return View();
        }
        [HttpPost]
        public ActionResult YeniAfet(AfetDB afetekle)
        {
            var aftur = db.Afet_turDB.Where(a => a.afet_tur_id == afetekle.Afet_turDB.afet_tur_id).FirstOrDefault();
            afetekle.Afet_turDB = aftur;
            var aftil = db.iller.Where(i => i.il_id == afetekle.iller.il_id).FirstOrDefault();
            afetekle.iller = aftil;

            db.AfetDB.Add(afetekle);
            db.SaveChanges();

            return RedirectToAction("AfetListele");
        }
        public ActionResult AfetSil(int id)
        {
            var aftsil = db.AfetDB.Find(id);
            db.AfetDB.Remove(aftsil);
            db.SaveChanges();

            return RedirectToAction("AfetListele");
        }
        
        public ActionResult AfetGetir(int id)
        {
            var afetgtr = db.AfetDB.Find(id);
            List<SelectListItem> degraft = (from a in db.Afet_turDB.ToList()
                                            select new SelectListItem
                                            {
                                                Text = a.afet_tur_adi,
                                                Value = a.afet_tur_id.ToString()

                                            }).ToList();

            ViewBag.aftdgr = degraft;


            List<SelectListItem> degril = (from i in db.iller.ToList()
                                           select new SelectListItem
                                           {

                                               Text = i.il,
                                               Value = i.il_id.ToString()

                                           }).ToList();

            ViewBag.dgril = degril;


            return View("AfetGetir",afetgtr);
        }

        public ActionResult AfetGuncelle(AfetDB afttguncelle)
        {
            var aftgnc = db.AfetDB.Find(afttguncelle.afet_id);
            aftgnc.seri_no = afttguncelle.seri_no;
            aftgnc.glide_no = afttguncelle.glide_no;
            aftgnc.baslangic_tarih = afttguncelle.baslangic_tarih;
            aftgnc.bitis_tarih = afttguncelle.bitis_tarih;
            aftgnc.neden = afttguncelle.neden;
            aftgnc.neden_aciklama = afttguncelle.neden_aciklama;
            aftgnc.etkilendigi_alan = afttguncelle.etkilendigi_alan;
            aftgnc.kaynak = afttguncelle.kaynak;

            var aft = db.Afet_turDB.Where(a => a.afet_tur_id == afttguncelle.Afet_turDB.afet_tur_id).FirstOrDefault();
            aftgnc.afet_tur_id = aft.afet_tur_id;
            var ill = db.iller.Where(i => i.il_id == afttguncelle.iller.il_id).FirstOrDefault();
            aftgnc.il_id = ill.il_id;

            db.SaveChanges();
            return RedirectToAction("AfetListele");
        }
    }
}