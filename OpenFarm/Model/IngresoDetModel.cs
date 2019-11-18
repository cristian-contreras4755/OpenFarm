using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class IngresoDetModel
    {

        public int IdIngDet { get; set; }


        public string Cd_Ing { get; set; }

   
        public string Cd_Prod { get; set; }


        public string Cd_UM { get; set; }

        public int Cant { get; set; }


        public decimal? PrecioCom { get; set; }


        public decimal? PrecioVta { get; set; }

        public int? Stock_inicial { get; set; }

        public int? Stock_Actual { get; set; }


        public DateTime? Fecha_produccion { get; set; }


        public DateTime? Fecha_vencimiento { get; set; }

        public decimal? Total { get; set; }

        public DateTime? FecReg { get; set; }

        public int IdUsuCrea { get; set; }

        public bool IB_Anulado { get; set; }



    }
}
