using Common;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class CategoriaBusiness
    {


        public ClassResult Categoria_CreaMdf(CategoriaModel categoriaModel)
        {
            CategoriaRepository _ventaRepository = new CategoriaRepository();
            return _ventaRepository.Categoria_CreaMdf(categoriaModel);
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

    }
}
