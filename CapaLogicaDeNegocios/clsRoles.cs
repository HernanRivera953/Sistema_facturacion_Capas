using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CapaAccesoDatos;
using System.Threading.Tasks;

namespace CapaLogicaDeNegocios
{
    public class clsRoles
    {
        Acceso_datos acceso_Datos = new Acceso_datos();

        public int c_ID_Rol { get; set; }
        public string c_Nombre_Rol { get; set; }

        public string ActualizarRol()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();

                lst.Add(new Cls_Parametros("@IdRolEmpleado", c_ID_Rol));
                lst.Add(new Cls_Parametros("@StrDescripcion", c_Nombre_Rol));

                mensaje = acceso_Datos.Ejecutar_procedimiento("[actualizar_RolEmpleado]", lst);

            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion del Rol " + ex;
            }

            return mensaje;
        }

        public string EliminarRol()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Roles {c_ID_Rol}";
                mensaje = acceso_Datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo al borrar el Rol " + ex;
            }

            return mensaje;
        }

        public DataTable ConsultarRoles()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLROLES";
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

        public DataTable ConsultarRoles(int id_rol)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE IdRolEmpleado = {id_rol}";
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

        public DataTable BuscarRol(string busqueda)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE StrDescripcion LIKE '%{busqueda}%'";
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
