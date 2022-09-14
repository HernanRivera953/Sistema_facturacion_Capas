using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaDeNegocios;



namespace Sistema_facturacion
{
    public partial class OpcionSeguridad : Form
    {

        clsAdminSeguridad capaLog_Seguridad = new clsAdminSeguridad();
        
        
        public OpcionSeguridad()
        {
            InitializeComponent();
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;
            if (textUsuario.Text == string.Empty)
            {
                mensajeError.SetError(textUsuario, "Debe de ingresar un usuario ");
                textUsuario.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textUsuario, ""); }

            if (textClave.Text == string.Empty)
            {
                mensajeError.SetError(textClave, "Debe de ingresar una clave");
                textClave.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textClave, ""); }

            return errorCampos;
        }

        public void Guardar()
        {
            //Boolean actualizado = false;
            //string mensaje2="";

            if (Validar())
            {
                try
                {

                    capaLog_Seguridad.idEmpleado = Convert.ToInt32(comboxIdEmpleadoS.SelectedValue);
                    capaLog_Seguridad.usuario = textUsuario.Text;
                    capaLog_Seguridad.clave = textClave.Text;

                    capaLog_Seguridad.usuarioModifica = "Maria";//
                    string mensaje = capaLog_Seguridad.ActualizarSeguridad();
                    MessageBox.Show(mensaje);
                    //actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló la actualizacion de datos : " + ex);
                    //actualizado = false;
                }
            }

            //return actualizado;
        }

        public void consultar()
        {
            DataTable dt = new DataTable();
            dt = capaLog_Seguridad.ConsultaEmpleadoS(comboxIdEmpleadoS.SelectedValue.ToString());
            if (dt.Rows.Count > 0) 
            {
                textUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                textClave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no cuenta con datos para el ingreso");
                textUsuario.Text = "";
                textClave.Text = "";
            }
        }

         
        private void buttonSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarComBEmpleados()
        {
            DataTable dt = new DataTable();
            dt = capaLog_Seguridad.ConsultaEmpleadoS();
            comboxIdEmpleadoS.DataSource = dt;
            comboxIdEmpleadoS.DisplayMember = "strNombre";
            comboxIdEmpleadoS.ValueMember = "IdEmpleado";

        }

        private void OpcionSeguridad_Load(object sender, EventArgs e)
        {
            LlenarComBEmpleados();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void buttonActualizarUsuario_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void buttonEliminaUsuario_Click(object sender, EventArgs e)
        {
            capaLog_Seguridad.idEmpleado = Convert.ToInt32(comboxIdEmpleadoS.SelectedValue);
            MessageBox.Show(capaLog_Seguridad.EliminarSeguridad());
        }

        private void comboxIdEmpleadoS_SelectedIndexChanged(object sender, EventArgs e)
        {
            textUsuario.Text = string.Empty;
            textClave.Text = string.Empty;
        }
    }
}
