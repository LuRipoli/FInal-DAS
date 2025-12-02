using Entidades;
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

        public RepositorioClientes()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Cliente> ObtenerClientes()
        {
            return context.Clientes.ToList().AsReadOnly();
        }

        public void AgregarCliente(Cliente unCliente)
        {
            context.Clientes.Add(unCliente);
            context.SaveChanges();
        }

        public void ModificarCliente(Cliente unCliente)
        {
            context.Clientes.Update(unCliente);
            context.SaveChanges();
        }

        public void EliminarCliente(Cliente unCliente)
        {
            context.Clientes.Remove(unCliente);
            context.SaveChanges();
        }

        public Cliente? ObtenerClientePorId(int idCliente)
        {
            return context.Clientes.FirstOrDefault(c => c.Id == idCliente);
        }
    }
}
