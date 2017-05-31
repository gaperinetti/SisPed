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
            ordemView.ProdutoOrdem = new List<ProdutoOrdem>();

            ViewBag.CustomizarId = new SelectList(db.Customizars.OrderBy(c => c.Nome), "CustomizarId", "Nome", ordemView.Customizar.CustomizarId);
            return View(ordemView);
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