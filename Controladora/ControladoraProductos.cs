using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraProductos
    {
        private RepositorioProductos repositorio = new RepositorioProductos();
        private static ControladoraProductos instancia;

        public static ControladoraProductos Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraProductos();

            return instancia;
        }

        private ControladoraProductos() { }
    }
}
