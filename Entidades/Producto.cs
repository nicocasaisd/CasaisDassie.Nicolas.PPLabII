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

        public static void HardcodearProductos()
        {
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Parlante Bluetooth", eCategoriaProducto.Audio, eTipoProducto.Parlante,
                eMarcaProducto.JBL, 17500, 20
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Teclado inalámbrico", eCategoriaProducto.Computacion, eTipoProducto.Teclado,
                eMarcaProducto.Lenovo, 1270, 10
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Monitor 19\"", eCategoriaProducto.Video, eTipoProducto.Monitor,
                eMarcaProducto.Lenovo, 1270, 10
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Notebook I7 8gb RAM", eCategoriaProducto.Computacion, eTipoProducto.Notebook,
                eMarcaProducto.Dell, 123300, 5
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Impresora Profesional", eCategoriaProducto.Impresion, eTipoProducto.Impresora,
                eMarcaProducto.Epson, 45070, 6
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Play Station 5", eCategoriaProducto.Gaming, eTipoProducto.ConsolaGaming,
                eMarcaProducto.PlayStation, 16580, 4
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Micrófono Condenser", eCategoriaProducto.Audio, eTipoProducto.Microfono,
                eMarcaProducto.DyB, 43200, 16
                ));
            TiendaElectronica.ListaProductos.Add(new Producto(
                "Monitor 14\"", eCategoriaProducto.Video, eTipoProducto.Monitor,
                eMarcaProducto.HP, 35200, 3
                ));
        }
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

        /// <summary>
        /// Modifica los valores del Producto 
        /// </summary>
        /// <returns></returns>
        public void ModificarProducto(decimal precio, int cantidadStock, eCategoriaProducto categoria)
        {
            this.Precio = precio;
            this.CantidadStock = cantidadStock;
            this.Categoria = categoria;
        }

        /// <summary>
        /// Instancia el Producto y lo agrega a la lista estática de productos
        /// </summary>
        /// <returns></returns>
        public static void AgregarProducto(string nombre, eCategoriaProducto categoria, eTipoProducto tipo, eMarcaProducto marca, decimal precio, int cantidad)
        {
            Producto auxProducto = new Producto(nombre, categoria, tipo, marca, precio, cantidad);
            TiendaElectronica.ListaProductos.Add(auxProducto);  
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