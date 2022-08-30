using PEA2_Data;
using PEA2_Dominio;
using System.Collections.Generic;

namespace PEA2_Logic
{
    public static class ProductoBL
    {
        public static List<Producto> Listar()
        {
            var productoData = new ProductoData();
            return productoData.Listar();
        }

        public static Producto BuscarPorId(int id)
        {
            var productoData = new ProductoData();
            return productoData.BuscarPorId(id);
        }

        public static bool Insertar(Producto producto)
        {
            var productoData = new ProductoData();
            return productoData.Insertar(producto);
        }

        public static bool Actualizar(Producto Producto)
        {
            var ProductoData = new ProductoData();
            return ProductoData.Actualizar(Producto);
        }

        public static bool Eliminar(int id)
        {
            var ProductoData = new ProductoData();
            return ProductoData.Eliminar(id);
        }
    }
}
