using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCategorias
    {
        private readonly Context context;
        public List<Entidades.Categoria> lista;

        public RepositorioCategorias()
        {
            lista = new List<Entidades.Categoria>();
            context = new Context();
        }
    }
}
