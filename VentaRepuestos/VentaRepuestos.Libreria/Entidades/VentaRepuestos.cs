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

        //Creacion de propiedades de la clase VentaRepuestos
        public string NombreComercio
        {
            get { return _nombreComercio; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        //Creacion de constructores
        public VentaRepuestos()
        { }
        public VentaRepuestos(string nombreComercio, string direccionComercio)
        {
            _nombreComercio = nombreComercio;
            _direccion = direccionComercio;
            _listaProductos = new List<Repuesto>;

        }

        //Listar repuestos por categorias
        public List<Repuesto> TraerPorCategoria(int cantidadCategorias)
        {
            List<Repuesto> list = _listaProductos.TraerCategoria();


            return cantidadCategorias;

        }
    }
}
