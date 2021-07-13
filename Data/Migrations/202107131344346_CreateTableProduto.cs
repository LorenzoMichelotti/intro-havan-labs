namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public partial class CreateTableProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Usuario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.Produtoes", new[] { "Usuario_Id" });
            DropTable("dbo.Produtoes");
        }

        public void ProdutoCreateTable(string tableName)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                if (!Exists(tableName))
                {
                CreateTable(
                    tableName,
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                    .PrimaryKey(t => t.Id)
                    .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                    .Index(t => t.Usuario_Id);
                }
            }
        }

        private static bool Exists(string tableName)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                var count = context.Database.SqlQuery<int>("SELECT COUNT(OBJECT_ID(@p0, 'U'))", tableName);

                return count.Any() && count.First() > 0;
            }
        }

    }
}
