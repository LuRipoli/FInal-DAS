using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraClientes
    {
        private RepositorioClientes repositorio = new RepositorioClientes();
        private static ControladoraClientes instancia;

        public static ControladoraClientes Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraClientes();

            return instancia;
        }

        public List<Cliente> ObtenerClientes()
        {
            var clientes = repositorio.ObtenerClientes()?.ToList() ?? new List<Cliente>();

            if (clientes.Count == 0)
                throw new ListaVaciaException("No se encontraron clientes.");

            return clientes;
        }

        public void AgregarCliente(string Nombre, string Email, int tipoCliente)
        {

            if (string.IsNullOrEmpty(Nombre))
                throw new DatosInvalidosException("El nombre del cliente no puede estar vacío.");
            var listaClientes = repositorio.ObtenerClientes();
            if (listaClientes.Any(c => c.Nombre.ToLower() == Nombre.ToLower()))
                throw new EntidadYaExistenteException("Ya existe un cliente con ese nombre.");
            if (string.IsNullOrWhiteSpace(Email))
                throw new DatosInvalidosException("El email no puede estar vacío.");
            if (!Email.Contains("@"))
                throw new DatosInvalidosException("El email ingresado no es válido.");
            if (!Enum.IsDefined(typeof(TipoCliente), tipoCliente))
                throw new DatosInvalidosException("El tipo de cliente ingresado no es válido.");

            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Nombre = Nombre;
            nuevoCliente.Email = Email;
            nuevoCliente.TipoCliente = (TipoCliente)tipoCliente;
            repositorio.AgregarCliente(nuevoCliente);
        }

        public void ModificarClientes(int idCliente, string nuevoNombre, string nuevoEmail,int nuevoTipoCliente)
        {
            var cliente = repositorio.ObtenerClientePorId(idCliente);
            if (cliente == null)
                throw new EntidadNoEncontradaException("No se encontró el cliente especificado.");
            if (string.IsNullOrEmpty(nuevoNombre))
                throw new DatosInvalidosException("El nombre del cliente no puede estar vacío.");
            var listaClientes = repositorio.ObtenerClientes();
            if (listaClientes.Any(c => c.Nombre.ToLower() == nuevoNombre.ToLower() && c.Id != idCliente))
                throw new EntidadYaExistenteException("Ya existe un cliente con ese nombre.");
            if (string.IsNullOrWhiteSpace(nuevoEmail))
                throw new DatosInvalidosException("El email no puede estar vacío.");
            if (!nuevoEmail.Contains("@"))
                throw new DatosInvalidosException("El email ingresado no es válido.");
            if (!Enum.IsDefined(typeof(TipoCliente), nuevoTipoCliente))
                throw new DatosInvalidosException("El tipo de cliente ingresado no es válido.");

            cliente.Nombre = nuevoNombre;
            cliente.Email = nuevoEmail;
            cliente.TipoCliente = (TipoCliente)nuevoTipoCliente;
            repositorio.ModificarCliente(cliente);
        }

        public void EliminarCliente(int idCliente)
        {
            var cliente = repositorio.ObtenerClientePorId(idCliente);

            if (cliente == null)
                throw new EntidadNoEncontradaException("No se encontró el cliente especificado.");

            repositorio.EliminarCliente(cliente);
        }

        public Cliente BuscarClientePorId(int idCliente)
        {
            var cliente = repositorio.ObtenerClientePorId(idCliente);

            if (cliente == null)
                throw new EntidadNoEncontradaException("No se encontró el cliente especificado.");

            return cliente;
        }
    }
}
