using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System;
using System.Data;


namespace CapaLogicaDeNegocios
{
    public class Validar_usuario
    {
        public string c_Usuario { get; set; }
        public string c_Clave { get; set; }
        public Int32 c_IdEmpleado { get; set; }

        public void ValidarUsuario()
        {
            try
            {
                string sentencia = $"SELECT IdEmpleado, StrUsuario, StrClave FROM TBLSEGURIDAD WHERE StrUsuario='{c_Usuario}' AND StrClave='{c_Clave}'";
                DataTable dt = new DataTable();
                Acceso_datos accesoDatos = new Acceso_datos();
                dt = accesoDatos.EjecutarConsulta(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    c_IdEmpleado = int.Parse(row[0].ToString());
                }
                    
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
