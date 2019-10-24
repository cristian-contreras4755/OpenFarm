using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
 public   class VentaCabModel
    {
  
        public string Cd_Vta { get; set; }


        public string Cd_Sr { get; set; }


        public string Cd_TD { get; set; }

      
        public string Cd_Mda { get; set; }

        public string Cd_Clt { get; set; }


        public DateTime FecMov { get; set; }


        public string NroSre { get; set; }

        public string NroDoc { get; set; }


        public string Obs { get; set; }


        public decimal? Valor { get; set; }


        public decimal? TotDsctoP { get; set; }


        public decimal? TotDsctoI { get; set; }


        public decimal? ValorNeto { get; set; }


        public decimal? BaseSinDscto { get; set; }


        public decimal? BIM_Neto { get; set; }


        public decimal? IGV { get; set; }


        public decimal Total { get; set; }

        public DateTime FecReg { get; set; }

        public DateTime? FecMdf { get; set; }

        public int IdUsuCrea { get; set; }

        public int? IdUsuModf { get; set; }

        public bool IB_Anulado { get; set; }

        public bool? IB_Impreso { get; set; }

        public byte[] DE_PDF { get; set; }



    }
}
