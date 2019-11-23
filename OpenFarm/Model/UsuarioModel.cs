using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class UsuarioModel
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

        public int IdUsuCrea { get; set; }


        public string Usuario { get; set; }

        public string Password { get; set; }

        public bool? Ib_Estado { get; set; }
    }
}
