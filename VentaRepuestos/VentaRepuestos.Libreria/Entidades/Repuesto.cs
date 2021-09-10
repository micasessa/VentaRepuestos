﻿namespace VentaRepuestos.Libreria.Entidades
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        //Creacion de propiedades de la clase Repuesto
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

        //Creacion de constructores
        public Repuesto ()
        { }

        public Repuesto (int codigoRepuesto, string nombreRepuesto, double precioRepuesto,int stockRepuesto )
        {
            _codigo = codigoRepuesto;
            _nombre = nombreRepuesto;
            _precio = precioRepuesto;
            _stock = stockRepuesto;
            _categoria = new Categoria();
        }
        public string ToString(string nombre)
        {
            //Faltadesarrollar?
            return nombre;
        }

    }
}