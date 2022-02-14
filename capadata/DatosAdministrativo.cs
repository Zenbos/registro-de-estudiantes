using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace capadata
{
  public class DatosAdministrativo
    {
        public int IdAdministrativo { get; set; }
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
        public string Funcion { get; set; }
        public string TextoBuscar { get; set; }

       //constructor
        public DatosAdministrativo()
        {

        }
        public DatosAdministrativo(int IdAdministrativo, string nombre, string Apellido, string Direccion, string Cedula,
            string Genero,string Condicion_medica,DateTime Fecha_de_Nacimiento,
           DateTime Fecha_de_Ingreso ,string Correo_Electronico,string Nacionalidad,string Titulo,string Estatus,string Funcion)
        {
            this.IdAdministrativo =IdAdministrativo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Cedula = Cedula;
            this.Genero = Genero;
            this.Condicion_medica = Condicion_medica;
            this.Fecha_de_Nacimiento = Fecha_de_Nacimiento;
            this.Fecha_de_Ingreso = Fecha_de_Ingreso;
            this.Correo_Electronico = Correo_Electronico;
            this.Nacionalidad = Nacionalidad;
            this.Titulo = Titulo;
            this.Estatus = Estatus;
            this.Funcion = Funcion;
        }
      //Metodos 
      public string Insertar(DatosAdministrativo Administrativo) 
      {
          string Respuesta= "";
          SqlConnection SqlCon = new SqlConnection();
          try
          {
              SqlCon.ConnectionString = Conexion.CN;
              SqlCon.Open();

              SqlCommand Comando = new SqlCommand();
              Comando.Connection = SqlCon;
              Comando.CommandText = "SP_InsertarAdministrativo";
              Comando.CommandType = CommandType.StoredProcedure;

              SqlParameter ParametroIdAdministrativo = new SqlParameter();
              ParametroIdAdministrativo.ParameterName = "@IdAdministrativo";
              ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
              ParametroIdAdministrativo.Direction = ParameterDirection.Output;
              Comando.Parameters.Add(ParametroIdAdministrativo);

              SqlParameter ParametroNombre = new SqlParameter();
              ParametroNombre.ParameterName = "@Nombre";
              ParametroNombre.SqlDbType = SqlDbType.NVarChar;
              ParametroNombre.Size = 30;
              ParametroNombre.Value = Administrativo.Nombre;
              Comando.Parameters.Add(ParametroNombre);

              SqlParameter ParametroApellido = new SqlParameter();
              ParametroApellido.ParameterName = "@Apellido";
              ParametroApellido.SqlDbType = SqlDbType.NVarChar;
              ParametroApellido.Size = 30;
              ParametroApellido.Value = Administrativo.Apellido;
              Comando.Parameters.Add(ParametroApellido);

              SqlParameter ParametroTelefono = new SqlParameter();
              ParametroTelefono.ParameterName = "@Telefono";
              ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
              ParametroTelefono.Size = 12;
              ParametroTelefono.Value = Administrativo.telefono;
              Comando.Parameters.Add(ParametroTelefono);

              SqlParameter ParametroDireccion = new SqlParameter();
              ParametroDireccion.ParameterName = "@Direccion";
              ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
              ParametroDireccion.Size = 100;
              ParametroDireccion.Value = Administrativo.Direccion;
              Comando.Parameters.Add(ParametroDireccion);

              SqlParameter ParametroCedula = new SqlParameter();
              ParametroCedula.ParameterName = "@Cedula";
              ParametroCedula.SqlDbType = SqlDbType.NVarChar;
              ParametroCedula.Size = 12;
              ParametroCedula.Value = Administrativo.Cedula;
              Comando.Parameters.Add(ParametroCedula);

              SqlParameter ParametroGenero = new SqlParameter();
              ParametroGenero.ParameterName = "@Genero";
              ParametroGenero.SqlDbType = SqlDbType.NVarChar;
              ParametroGenero.Size = 1;
              ParametroGenero.Value = Administrativo.Genero;
              Comando.Parameters.Add(ParametroGenero);

              SqlParameter ParametroCondicion_Medica = new SqlParameter();
              ParametroCondicion_Medica.ParameterName = "@Condicion_Medica";
              ParametroCondicion_Medica.SqlDbType = SqlDbType.NVarChar;
              ParametroCondicion_Medica.Size = 100;
              ParametroCondicion_Medica.Value = Administrativo.Condicion_medica;
              Comando.Parameters.Add(ParametroCondicion_Medica);

              SqlParameter ParametroFecha_Nacimiento = new SqlParameter();
              ParametroFecha_Nacimiento.ParameterName = "@Fecha_de_Nacimiento";
              ParametroFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
              ParametroFecha_Nacimiento.Size = 8;
              ParametroFecha_Nacimiento.Value = Administrativo.Fecha_de_Nacimiento;
              Comando.Parameters.Add(ParametroFecha_Nacimiento);

              SqlParameter ParametroFecha_de_Ingreso = new SqlParameter();
              ParametroFecha_de_Ingreso.ParameterName = "@Fecha_de_Ingreso";
              ParametroFecha_de_Ingreso.SqlDbType = SqlDbType.DateTime;
              ParametroFecha_de_Ingreso.Size = 8;
              ParametroFecha_de_Ingreso.Value = Administrativo.Fecha_de_Ingreso;
              Comando.Parameters.Add(ParametroFecha_de_Ingreso);

              SqlParameter ParametroCorreo_Electronico = new SqlParameter();
              ParametroCorreo_Electronico.ParameterName = "@Correo_Electronico";
              ParametroCorreo_Electronico.SqlDbType = SqlDbType.NVarChar;
              ParametroCorreo_Electronico.Size = 50;
              ParametroCorreo_Electronico.Value = Administrativo.Correo_Electronico;
              Comando.Parameters.Add(ParametroCorreo_Electronico);

              SqlParameter ParametroNacionalidad = new SqlParameter();
              ParametroNacionalidad.ParameterName = "@Nacionalidad";
              ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
              ParametroNacionalidad.Size = 30;
              ParametroNacionalidad.Value = Administrativo.Nacionalidad;
              Comando.Parameters.Add(ParametroNacionalidad);

              SqlParameter ParametroTitulo = new SqlParameter();
              ParametroTitulo.ParameterName = "@Titulo";
              ParametroTitulo.SqlDbType = SqlDbType.NVarChar;
              ParametroTitulo.Size = 50;
              ParametroTitulo.Value = Administrativo.Titulo;
              Comando.Parameters.Add(ParametroTitulo);

              SqlParameter ParametroEstatus = new SqlParameter();
              ParametroEstatus.ParameterName = "@Estatus";
              ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
              ParametroEstatus.Size = 30;
              ParametroEstatus.Value = Administrativo.Estatus;
              Comando.Parameters.Add(ParametroEstatus);

              SqlParameter ParametroFuncion = new SqlParameter();
              ParametroFuncion.ParameterName = "@Funcion";
              ParametroFuncion.SqlDbType = SqlDbType.NVarChar;
              ParametroFuncion.Size = 100;
              ParametroFuncion.Value = Administrativo.Funcion;
              Comando.Parameters.Add(ParametroFuncion);

              Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se inserto correctamenete el registro";

          }
          catch (Exception ex)
          {
              Respuesta = ex.Message + ex.StackTrace + "Insertar CapaDatos  Ardninistrativo.";
          }
      finally
          {
              if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
          } 
          return Respuesta;
      }

      public string Editar(DatosAdministrativo Administrativo)
      {
          string Respuesta = "";
          SqlConnection SqlCon = new SqlConnection();
          try
          {
              SqlCon.ConnectionString = Conexion.CN;
              SqlCon.Open();

              SqlCommand Comando = new SqlCommand();
              Comando.Connection = SqlCon;
              Comando.CommandText = "SP_EditarAdministrativo";
              Comando.CommandType = CommandType.StoredProcedure;

              SqlParameter ParametroIdAdministrativo = new SqlParameter();
              ParametroIdAdministrativo.ParameterName = "@IdAdministrativo";
              ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
              ParametroIdAdministrativo.Value = Administrativo.IdAdministrativo;
              Comando.Parameters.Add(ParametroIdAdministrativo);

              SqlParameter ParametroNombre = new SqlParameter();
              ParametroNombre.ParameterName = "@Nombre";
              ParametroNombre.SqlDbType = SqlDbType.NVarChar;
              ParametroNombre.Size = 30;
              ParametroNombre.Value = Administrativo.Nombre;
              Comando.Parameters.Add(ParametroNombre);

              SqlParameter ParametroApellido = new SqlParameter();
              ParametroApellido.ParameterName = "@Apellido";
              ParametroApellido.SqlDbType = SqlDbType.NVarChar;
              ParametroApellido.Size = 30;
              ParametroApellido.Value = Administrativo.Apellido;
              Comando.Parameters.Add(ParametroApellido);

              SqlParameter ParametroTelefono = new SqlParameter();
              ParametroTelefono.ParameterName = "@Telefono";
              ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
              ParametroTelefono.Size = 12;
              ParametroTelefono.Value = Administrativo.telefono;
              Comando.Parameters.Add(ParametroTelefono);

              SqlParameter ParametroDireccion = new SqlParameter();
              ParametroDireccion.ParameterName = "@Direccion";
              ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
              ParametroDireccion.Size = 100;
              ParametroDireccion.Value = Administrativo.Direccion;
              Comando.Parameters.Add(ParametroDireccion);

              SqlParameter ParametroCedula = new SqlParameter();
              ParametroCedula.ParameterName = "@Cedula";
              ParametroCedula.SqlDbType = SqlDbType.NVarChar;
              ParametroCedula.Size = 12;
              ParametroCedula.Value = Administrativo.Cedula;
              Comando.Parameters.Add(ParametroCedula);

              SqlParameter ParametroGenero = new SqlParameter();
              ParametroGenero.ParameterName = "@Genero";
              ParametroGenero.SqlDbType = SqlDbType.NVarChar;
              ParametroGenero.Size = 1;
              ParametroGenero.Value = Administrativo.Genero;
              Comando.Parameters.Add(ParametroGenero);

              SqlParameter ParametroCondicion_Medica = new SqlParameter();
              ParametroCondicion_Medica.ParameterName = "@Condicion_Medica";
              ParametroCondicion_Medica.SqlDbType = SqlDbType.NVarChar;
              ParametroCondicion_Medica.Size = 100;
              ParametroCondicion_Medica.Value = Administrativo.Condicion_medica;
              Comando.Parameters.Add(ParametroCondicion_Medica);

              SqlParameter ParametroFecha_Nacimiento = new SqlParameter();
              ParametroFecha_Nacimiento.ParameterName = "@Fecha_de_Nacimiento";
              ParametroFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
              ParametroFecha_Nacimiento.Size = 8;
              ParametroFecha_Nacimiento.Value = Administrativo.Fecha_de_Nacimiento;
              Comando.Parameters.Add(ParametroFecha_Nacimiento);

              SqlParameter ParametroFecha_de_Ingreso = new SqlParameter();
              ParametroFecha_de_Ingreso.ParameterName = "@FechaIngreso";
              ParametroFecha_de_Ingreso.SqlDbType = SqlDbType.DateTime;
              ParametroFecha_de_Ingreso.Size = 8;
              ParametroFecha_de_Ingreso.Value = Administrativo.Fecha_de_Ingreso;
              Comando.Parameters.Add(ParametroFecha_de_Ingreso);

              SqlParameter ParametroCorreo_Electronico = new SqlParameter();
              ParametroCorreo_Electronico.ParameterName = "@CorreoElectronico";
              ParametroCorreo_Electronico.SqlDbType = SqlDbType.NVarChar;
              ParametroCorreo_Electronico.Size = 50;
              ParametroCorreo_Electronico.Value = Administrativo.Correo_Electronico;
              Comando.Parameters.Add(ParametroCorreo_Electronico);

              SqlParameter ParametroNacionalidad = new SqlParameter();
              ParametroNacionalidad.ParameterName = "@Nacionalidad";
              ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
              ParametroNacionalidad.Size = 30;
              ParametroNacionalidad.Value = Administrativo.Nacionalidad;
              Comando.Parameters.Add(ParametroNacionalidad);

              SqlParameter ParametroTitulo = new SqlParameter();
              ParametroTitulo.ParameterName = "@Titulo";
              ParametroTitulo.SqlDbType = SqlDbType.NVarChar;
              ParametroTitulo.Size = 50;
              ParametroTitulo.Value = Administrativo.Titulo;
              Comando.Parameters.Add(ParametroTitulo);

              SqlParameter ParametroEstatus = new SqlParameter();
              ParametroEstatus.ParameterName = "@Estatus";
              ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
              ParametroEstatus.Size = 30;
              ParametroEstatus.Value = Administrativo.Estatus;
              Comando.Parameters.Add(ParametroEstatus);

              SqlParameter ParametroFuncion = new SqlParameter();
              ParametroFuncion.ParameterName = "@Funcion";
              ParametroFuncion.SqlDbType = SqlDbType.NVarChar;
              ParametroFuncion.Size = 100;
              ParametroFuncion.Value = Administrativo.Funcion;
              Comando.Parameters.Add(ParametroFuncion);

              Respuesta = Comando.ExecuteNonQuery() == 1 ? " Exelente " : "No se edito correctamenete el registro";
          }
          catch (Exception ex)
          {
              Respuesta = ex.Message + ex.StackTrace + "Editar CapaDatos  Ardninistrativo.";
          }
          finally
          {
              if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
          }
          return Respuesta;
      }



      public string Eliminar(DatosAdministrativo Administrativo)
      {
          string Respuesta = "";
          SqlConnection SqlCon = new SqlConnection();
          try
          {
              SqlCon.ConnectionString = Conexion.CN;
              SqlCon.Open();

              SqlCommand Comando = new SqlCommand();
              Comando.Connection = SqlCon;
              Comando.CommandText = "SP_EliminarAdministrativo";
              Comando.CommandType = CommandType.StoredProcedure;

              SqlParameter ParametroIdAdministrativo = new SqlParameter();
              ParametroIdAdministrativo.ParameterName = "@IdAdministrativo";
              ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
              ParametroIdAdministrativo.Value = Administrativo.IdAdministrativo;
              Comando.Parameters.Add(ParametroIdAdministrativo);

              Respuesta = Comando.ExecuteNonQuery() == 1 ? " Exelente " : "No se elimino correctamenete el registro";

              

          }
          catch (Exception ex)
          {
              Respuesta = ex.Message + ex.StackTrace + "Editar CapaDatos  Ardninistrativo.";
          }
          finally
          {
              if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
          }
          return Respuesta;
      }




       public DataTable Mostrar()
        {

            DataTable DataTableResultado = new DataTable("Administrativa");
            SqlConnection Sqlcon = new SqlConnection();

            try 
	        {	        
		        Sqlcon.ConnectionString = Conexion.CN;
                SqlCommand Command = new SqlCommand();
                Command.Connection = Sqlcon;
                Command.CommandText = "SP_MostrarAdministrativo"; 
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command);
                SQLAdapter.Fill(DataTableResultado);
	        }
	catch (Exception)
	{
		DataTableResultado = null;
		
	}
        return DataTableResultado;
            
    }


       public DataTable BuscarNombre(DatosAdministrativo Administrativo)
       {

           DataTable DataTableResultado = new DataTable("Administrativo");
           SqlConnection Sqlcon = new SqlConnection();
           try
           {
               //codigo fuente
               Sqlcon.ConnectionString = Conexion.CN;
               Sqlcon.Open();

               SqlCommand Command = new SqlCommand();
               Command.Connection = Sqlcon;
               Command.CommandText = "SPbuscarnombre_administrativo";
               Command.CommandType = CommandType.StoredProcedure;

               SqlParameter ParametroBuscarNombre = new SqlParameter();
               ParametroBuscarNombre.ParameterName = "@textobuscar";
               ParametroBuscarNombre.SqlDbType = SqlDbType.VarChar;
               ParametroBuscarNombre.Size = 20;
               ParametroBuscarNombre.Value = Administrativo.TextoBuscar;
               Command.Parameters.Add(ParametroBuscarNombre);


               SqlDataAdapter SQLAdapter = new SqlDataAdapter();
               SQLAdapter.Fill(DataTableResultado);

           }
           catch (Exception)
           {
               DataTableResultado = null;

           }
           finally
           {
               if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
           }

           return DataTableResultado;
       }
       public DataTable BuscarCedula(DatosAdministrativo Administrativo)
       {

           DataTable DataTableResultado = new DataTable("Administrativo");
           SqlConnection Sqlcon = new SqlConnection();
           try
           {
               //codigo fuente
               Sqlcon.ConnectionString = Conexion.CN;
               Sqlcon.Open();

               SqlCommand Command = new SqlCommand();
               Command.Connection = Sqlcon;
               Command.CommandText = "SPbuscarcedula_administrativo";
               Command.CommandType = CommandType.StoredProcedure;

               SqlParameter ParametroBuscarCedula = new SqlParameter();
               ParametroBuscarCedula.ParameterName = "@textobuscar";
               ParametroBuscarCedula.SqlDbType = SqlDbType.VarChar;
               ParametroBuscarCedula.Size = 20;
               ParametroBuscarCedula.Value = Administrativo.TextoBuscar;
               Command.Parameters.Add(ParametroBuscarCedula);


               SqlDataAdapter SQLAdapter = new SqlDataAdapter();
               SQLAdapter.Fill(DataTableResultado);

           }
           catch (Exception)
           {
               DataTableResultado = null;

           }
           finally
           {
               if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
           }

           return DataTableResultado;
       }
       
       }






      }


