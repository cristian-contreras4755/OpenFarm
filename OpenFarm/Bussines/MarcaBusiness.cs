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
  public  class MarcaBusiness
    {

        public ClassResult Marca_Crea(MarcaModel MarcaModel)
        {
            MarcaRepository _ventaRepository = new MarcaRepository();
            return _ventaRepository.Marca_Crea(MarcaModel);
        }

        public ClassResult Marca_Mdf(MarcaModel MarcaModel)
        {
            MarcaRepository _ventaRepository = new MarcaRepository();
            return _ventaRepository.Marca_Mdf(MarcaModel);
        }


        public ClassResult Marca_Elim(MarcaModel MarcaModel)
        {
            MarcaRepository _ventaRepository = new MarcaRepository();
            return _ventaRepository.Marca_Elim(MarcaModel);
        }


        public ClassResult Marca_ConsUn(MarcaModel MarcaModel)
        {
            MarcaRepository _ventaRepository = new MarcaRepository();
            return _ventaRepository.Marca_ConsUn(MarcaModel);
        }

        public ClassResult Marca_Cons()
        {
            MarcaRepository _ventaRepository = new MarcaRepository();
            return _ventaRepository.Marca_Cons();
        }


        public DataTable BuscarMarca(MarcaModel MarcaModel)
        {
            MarcaRepository _ventaRepository = new MarcaRepository();
            return _ventaRepository.FiltrarMarca(MarcaModel);
        }
    }
}
