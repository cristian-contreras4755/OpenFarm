﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class CategoriaModel
    {
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Ib_Estado { get; set; }
    }
}
