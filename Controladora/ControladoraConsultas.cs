using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace Controladora
{
    public class ControladoraConsultas
    {
        private RepositorioConsultas repositorio = new RepositorioConsultas();
        private static ControladoraConsultas instancia;
        private ControladoraConsultas()
        {
            repositorio = new RepositorioConsultas();
        }
        public static ControladoraConsultas Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraConsultas();
            return instancia;
        }
        public IReadOnlyCollection<Entidades.Consulta> ObtenerConsulta()       
        {
            return repositorio.ObtenerConsulta()?.ToList() ?? new List<Consulta>();
        }
        public Consulta? ObtenerConsultaPorID(int idConsulta)                  
        { 
            if (idConsulta <=0)
            {
                throw new IdNoEncontradoException(nameof(Consulta));   
                return null;
            }
            if (repositorio.ObtenerConsultaPorID(idConsulta) == null)
            {
                throw new EntidadNoEncontradaException(nameof(Consulta));  
            }
            return repositorio.ObtenerConsultaPorID(idConsulta);
        }
        public void AgregarConsulta(Consulta consulta)
        {
            if (consulta == null)
            {
                throw new EntidadNoEncontradaException(nameof(consulta));
            }
            repositorio.AgregarConsulta(consulta);
        }
        public bool EliminarConsulta(int idConsulta)
        {
            if (idConsulta <= 0)
            {
                return false;
            }
            var consulta = repositorio.ObtenerConsultaPorID(idConsulta);
            if (consulta == null)
            {
                return false;
            }
            repositorio.EliminarConsulta (consulta);
            return true;
        }
    }
}

    

