namespace VentaRepuestos.Libreria.Entidades
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public int CodigoRepuesto
        {
            get { return _codigo; }
        }

        public string NombreRepuesto
        {
            get { return _nombre; }
        }

        public double PrecioRepuesto
        {
            get { return _precio; }
        }

        public int StockRepuesto
        {
            get { return _stock; }
        }


    }
}