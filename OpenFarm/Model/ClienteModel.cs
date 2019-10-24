using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class ClienteModel
    {

        public string Cd_Clt { get; set; }

        public string Cd_TDI { get; set; }

        public string NDoc { get; set; }

        public string RSocial { get; set; }


        public string NComercial { get; set; }

       
        public string ApPat { get; set; }


        public string ApMat { get; set; }


        public string Nom { get; set; }


        public string Direc { get; set; }


        public string Telf1 { get; set; }

        public string Telf2 { get; set; }


        public string Correo { get; set; }


        public string Obs { get; set; }

        public DateTime? FecReg { get; set; }


        public string UsuCrea { get; set; }

        public DateTime? FecMdf { get; set; }


        public string UsuMdf { get; set; }

        public bool? Estado { get; set; }

    }
}
