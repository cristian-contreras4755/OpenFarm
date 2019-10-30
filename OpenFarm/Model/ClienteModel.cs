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

        public bool TipoCliente { get; set; }
        
        public string Cd_TDI { get; set; }

        public string NDoc { get; set; }

        public string RSocial { get; set; }


        public string NComercial { get; set; }

       
        public string ApPat { get; set; }


        public string ApMat { get; set; }


        public string Nom { get; set; }


        public string Direc { get; set; }


        public string Telf { get; set; }

        public string Correo { get; set; }

        public int IdUsuCrea { get; set; }

        public string TextoBuscar { get; set; }
        
    }
}
