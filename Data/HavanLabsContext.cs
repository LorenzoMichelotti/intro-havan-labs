using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System;

namespace Data
{
    public class HavanLabsContext : DbContext
    {
        //tabela de usuarios
        public DbSet<Usuario> Usuarios { get; set; }
        public System.Data.Entity.DbSet<Data.Produto> Produtoes { get; set; }

        public HavanLabsContext() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=HavanLabs;Integrated Security=True")
        {

        }

    }
}
