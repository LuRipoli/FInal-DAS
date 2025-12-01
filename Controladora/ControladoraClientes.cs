using Modelo;

namespace Controladora
{
    internal class ControladoraClientes
    {
        private RepositorioClientes repositorio = new RepositorioClientes();
        private static ControladoraClientes instancia;

        public static ControladoraClientes Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraClientes();

            return instancia;
        }

        private ControladoraClientes() { }
    }
}
