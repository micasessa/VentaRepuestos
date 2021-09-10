namespace VentaRepuestos.Libreria.Entidades
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

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
    }
}