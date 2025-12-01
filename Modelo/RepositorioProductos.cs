using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProductos
    {
        private readonly Context context;
        public List<Entidades.Producto> lista;

        public RepositorioProductos()
        {
            lista = new List<Entidades.Producto>();
            context = new Context();
        }
    }
}
