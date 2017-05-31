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
        // GET: Ordens
        public ActionResult NovaOrdem()
        {
            var ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.ProdutoOrdem = new List<ProdutoOrdem>();
            return View(ordemView);
        }
    }
}