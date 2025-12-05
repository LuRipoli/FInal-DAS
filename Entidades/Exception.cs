using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockNegativoException : Exception 
    {
        public StockNegativoException(string mensaje) : base(mensaje) { }
    }
    public class MovimientoInvalidoException : Exception
    {
        public MovimientoInvalidoException(string mensaje) : base(mensaje) { }
    }
    public class ListaVaciaException : Exception 
    {
        public ListaVaciaException(string mensaje) : base(mensaje) { }
    }
    public class DatosInvalidosException : Exception 
    {
        public DatosInvalidosException(string mensaje) : base(mensaje) { }
    }
    public class OperacionNoPermitidaException : Exception
    {
        public OperacionNoPermitidaException(string mensaje) : base(mensaje) { }
    }
    public class IdNoEncontradoException : Exception 
    {
        public IdNoEncontradoException(string mensaje) : base(mensaje) { }
    }
    public class EntidadYaExistenteException: Exception 
    {
        public EntidadYaExistenteException(string mensaje) : base(mensaje) { }
    }
    public class EntidadNoEncontradaException: Exception 
    {
        public EntidadNoEncontradaException(string mensaje) : base(mensaje) { }
    }
}
