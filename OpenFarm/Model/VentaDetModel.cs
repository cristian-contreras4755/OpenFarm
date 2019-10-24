using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class VentaDetModel
    {

        public string Cd_Vta { get; set; }

        public int? Item { get; set; }


        public string Cd_Prod { get; set; }

        public int? Cant { get; set; }


        public string Cd_UM { get; set; }

       
        public decimal? PU { get; set; }

       
        public decimal? Valor { get; set; }

       
        public decimal? DsctoP { get; set; }

       
        public decimal? DsctoI { get; set; }

       
        public decimal? IMP { get; set; }

       
        public decimal? IGV { get; set; }

       
        public decimal? Total { get; set; }

       
        public decimal? TotalNeto { get; set; }


        public string Obs { get; set; }


        public DateTime FecReg { get; set; }

        public DateTime? FecMdf { get; set; }

        public int UsuCrea { get; set; }

        public int? UsuModf { get; set; }



    }
}
