using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaDeNegocios
{
    public class clsEmpleados
    {
        public int c_IdEmpleado { get; set; }
        public string c_Nombre { get; set; }
        public double c_Documento { get; set; }
        public string c_Direccion { get; set; }
        public string c_Telefono { get; set; }
        public string c_Email { get; set; }
        public string c_RolEmpleado { get; set; }
        public string c_DatosAdicionales { get; set; }
        public string c_UsuarioModifica { get; set; }

        Acceso_datos accesoDatos = new Acceso_datos();

        public string ActualizarEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdEmpleado", c_IdEmpleado));
                lst.Add(new Cls_Parametros("@strNombre", c_Nombre));
                lst.Add(new Cls_Parametros("@NumDocumento", c_Documento));
                lst.Add(new Cls_Parametros("@StrDireccion", c_Direccion));
                lst.Add(new Cls_Parametros("@StrTelefono", c_Telefono));
                lst.Add(new Cls_Parametros("@StrEmail", c_Email));
                lst.Add(new Cls_Parametros("@IdRolEmpleado", c_RolEmpleado));
                lst.Add(new Cls_Parametros("@DtmIngreso", DateTime.Now));
                lst.Add(new Cls_Parametros("@DtmRetiro", DateTime.Now));
                lst.Add(new Cls_Parametros("@strDatosAdicionales", c_DatosAdicionales));
                lst.Add(new Cls_Parametros("@StrUsuarioModifico", c_UsuarioModifica));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));

                mensaje = accesoDatos.Ejecutar_procedimiento("[actualizar_Empleado]", lst);

            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion del cliente " + ex;
            }

            return mensaje;
        }

        public string EliminarCliente()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Empleado {c_IdEmpleado}";
                mensaje = accesoDatos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo al borrar el empleado " + ex;
            }

            return mensaje;
        }

        public DataTable ConsultarEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES";
                DataTable dataTable = new DataTable();
                Acceso_datos accesoDatos = new Acceso_datos();
                dataTable = accesoDatos.EjecutarConsulta(sentencia);
                return dataTable;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarEmpleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE strNombre LIKE '%{filtro}%'";
                DataTable dataTable = new DataTable();
                Acceso_datos accesoDatos = new Acceso_datos();
                dataTable = accesoDatos.EjecutarConsulta(sentencia);
                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultaEmpleadoId(int Id)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLEMPLEADO where IdEmpleado ={Id} ";
                DataTable dataTable = new DataTable();
                Acceso_datos accesoDatos = new Acceso_datos();
                dataTable = accesoDatos.EjecutarConsulta(sentencia);
                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
