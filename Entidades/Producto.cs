namespace Entidades
{
    public class Producto
    {
        #region ATRIBUTOS

        private static int proximaId;

        private int id;
        private string nombre;
        private eCategoriaProducto categoria;
        private eTipoProducto tipo;
        private eMarcaProducto marca;
        private decimal precio;
        private int cantidadStock;

        #endregion

        #region CONSTRUCTORES

        static Producto()
        {
            proximaId = 1000;
        }

        public Producto()
        { 
        }

        public Producto(string nombre, eCategoriaProducto categoria, eTipoProducto tipo, eMarcaProducto marca, decimal precio, int cantidadStock) : this()
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Tipo = tipo;
            this.Marca = marca;
            this.Precio = precio;
            this.CantidadStock = cantidadStock;
            this.id = proximaId;
            proximaId++;
        }




        #endregion

        #region PROPIEDADES

        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public eCategoriaProducto Categoria { get => categoria; set => categoria = value; }
        public eTipoProducto Tipo { get => tipo; set => tipo = value; }
        public eMarcaProducto Marca { get => marca; set => marca = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }

        /// <summary>
        /// Devuelve un string compuesto con información sobre el Producto
        /// </summary>
        public string NombreLista
        {
            get { return this.Nombre + this.Marca + this.Categoria;  }
        }





        #endregion

        #region METODOS

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"{this.Id}, {this.Nombre}, {this.Marca}";
        }


        #endregion

        #region SOBRECARGA DE OPERADORES


        public static bool operator==(Producto a, Producto b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        public static int operator +(Producto a, Producto b)
        {
            return a.CantidadStock + b.CantidadStock;
        }

        public static int operator -(Producto a, Producto b)
        {
            return a.CantidadStock - b.CantidadStock;
        }

        public static int operator +(Producto a, int entero)
        {
            return a.CantidadStock + entero;
        }

        public static int operator -(Producto a, int entero)
        {
            return a.CantidadStock - entero;
        }



        #endregion


    }
}