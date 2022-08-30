using PEA2_Data;
using PEA2_Dominio;
using System.Collections.Generic;


namespace PEA2_Logic
{
    public static class CategoriaBL
    {
        public static List<Categoria> Listar()
        {
            var categoriaData = new CategoriaData();
            return categoriaData.Listar();
        }
    }
}
