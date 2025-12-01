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
    }
}
    
