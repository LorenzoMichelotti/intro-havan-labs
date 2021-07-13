using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioRepository
    {
        //CRUD
        //Create
        public void Create(Usuario model)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                context.Usuarios.Add(model);

                Migrations.CreateTableProduto createTableProduto = new Migrations.CreateTableProduto();
                createTableProduto.ProdutoCreateTable(System.DateTime.Now.ToString());

                context.SaveChanges();
            }
        }
        //ReadAll
        public List<Usuario> ReadAll()
        {
            List<Usuario> model = new List<Usuario>();
            using (HavanLabsContext context = new HavanLabsContext())
            {
                return context.Usuarios.ToList();
            }
        }
        //ReadById
        public Usuario ReadById(int id)
        {
            Usuario model = new Usuario();
            using (HavanLabsContext context = new HavanLabsContext())
            {
                return context.Usuarios.Find(id);
            }
        }
        //Update
        public void Update(Usuario model)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Delete
        public void Delete(Usuario model)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
