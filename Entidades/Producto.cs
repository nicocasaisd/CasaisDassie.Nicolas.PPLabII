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
        private string descripcion;
        private double precio;
        private int cantidadStock;

        #endregion

        #region CONSTRUCTORES

        static Producto()
        {
            proximaId = 1000;
        }


        public Producto()
        {
            // asigno id y aumento en 1 el contador
            this.id = proximaId;
            proximaId++;
        }

        public Producto(string nombre, eCategoriaProducto categoria, eTipoProducto tipo, eMarcaProducto marca, double precio) : this()
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Tipo = tipo;
            this.Marca = marca;
            this.Precio = precio;
            // Valores por defecto
            this.Descripcion = "Sin descripcion";
            this.CantidadStock = 0;
        }

        public Producto(string nombre, eCategoriaProducto categoria, eTipoProducto tipo, eMarcaProducto marca, string descripcion, double precio, int cantidadStock) :this(nombre, categoria, tipo, marca, precio)
        {
            this.Descripcion = descripcion;
            this.CantidadStock = cantidadStock;
        }


        #endregion

        #region PROPIEDADES

        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public eCategoriaProducto Categoria { get => categoria; set => categoria = value; }
        public eTipoProducto Tipo { get => tipo; set => tipo = value; }
        public eMarcaProducto Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }





        #endregion

    }
}