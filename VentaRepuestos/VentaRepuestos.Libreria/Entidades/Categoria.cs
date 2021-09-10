using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VentaRepuestos.Libreria.Entidades
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;
        private List<Categoria> _listaCateg;

        //Creacion de propiedades de la clase Categoria
        public int Codigo
        {
            get { return _codigo;  }
        }
        
        public string Nombre
        {
            get { return _nombre; }
        }

        //Creacion de constructores
        public Categoria ()
        { }
        public Categoria (int codigoCategoria, string nombreCategoria)
        {
            _codigo = codigoCategoria;
            _nombre = nombreCategoria;
        }

        public List<Categoria> TraerCategoria()
        {
            if (_listaCateg.Count == 0)
            {
                return null; 
            } else
            {
                return _listaCateg;
            }            
        }
    }
}