using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CapaAccesoDatos;
using System.Threading.Tasks;

namespace CapaLogicaDeNegocios
{
    public class clsFacturas
    {
        Acceso_datos acceso_Datos = new Acceso_datos();

        public int c_ID_Factura { get; set; }
        public DateTime c_Fecha_Registro { get; set; }
        public int c_ID_Cliente { get; set; }
        public int c_ID_Empleado { get; set; }
        public int c_Numero_descuento { get; set; }
        public int c_Numero_Impuesto { get; set; }
        public int c_Valor_Total { get; set; }
        public int c_ID_Estado { get; set; }

        public string ActualizarFactura()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();

                lst.Add(new Cls_Parametros("@IdFactura", c_ID_Factura));
                lst.Add(new Cls_Parametros("@DtmFecha", c_Fecha_Registro));
                lst.Add(new Cls_Parametros("@IdCliente", c_ID_Cliente));
                lst.Add(new Cls_Parametros("@IdEmpleado", c_ID_Empleado));
                lst.Add(new Cls_Parametros("@NumDescuento", c_Numero_descuento));
                lst.Add(new Cls_Parametros("@NumImpuesto", c_Numero_Impuesto));
                lst.Add(new Cls_Parametros("@NumValorTotal", c_Valor_Total));
                lst.Add(new Cls_Parametros("@IdEstado", c_ID_Estado));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifica", "Maria & Hernan"));

                mensaje = acceso_Datos.Ejecutar_procedimiento("[actualizar_Factura]", lst);

            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion del Rol " + ex;
            }

            return mensaje;
        }

        public DataTable ConsultarFactura()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLFACTURA.DtmFecha, TBLFACTURA.NumValorTotal, TBLESTADO_FACTURA.StrDescripcion" +
                    " FROM TBLFACTURA INNER JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente" +
                    " INNER JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura";
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

        public DataTable ConsultarFactura(string busqueda)
        {
            string sentencia;
            try
            {
                sentencia = "SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLFACTURA.DtmFecha, TBLFACTURA.NumValorTotal, TBLESTADO_FACTURA.StrDescripcion" +
                    " FROM TBLFACTURA INNER JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente" +
                    $" INNER JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura where TBLCLIENTES.StrNombre like '%{busqueda}%'";
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

        public DataTable ConsultarCliente()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdCliente, StrNombre FROM TBLCLIENTES";
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

        public DataTable ConsultarEstadoFactura()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLESTADO_FACTURA";
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

        public DataTable ConsultarEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdEmpleado, strNombre FROM TBLEMPLEADO";
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

        public DataTable ConsultarFacturaDetallada()
        {
            string sentencia;
            try
            {
                sentencia = " SELECT TBLFACTURA.IdFactura, TBLFACTURA.DtmFecha, TBLCLIENTES.StrNombre, TBLEMPLEADO.strNombre, TBLFACTURA.NumDescuento, TBLFACTURA.NumImpuesto," +
                    " TBLFACTURA.NumValorTotal, TBLESTADO_FACTURA.StrDescripcion, TBLFACTURA.DtmFechaModifica, TBLFACTURA.StrUsuarioModifica" +
                    " FROM TBLFACTURA INNER JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente" +
                    " INNER JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado" +
                    " INNER JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura" +
                    $" WHERE TBLFACTURA.IdFactura = {c_ID_Factura}";
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

        public DataTable ConsultarFacturaUnica(int id_factura)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLFACTURA where IdFactura = {id_factura}";
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
