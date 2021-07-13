using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioRepository repository = new UsuarioRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(repository.ReadAll());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            repository.Create(model);
            return RedirectToAction("List");
        }

        public ActionResult Update(int id)
        {
            return View(repository.ReadById(id));
        }
        [HttpPost]
        public ActionResult Update(Usuario model)
        {
            repository.Update(model);
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            return View(repository.ReadById(id));
        }
        [HttpPost]
        public ActionResult Details(Usuario model)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View(repository.ReadById(id));
        }
        [HttpPost]
        public ActionResult Delete(Usuario model)
        {
            repository.Delete(model);
            return RedirectToAction("List");
        }
    }
}