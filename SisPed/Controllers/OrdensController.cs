using SisPed.Context;
using SisPed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisPed.Controllers
{
    public class OrdensController : Controller
    {
        private ContextPed db = new ContextPed();

        // GET: Ordens
        public ActionResult NovaOrdem()
        {
            var ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.Produtos = new List<ProdutoOrdem>();
            Session["ordemView"] = ordemView;


            ViewBag.CustomizarId = new SelectList(db.Customizars.OrderBy(c => c.Nome), "CustomizarId", "Nome", ordemView.Customizar.CustomizarId);
            return View(ordemView);
        }

        [HttpPost]
        public ActionResult NovaOrdem(OrdemView ordemView)
        {
            //ViewBag.CustomizarId = new SelectList(db.Customizars.OrderBy(c => c.Nome), "CustomizarId", "Nome", ordemView.Customizar.CustomizarId);
            return View(ordemView);
        }

        public ActionResult AdicionarProduto()
        {
            
            ViewBag.Id = new SelectList(db.Produto.OrderBy(c => c.Descricao), "Id", "Descricao");
            return View();
        }

        [HttpPost]
        public ActionResult AdicionarProduto(ProdutoOrdem produtoOrdem)
        {
            var ordemView = Session["ordemView"] as OrdemView;

            var produtoId = int.Parse(Request["Id"]);

            if(produtoId == 0)
            {
                ViewBag.Id = new SelectList(db.Produto.OrderBy(c => c.Descricao), "Id", "Descricao");

                return View(produtoOrdem);
            }

            var produto = db.Produto.Find(produtoId);
            if(produto == null)
            {
                ViewBag.Id = new SelectList(db.Produto.OrderBy(c => c.Descricao), "Id", "Descricao");
                return View(produtoOrdem);
            }

            produtoOrdem = new ProdutoOrdem
            {
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Id = produto.Id,
                Quantidade = decimal.Parse(Request["Quantidade"])
                

            };

            ordemView.Produtos.Add(produtoOrdem);

            ViewBag.CustomizarId = new SelectList(db.Customizars.OrderBy(c => c.Nome), "CustomizarId", "Nome");
            return View("NovaOrdem", ordemView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}