using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCategorias
    {
        private readonly Context context;
        public RepositorioCategorias()
        {
            context = new Context();
        }
        public IReadOnlyCollection<Categoria> ObtenerCategorias()
        {
            return context.Categorias.ToList().AsReadOnly();
        }
        public void AgrgarCategoria(Categoria unaCategoria)
        {
            context.Categorias.Add(unaCategoria);
            context.SaveChanges();
        }
        public void ModificarCategoria(Categoria unaCategoria)
        {
            context.Categorias.Update(unaCategoria);
            context.SaveChanges();
        }
        public void EliminarCategoria(Categoria unaCategoria)
        {
            context.Categorias.Remove(unaCategoria);
            context.SaveChanges();
        }
        public Categoria? ObtenerCategoriaPorId(int idCategoria)
        {
            return context.Categorias.FirstOrDefault(c => c.Id == idCategoria);
        }
        public Categoria? ObtenerCategoriaPorNombre(string nombreCategoria)
        {
            return context.Categorias.FirstOrDefault(c => c.Nombre == nombreCategoria);
        }
    }
}
