using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ClassResult
    {
        public bool HuboError { get; set; }
        public string ErrorMsj { get; set; }
        public string LugarError { get; set; }
        public string Detalle { get; set; }
        public string Codigo { get; set; }
        public int Id { get; set; }
        public  DataTable  Dt1 { get; set; }
        public DataTable Dt2 { get; set; }
        public DataTable Dt3 { get; set; }
        //List<DtoB> list;
        //DtoB entidad;
    }
}
