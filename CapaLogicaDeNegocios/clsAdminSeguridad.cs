using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaDeNegocios
{
     public class clsAdminSeguridad
     {
        public int idEmpleado { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string fechaModifica { get; set; }
        public string usuarioModifica { get; set; }

        Acceso_datos accesoDatos = new Acceso_datos();

        public string ActualizarSeguridad()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdEmpleado", idEmpleado));
                lst.Add(new Cls_Parametros("@StrUsuario", usuario));
                lst.Add(new Cls_Parametros("@StrClave", clave));
                lst.Add(new Cls_Parametros("@StrUsuarioModifico", usuarioModifica));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));

                mensaje = accesoDatos.Ejecutar_procedimiento("actualizar_Seguridad", lst);
            }
            catch(Exception ex)
            {
                mensaje = "Fallo la actualizacion " + ex;
            }
            return mensaje;
        }

        public string EliminarSeguridad()
        {
            string mensaje = "";

            try
            {
                string sentencia = $"Exec Eliminar_Seguridad {idEmpleado}";
                mensaje = accesoDatos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo al borrar la informacion " + ex;
            }

            return mensaje;
        }

        public DataTable ConsultaEmpleadoS()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdEmpleado, strNombre FROM TBLEMPLEADO ";
                DataTable dt = new DataTable();
                Acceso_datos accesoDatos = new Acceso_datos();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultaEmpleadoS(string filtro)
        {
            string sentencia;
            DataTable dt = new DataTable();

            try
            {
                sentencia = $"SELECT TBLSEGURIDAD.StrUsuario, TBLSEGURIDAD.StrClave FROM TBLEMPLEADO INNER JOIN TBLSEGURIDAD " +
                            "ON TBLEMPLEADO.IdEmpleado = TBLSEGURIDAD.IdEmpleado " +
                             $"WHERE TBLEMPLEADO.IdEmpleado = {filtro} ";
                
                Acceso_datos accesoDatos = new Acceso_datos();
                dt = accesoDatos.EjecutarConsulta(sentencia);
               

            }
            catch (Exception)
            {
                dt = null;
            }

            return dt;
        }

        public DataTable ConsultaEmpleadoSeguridaId(int Id)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLSEGURIDAD  where IdEmpleado ={Id} ";
                DataTable dt = new DataTable();
                Acceso_datos accesoDatos = new Acceso_datos();
                dt = accesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }




    }
}
