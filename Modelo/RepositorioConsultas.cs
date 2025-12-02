using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioConsultas
    {
        private readonly Context context;
        public List<Entidades.Consulta> lista;

        public RepositorioConsultas()
        {
            lista = new List<Entidades.Consulta>();
            context = new Context();
        }

        public IReadOnlyCollection<Entidades.Consulta> ObtenerConsulta()
        {
            return context.Consultas.ToList().AsReadOnly();
        }

    public void AgregarConsulta(Entidades. Consulta consulta)
        {
            context.Consultas.Add(consulta);
            context.SaveChanges(); 
        }

        public void EliminarConsulta(Entidades. Consulta consulta)
        {
            context.Consultas.Remove(consulta);
            context.SaveChanges(); 
        }
        
        public Consulta? ObtenerConsultaPorID(int idConsulta)
        {
            return context.Consultas.FirstOrDefault(c => c.Id == idConsulta);
        }

    }
}
    
