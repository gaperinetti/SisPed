using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisPed.Models
{
    public class ProdutoOrdem : Produto 
    {
        public decimal Quantidade { get; set; }
        public decimal Valor { get { return Preco * Quantidade; } }
    }
}