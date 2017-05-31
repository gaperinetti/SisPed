using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisPed.Models
{
    public class FornecedorProduto
    {
        [Key]
        public int FornecedoProdutorId { get; set; }        
        public int FornecedorId { get; set; }
        public int Id { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Produto Produto { get; set; }
    }
}