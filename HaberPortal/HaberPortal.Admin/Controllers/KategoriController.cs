using HaberPortal.Core.Infrastructure;
using HaberPortal.Core.Repository;
using HaberPortal.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortal.Admin.Controllers
{
    public class KategoriController : Controller
    {

        #region Kategori
        private readonly IKategoriRepository _kategoriRepository;
        public KategoriController(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }
        #endregion
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();

        }
        [HttpPost]
        public JsonResult Ekle(Kategori kategori)
        {
            return Json(1,JsonRequestBehavior.AllowGet);

        }
    }
}