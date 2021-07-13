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
        UsuarioRepository userRepository = new UsuarioRepository();
        productRepository productRepository = new productRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(userRepository.ReadAll());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            userRepository.Create(model);
            return RedirectToAction("List");
        }

        public ActionResult Update(int id)
        {
            return View(userRepository.ReadById(id));
        }
        [HttpPost]
        public ActionResult Update(Usuario model)
        {
            userRepository.Update(model);
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            return View(userRepository.ReadById(id));
        }
        [HttpPost]
        public ActionResult Details(Usuario model)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View(userRepository.ReadById(id));
        }
        [HttpPost]
        public ActionResult Delete(Usuario model)
        {
            userRepository.Delete(model);
            return RedirectToAction("List");
        }


        //PRODUTOS
        public ActionResult AddProduct(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Produto model)
        {
            productRepository.Create(model);
            return RedirectToAction("List");
        }

        public ActionResult ReadAllProducts()
        {
            return View(productRepository.ReadAll());
        }
    }
}