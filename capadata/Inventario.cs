using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadata
{
   public class Inventario
    {
        public int IdInventario { get; set; }
        public string Nombre { get; set; }
        public string Cantidad_Inicial { get; set; }
        public string Cantidad_total { get; set; }
        public string Provedor { get; set; }
        public string Descripcion { get; set; }
    }
}
