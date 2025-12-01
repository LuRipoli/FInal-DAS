using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioClientes
    {
        private readonly Context context;
        public List<Entidades.Cliente> lista;
        public RepositorioClientes()
        {
            lista = new List<Entidades.Cliente>();
            context = new Context();
        }
    }
}
