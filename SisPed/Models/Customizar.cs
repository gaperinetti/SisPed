using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisPed.Models
{
    public class Customizar
    {
        [Key]
        public int CustomizarId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string Documento { get; set; }
        public int TipoDocumentoId { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual ICollection<Ordem> Ordem { get; set; }
    }
}