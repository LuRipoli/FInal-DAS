using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraConsultas
    {
        private RepositorioConsultas repositorio = new RepositorioConsultas();
        private static ControladoraConsultas instancia;

        public static ControladoraConsultas Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraConsultas();

            return instancia;
        }

        private ControladoraConsultas() { }
    }
}
