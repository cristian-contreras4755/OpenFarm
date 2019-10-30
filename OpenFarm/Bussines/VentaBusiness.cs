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
  public  class VentaBusiness
    {

        public ClassResult VentaCab_Crea(VentaCabModel VentaCabModel)
        {
            VentaRepository _ventaRepository = new VentaRepository();
            return _ventaRepository.VentaCab_Crea(VentaCabModel);
        }

        public ClassResult Venta_Anular(VentaCabModel VentaCabModel)
        {
            VentaRepository _ventaRepository = new VentaRepository();
            return _ventaRepository.Venta_Anular(VentaCabModel);
        }

        public ClassResult Venta_Impreso(VentaCabModel VentaCabModel)
        {
            VentaRepository _ventaRepository = new VentaRepository();
            return _ventaRepository.Venta_Impreso(VentaCabModel);
        }

        public ClassResult VentaDet_Crea(VentaDetModel VentaDetModel)
        {
            VentaRepository _ventaRepository = new VentaRepository();
            return _ventaRepository.VentaDet_Crea(VentaDetModel);
        }


    }
}
