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
        public static ControladoraConsultas Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraConsultas();
            return instancia;
        }
        public IReadOnlyCollection<Entidades.Consulta> ObtenerConsulta()        //Para obtener todas las consultas
        {
            return repositorio.ObtenerConsulta()?.ToList() ?? new List<Consulta>();
        }
        public Consulta? ObtenerConsultaPorID(int idConsulta)                   //Para obtener una consulta pr ID
        { 
            if (idConsulta <=0)
            {
                throw new IdNoEncontradoException(nameof(Consulta));    //Si el ID es negativo, no existe como ID de alguna Consulta. 
                return null;
            }
            if (repositorio.ObtenerConsultaPorID(idConsulta) == null)
            {
                throw new EntidadNoEncontradaException(nameof(Consulta));  //Si no existe ninguna consulta con ese ID, lanza la excepcion.
            }
            return repositorio.ObtenerConsultaPorID(idConsulta);
        }
        public void AgregarConsulta(Consulta consulta)
        {
            if (consulta == null)
            {
                throw new EntidadNoEncontradaException(nameof(consulta));  //No buscas nada, porque ingresas con una consulta nula, una que no existe.      
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

    

