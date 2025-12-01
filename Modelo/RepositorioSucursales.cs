using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioSucursales
    {
        private readonly Context context;
        public List<Entidades.Sucursal> lista;

        public RepositorioSucursales()
        {
            lista = new List<Entidades.Sucursal>();
            context = new Context();
        }
    }
}

