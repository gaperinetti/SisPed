using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisPed.Models
{
    public class OrdemDetalhe
    {
        [Key]
        public int OrdemDetalheId { get; set; }
        public int OrdemId { get; set; }
        public int Id { get; set; }

        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public float Quantidade { get; set; }

        public virtual Ordem Ordem { get; set; }
        public virtual Produto Produto { get; set; }
    }
}