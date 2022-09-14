using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaDeNegocios
{
    public class clsClientes
    {
        //Atributos de la clase 
        public int c_IdCliente { get; set; }
        public string c_Nombre { get; set; }
        public double c_Documento { get; set; }
        public string c_Direccion { get; set; }
        public string c_Telefono { get; set; }
        public string c_Email { get; set; }
        public string c_UsuarioModifica { get; set; }

        Acceso_datos accesoDatos = new Acceso_datos();

        public string ActualizarCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();

                lst.Add(new Cls_Parametros("@IdCliente", c_IdCliente));
                lst.Add(new Cls_Parametros("@StrNombre", c_Nombre));
                lst.Add(new Cls_Parametros("@NumDocumento", c_Documento));
                lst.Add(new Cls_Parametros("@StrDireccion", c_Direccion));
                lst.Add(new Cls_Parametros("@StrTelefono", c_Telefono));
                lst.Add(new Cls_Parametros("@StrEmail", c_Email));
                lst.Add(new Cls_Parametros("@StrUsuarioModifica", c_UsuarioModifica));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));

                mensaje = accesoDatos.Ejecutar_procedimiento("actualizar_Cliente", lst);

            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion de el cliente" + ex;

            }

            return mensaje;
        }

        public string EliminarCliente()
        {
            string mensaje = "";

            try
            {
                string sentencia = $"Exec Eliminar_Cliente {c_IdCliente}";
                mensaje = accesoDatos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo al borrar el ciente " + ex;
            }

            return mensaje;
        }

        public DataTable ConsultaCliente()
        {
            string sentencia;
            try
            {
                sentencia = "select * from TBLCLIENTES";
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

        public DataTable ConsultaCliente(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLCLIENTES where StrNombre Like '%{filtro}%' ";
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

        public DataTable ConsultaClienteId(int Id)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLCLIENTES where IdCliente ={Id} ";
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
