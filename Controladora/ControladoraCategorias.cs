using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraCategorias
    {
        private RepositorioCategorias reporitoio = new RepositorioCategorias();
        private static ControladoraCategorias instancia;
        public static ControladoraCategorias instanciar()
        {
            if (instancia == null)
            {
                instancia = new ControladoraCategorias();
            }
            return instancia;
        }
    }
}
