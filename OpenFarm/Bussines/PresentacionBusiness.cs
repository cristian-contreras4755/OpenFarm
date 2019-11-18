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
    public class PresentacionBusiness
    {


        public ClassResult Presentacion_Crea(PresentacionModel presentacionModel)
        {
            PresentacionRepository _ventaRepository = new PresentacionRepository();
            return _ventaRepository.Presentacion_Crea(presentacionModel);
        }

        public ClassResult Presentacion_Mdf(PresentacionModel presentacionModel)
        {
            PresentacionRepository _ventaRepository = new PresentacionRepository();
            return _ventaRepository.Presentacion_Mdf(presentacionModel);
        }


        public ClassResult Presentacion_Elim(PresentacionModel presentacionModel)
        {
            PresentacionRepository _ventaRepository = new PresentacionRepository();
            return _ventaRepository.Presentacion_Elim(presentacionModel);
        }


        public ClassResult Presentacion_ConsUn(PresentacionModel presentacionModel)
        {
            PresentacionRepository _ventaRepository = new PresentacionRepository();
            return _ventaRepository.Presentacion_ConsUn(presentacionModel);
        }

        public ClassResult Presentacion_Cons()
        {
            PresentacionRepository _ventaRepository = new PresentacionRepository();
            return _ventaRepository.Presentacion_Cons();
        }

        public  DataTable BuscarPresentacion(PresentacionModel presentacionModel)
        {
            PresentacionRepository _ventaRepository = new PresentacionRepository();
            return _ventaRepository.FiltrarPresentacion(presentacionModel);
        }

    }
}
