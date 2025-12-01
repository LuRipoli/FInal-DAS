using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraSucursales
    {
        private RepositorioSucursales repositorio = new RepositorioSucursales();
        private static ControladoraSucursales instancia;

        public static ControladoraSucursales Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraSucursales();

            return instancia;
        }

        private ControladoraSucursales() { }
    }
}

