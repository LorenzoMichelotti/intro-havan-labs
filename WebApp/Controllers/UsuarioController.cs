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
        List<Usuario> listaUsuarios = new List<Usuario>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            Usuario u1 = new Usuario("Lorenzo", "Michelotti", 20, "lomichelotti@hotmail.com", "Brusque");
            listaUsuarios.Add(u1);
            return View(listaUsuarios);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            listaUsuarios.Add(model);
            return RedirectToAction("List");
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details()
        {
            //Usuario model = new Usuario("Lorenzo", "Michelotti", 20, "lomichelotti@hotmail.com", "Brusque");
            //listaUsuarios.Add(model);
            //return View(model);
            return View();
        }
    }
}