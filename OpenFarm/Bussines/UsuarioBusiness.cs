using Common;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class UsuarioBusiness
    {


        public ClassResult Usuario_Crea(UsuarioModel usuarioModel)
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Usuario_Crea(usuarioModel);
        }

        public ClassResult Usuario_Mdf(UsuarioModel usuarioModel)
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Usuario_Mdf(usuarioModel);
        }


        public ClassResult Usuario_Elim(UsuarioModel usuarioModel)
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Usuario_Elim(usuarioModel);
        }


        public ClassResult Usuario_ConsUn(UsuarioModel usuarioModel)
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Usuario_ConsUn(usuarioModel);
        }

        public ClassResult Usuario_Cons()
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Usuario_Cons();
        }

        public ClassResult Rol_Cons()
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Rol_Cons();
        }

        public  DataTable BuscarUsuario(UsuarioModel usuarioModel)
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.FiltrarUsuario(usuarioModel);
        }


        public ClassResult Usuario_Login(UsuarioModel usuarioModel)
        {
            UsuarioRepository _ventaRepository = new UsuarioRepository();
            return _ventaRepository.Usuario_Login(usuarioModel);
        }



    }
}
