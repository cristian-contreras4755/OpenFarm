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
   public class ProductoBusiness
    {


        public ClassResult Producto_Crea(ProductoModel ProductoModel)
        {
            ProductoRepository _ventaRepository = new ProductoRepository();
            return _ventaRepository.Producto_Crea(ProductoModel);
        }

        public ClassResult Producto_Mdf(ProductoModel ProductoModel)
        {
            ProductoRepository _ventaRepository = new ProductoRepository();
            return _ventaRepository.Producto_Mdf(ProductoModel);
        }


        public ClassResult Producto_Elim(ProductoModel ProductoModel)
        {
            ProductoRepository _ventaRepository = new ProductoRepository();
            return _ventaRepository.Producto_Elim(ProductoModel);
        }


        public ClassResult Producto_ConsUn(ProductoModel ProductoModel)
        {
            ProductoRepository _ventaRepository = new ProductoRepository();
            return _ventaRepository.Producto_ConsUn(ProductoModel);
        }

        public ClassResult Producto_Cons()
        {
            ProductoRepository _ventaRepository = new ProductoRepository();
            return _ventaRepository.Producto_Cons();
        }


        public DataTable BuscarProducto(ProductoModel ProductoModel)
        {
            ProductoRepository _ventaRepository = new ProductoRepository();
            return _ventaRepository.FiltrarProducto(ProductoModel);
        }




    }
}
