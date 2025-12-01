using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraVentas
    {
        private RepositorioVentas repositorio = new RepositorioVentas();
        private static ControladoraVentas instancia;

        public static ControladoraVentas Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraVentas();

            return instancia;
        }

        private ControladoraVentas() { }
    }
}
