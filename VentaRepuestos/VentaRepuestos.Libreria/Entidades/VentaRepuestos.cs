using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Libreria.Entidades
{
    public class VentaRepuestos
    {
        private string _nombreComercio;
        private string _direccion;
        private List<Repuesto> _listaProductos;

        public string NombreComercio
        {
            get { return _nombreComercio; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }
    }
}
