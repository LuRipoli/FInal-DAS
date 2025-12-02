using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

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



        public IReadOnlyCollection<Entidades.Consulta> ObtenerConsulta()        //Para obtener todas las consultas
        {
            return repositorio.ObtenerConsulta();
        }

        public Consulta? ObtenerConsultaPorID(int idConsulta)                   //Para obtener una consulta pr ID
        { 
            if (idConsulta <= 0)
            {
                return null;
            }
            return repositorio.ObtenerConsultaPorID(idConsulta);
        }

        public void AgregarConsulta(Consulta consulta)
        {
            if (consulta == null)
            {
                throw new ArgumentNullException(nameof(consulta));
                repositorio.AgregarConsulta(consulta);
            }
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

    

