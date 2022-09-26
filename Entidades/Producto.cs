namespace Entidades
{
    public class Producto
    {
        #region ATRIBUTOS

        private static int proximaId;
        private int id;
        private string nombre;
        private eCategoriaProducto categoria;
        private string descripcion;
        private eMarcaProducto marca;
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

        #endregion

    }
}