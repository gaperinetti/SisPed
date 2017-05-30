using SisPed.Context;
using SisPed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SisPed.Controllers
{
    public class ProdutoController : Controller
    {

        private SisPedContext db = new SisPedContext();

        // GET: Produto
        public ActionResult Index()
        {
            return View(db.Produto.ToList()); // Lista os produtos na view
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            if(id == null) // tratamento campo nulo para nao travar o sistema
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produto = db.Produto.Find(id);//busca id do produto para mostrar detalhes

            if(produto == null) // tratamento campo nulo para nao travar o sistema
            {
                return HttpNotFound();
            }

            return View(produto); // chama a view detalhes com o produto buscado do id
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)// SE OS DADOS FORAM VALIDOS?
                {
                    db.Produto.Add(produto);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }

                return View(produto);
            }

            catch
            {
                return View(produto);
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
