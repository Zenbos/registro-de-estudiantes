using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadata
{
    public class Profesor
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public string Condicion_medica { get; set; }
        public DateTime Fecha_de_Nacimiento { get; set; }
        public DateTime Fecha_de_Ingreso { get; set; }
        public string Correo_Electronico { get; set; }
        public string Nacionalidad { get; set; }
        public string Titulo { get; set; }
        public string Estatus { get; set; }
     
    }
}
