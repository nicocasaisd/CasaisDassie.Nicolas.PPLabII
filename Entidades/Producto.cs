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
        //private string descripcion;
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

        public Producto(string nombre, eCategoriaProducto categoria, eTipoProducto tipo, eMarcaProducto marca, decimal precio) : this()
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Tipo = tipo;
            this.Marca = marca;
            this.Precio = precio;
            // Valores por defecto
            this.CantidadStock = 0;
            this.id = proximaId;
            proximaId++;
        }

        public Producto(string nombre, eCategoriaProducto categoria, eTipoProducto tipo, eMarcaProducto marca, decimal precio, int cantidadStock) :this(nombre, categoria, tipo, marca, precio)
        {
            this.CantidadStock = cantidadStock;
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

        public string NombreLista
        {
            get { return this.Nombre + this.Marca + this.Categoria;  }
        }



        #endregion

        #region METODOS

        // Sobrecarga de ToString
        public override string ToString()
        {
            return $"{this.Id}, {this.Nombre}, {this.Marca}" ;
        }


        #endregion

    }
}