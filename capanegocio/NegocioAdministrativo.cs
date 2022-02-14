using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capadata;

namespace capanegocio
{
   public class NegocioAdministrativo
    {
        public static string Insertar(string nombre, string apellido,string telefono,string direccion,string cedula,string genero,string condicion_medica, DateTime fecha_de_nacimiento, DateTime fecha_de_ingreso,string correo_electronico,
            string nacionalidad,string titulo,string estatus,string funcion)
         {
           DatosAdministrativo objecto = new DatosAdministrativo();
           objecto.Nombre = nombre;
            objecto.Apellido = apellido;
            objecto.telefono = telefono;
            objecto.Direccion = direccion;
            objecto.Cedula = cedula;
            objecto.Genero = genero;
            objecto.Condicion_medica = condicion_medica;
            objecto.Fecha_de_Nacimiento = fecha_de_nacimiento;
            objecto.Fecha_de_Ingreso = fecha_de_ingreso;
            objecto.Correo_Electronico = correo_electronico;
            objecto.Nacionalidad = nacionalidad;
            objecto.Titulo = titulo;
            objecto.Estatus = estatus;
            objecto.Funcion = funcion;

            return objecto.Insertar(objecto);
         }
      

        public static string Editar(int idadministrativo, string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicion_medica, DateTime fecha_de_nacimiento, DateTime fecha_de_ingreso, string correo_electronico,
             string nacionalidad, string titulo, string estatus, string funcion)
        {
            DatosAdministrativo objecto = new DatosAdministrativo();
            objecto.IdAdministrativo = idadministrativo;
            objecto.Nombre = nombre;
            objecto.Apellido = apellido;
            objecto.telefono = telefono;
            objecto.Direccion = direccion;
            objecto.Cedula = cedula;
            objecto.Genero = genero;
            objecto.Condicion_medica = condicion_medica;
            objecto.Fecha_de_Nacimiento = fecha_de_nacimiento;
            objecto.Fecha_de_Ingreso = fecha_de_ingreso;
            objecto.Correo_Electronico = correo_electronico;
            objecto.Nacionalidad = nacionalidad;
            objecto.Titulo = titulo;
            objecto.Estatus = estatus;
            objecto.Funcion = funcion;

            return objecto.Editar(objecto);
        }
       

        public static string Eliminar(int idadministrativo)
        {
            DatosAdministrativo objecto = new DatosAdministrativo();
            objecto.IdAdministrativo = idadministrativo;

            return objecto.Eliminar(objecto);
        }


        public static DataTable Mostrar()
        {
            return new DatosAdministrativo().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosAdministrativo objecto = new DatosAdministrativo();
            objecto.TextoBuscar = textobuscar;

            return objecto.BuscarNombre(objecto);
        }
        public static DataTable BuscarCdedula(string textobuscar)
        {
            DatosAdministrativo objecto = new DatosAdministrativo();
            objecto.TextoBuscar = textobuscar;

            return objecto.BuscarCedula(objecto);
        }

    
    }
            
}
