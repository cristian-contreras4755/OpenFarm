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
   public class IngresoBusiness
    {
        public ClassResult Ingreso_Crea(IngresoModel ingresoModel, List<IngresoDetModel> ingresoDetModel)
        {
            ClassResult crprin = new ClassResult();
            try
            {
                     
                        IngresoRepository _ventaRepository = new IngresoRepository();
                        ClassResult cr = _ventaRepository.IngresoCab_Crea(ingresoModel);
                        if (cr.HuboError)
                        {
                            crprin = cr;
                        }
                        else
                        {
                                foreach (var item in ingresoDetModel)
                                {
                                        ClassResult crprindet = new ClassResult();
                                        crprindet = _ventaRepository.IngresoDet_Crea(item);
                                        if (crprindet.HuboError)
                                        {
                                        return crprin = crprindet;
                                             
                                        }
                                        else
                                        {
                                            crprin.HuboError = false;
                                            crprin.LugarError = "";
                                          return crprin;
                                        }

                                }
                        }
            }
            catch (Exception ex)
            {
                crprin.HuboError = true;
                crprin.ErrorMsj = ex.Message;
                crprin.LugarError = "Ingreso_Crea()";
                return crprin;
            }

            return crprin;
        }

    }
}
