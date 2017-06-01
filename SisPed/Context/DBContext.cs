using SisPed.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SisPed.Context
{
    public class SisPedidoContext : DbContext // classe que recebe informacao do banco de dados
    {
        public DbSet<Produto> Produto { get; set; } // referencia  Modelo Produto


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<SisPed.Models.TipoDocumento> TipoDocumentoes { get; set; }

        public System.Data.Entity.DbSet<SisPed.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<SisPed.Models.Fornecedor> Fornecedors { get; set; }

        public System.Data.Entity.DbSet<SisPed.Models.Customizar> Customizars { get; set; }
    }
}