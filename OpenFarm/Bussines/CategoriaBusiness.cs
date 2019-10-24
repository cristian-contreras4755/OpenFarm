using Common;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class CategoriaBusiness
    {


        public ClassResult Categoria_Crea(CategoriaModel categoriaModel)
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.Categoria_Crea(categoriaModel);
        }

        public ClassResult Categoria_Mdf(CategoriaModel categoriaModel)
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.Categoria_Mdf(categoriaModel);
        }


        public ClassResult Categoria_Elim(CategoriaModel categoriaModel)
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.Categoria_Elim(categoriaModel);
        }


        public ClassResult Categoria_ConsUn(CategoriaModel categoriaModel)
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.Categoria_ConsUn(categoriaModel);
        }

        public ClassResult Categoria_Cons()
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.Categoria_Cons();
        }


        public  DataTable BuscarCategoria(CategoriaModel categoriaModel)
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.FiltrarCategoria(categoriaModel);
        }

    }
}
