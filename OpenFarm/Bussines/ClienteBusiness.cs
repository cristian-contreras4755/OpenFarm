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
   public class ClienteBusiness
    {

        public ClassResult Cliente_Crea(ClienteModel ClienteModel)
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.Cliente_Crea(ClienteModel);
        }

        public ClassResult Cliente_Mdf(ClienteModel ClienteModel)
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.Cliente_Mdf(ClienteModel);
        }


        public ClassResult Cliente_Elim(ClienteModel ClienteModel)
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.Cliente_Elim(ClienteModel);
        }


        public ClassResult Cliente_ConsUn(ClienteModel ClienteModel)
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.Cliente_ConsUn(ClienteModel);
        }

        public ClassResult Cliente_Cons()
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.Cliente_Cons();
        }


        public DataTable BuscarCliente(ClienteModel ClienteModel)
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.FiltrarCliente(ClienteModel);
        }

        public ClassResult TipoDocIdn_Cons()
        {
            ClienteRepository _ventaRepository = new ClienteRepository();
            return _ventaRepository.TipoDocIdn_Cons();
        }


    }
}
