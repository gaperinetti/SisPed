namespace SisPed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComentarioFieldModelProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Comentario", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Comentario");
        }
    }
}
