using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class ProductoModel
    {
        public string Cd_Prod { get; set; }

        public int Id_Categoria { get; set; }

        public int Id_Mca { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        public string Descrip { get; set; }

        public string NCorto { get; set; }

        public byte[] CodBarras { get; set; }

        public byte[] Img { get; set; }

        public int? StockMin { get; set; }

        public int? StockMax { get; set; }

        public int? StockActual { get; set; }

        public int IdUsuCrea { get; set; }

        public bool? IB_Estado { get; set; }

        public string TextoBuscar { get; set; }
        

    }
}
