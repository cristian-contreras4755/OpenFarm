using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class UsarioModel
    {
        public int Id_Usuario { get; set; }

        public int Id_Rol { get; set; }


        public string Cd_TDI { get; set; }


        public string NDoc { get; set; }

        public string ApPat { get; set; }


        public string ApMat { get; set; }


        public string Nom { get; set; }


        public string Direc { get; set; }

        public string Telf1 { get; set; }


        public string Telf2 { get; set; }

 
        public string Correo { get; set; }

        public string Cargo { get; set; }

        public string IdUsuCrea { get; set; }


        public string IdUsuMdf { get; set; }

        public DateTime? FecReg { get; set; }

        public DateTime? FecMdf { get; set; }


        public string usuario1 { get; set; }

        public string Password { get; set; }

        public bool? Ib_Estado { get; set; }
    }
}
