using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class IngresoModel
    {

        public string Cd_Ing { get; set; }


        public string Ejer { get; set; }


        public string Cd_TD { get; set; }


        public string NroDoc { get; set; }


        public string NroSre { get; set; }


        public string Cd_Mda { get; set; }
        public string Cd_TM { get; set; }


        public string Proveedor { get; set; }

        public decimal? BIM_Neto { get; set; }


        public decimal? Total { get; set; }

        public decimal? Igv { get; set; }

        public DateTime? FecMov { get; set; }

        public int? IdUsuModf { get; set; }

        public DateTime? FecReg { get; set; }

        public DateTime? FecMdf { get; set; }

        public int? IdUsuCrea { get; set; }

        public bool IB_Anulado { get; set; }



    }
}
