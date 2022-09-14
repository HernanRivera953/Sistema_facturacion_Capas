using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
    public class clsProductos
    {
        Acceso_datos acceso_Datos = new Acceso_datos();

        public int c_ID_Producto { get; set; }
        public int c_Codigo { get; set; }
        public string c_Nombre { get; set; }
        public int c_Precio_Compra { get; set; }
        public int c_Precio_Venta { get; set; }
        public int c_Cantidad_Stock { get; set; }
        public int c_ID_Categoria { get; set; }
        public string c_Ruta_Imagen { get; set; }
        public string c_Detalle_Producto { get; set; }
        public string c_Usuario_Modifica { get; set; }

        public string ActualizarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_Parametros> lst = new List<Cls_Parametros>();
                lst.Add(new Cls_Parametros("@IdProducto", c_ID_Producto));
                lst.Add(new Cls_Parametros("@StrNombre", c_Nombre));
                lst.Add(new Cls_Parametros("@StrCodigo", c_Codigo));
                lst.Add(new Cls_Parametros("@NumPrecioCompra", c_Precio_Compra));
                lst.Add(new Cls_Parametros("@NumPrecioVenta", c_Precio_Venta));
                lst.Add(new Cls_Parametros("@IdCategoria", c_ID_Categoria));
                lst.Add(new Cls_Parametros("@StrDetalle", c_Detalle_Producto));
                lst.Add(new Cls_Parametros("@strFoto", c_Ruta_Imagen));
                lst.Add(new Cls_Parametros("@NumStock", c_Cantidad_Stock));
                lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_Parametros("@StrUsuarioModifica", c_Usuario_Modifica));

                mensaje = acceso_Datos.Ejecutar_procedimiento("[actualizar_Producto]", lst);

            }
            catch (Exception ex)
            {
                mensaje = "Fallo la actualizacion del producto " + ex;
            }

            return mensaje;
        }

        public string EliminarProducto()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Producto {c_ID_Producto}";
                mensaje = acceso_Datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo al borrar el producto " + ex;
            }

            return mensaje;
        }

        public DataTable ConsultarCategoria()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";
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

        public DataTable ConsultarProducto()
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO";
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

        public DataTable BuscarProducto(string busqueda)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre LIKE '%{busqueda}%'";
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

        public DataTable ConsultarProducto(int id_codigo)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrCodigo = {id_codigo}";
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
