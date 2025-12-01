using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVentas
    {
        private readonly Context context;
        public List<Entidades.Venta> lista;

        public RepositorioVentas()
        {
            lista = new List<Entidades.Venta>();
            context = new Context();
        }
    }
}
