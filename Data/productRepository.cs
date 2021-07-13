using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class productRepository
{
    public void Create(Produto model)
    {
        using (HavanLabsContext context = new HavanLabsContext())
        {
            context.Produtoes.Add(model);
            context.SaveChanges();
        }
    }
    public List<Produto> ReadAll()
    {
        List<Usuario> model = new List<Usuario>();
        using (HavanLabsContext context = new HavanLabsContext())
        {
            return context.Produtoes.ToList();
        }
    }
    //ReadById
    public Produto ReadById(int id)
    {
        Produto model = new Produto();
        using (HavanLabsContext context = new HavanLabsContext())
        {
            return context.Produtoes.Find(id);
        }
    }
    //Update
    public void Update(Produto model)
    {
        using (HavanLabsContext context = new HavanLabsContext())
        {
            context.Entry(model).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
    //Delete
    public void Delete(Produto model)
    {
        using (HavanLabsContext context = new HavanLabsContext())
        {
            context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
