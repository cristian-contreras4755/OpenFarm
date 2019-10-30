using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class MovimientoModel
    {
        public string Cd_Mov { get; set; }

        public string Ejer { get; set; }


        public string Cd_TD { get; set; }

        public string NroDoc { get; set; }

        public string NroSre { get; set; }

        public string Cd_TM { get; set; }

        public string Cd_Clt { get; set; }

        public string Cd_Vta { get; set; }

        public string Cd_Prov { get; set; }

        public DateTime? FecMov { get; set; }

        public int? IdUsuModf { get; set; }

        public DateTime? FecReg { get; set; }

        public DateTime? FecMdf { get; set; }

        public int? IdUsuCrea { get; set; }

        public bool IB_Anulado { get; set; }
    }
}
