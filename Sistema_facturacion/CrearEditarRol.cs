using System;
using System.Data;
using CapaLogicaDeNegocios;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class CrearEditarRol : Form
    {
        clsRoles clsRoles = new clsRoles();
        public CrearEditarRol()
        {
            InitializeComponent();
        }

        public int NumeroRoles { get; set; }

        private void buttonSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearEditarRol_Load(object sender, EventArgs e)
        {
            if (NumeroRoles == 0)
            {
                labelTituloRol.Text = "NUEVO ROL DE EMPLEADOS";
            }
            else
            {
                labelTituloRol.Text = "EDITAR ROL DE EMPLEADOS";
                DataTable dataTable = clsRoles.ConsultarRoles(NumeroRoles);

                foreach(DataRow row in dataTable.Rows)
                {
                    textNumRol.Text = row[0].ToString();
                    textNombreRol.Text = row[1].ToString();
                }
            }
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (Validar())
            {
                try
                {
                    clsRoles.c_ID_Rol = Convert.ToInt32(textNumRol.Text);
                    clsRoles.c_Nombre_Rol = textNombreRol.Text;
                    string mensaje = clsRoles.ActualizarRol();
                    MessageBox.Show(mensaje);
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló la actualizacion de datos : " + ex);
                    actualizado = false;
                }
            }

            return actualizado;
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;
            if (textNombreRol.Text == string.Empty)
            {
                mensajeError.SetError(textNombreRol, "Debe de ingresar el nombre del Rol");
                textNombreRol.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textNombreRol, ""); }

            if (textNumRol.Text == string.Empty)
            {
                mensajeError.SetError(textNumRol, "Debe de ingresar el ID del Rol");
                textNumRol.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textNumRol, ""); }

            if (!Numerico(textNumRol.Text))
            {
                mensajeError.SetError(textNumRol, "El ID del Rol debe de ser numerico");
                textNumRol.Focus();
                errorCampos = false;

            }
            mensajeError.SetError(textNumRol, "");

            if (Numerico(textNumRol.Text))
            {
                if ((Convert.ToInt32(textNumRol.Text))<=0)
                {
                    mensajeError.SetError(textNumRol, "El ID del Rol debe de ser mayor a 0");
                    textNumRol.Focus();
                    errorCampos = false;
                }
                
            }
            mensajeError.SetError(textNumRol, "");

            return errorCampos;
        }

        private bool Numerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void buttonActualizarRol_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                this.Close();
            }
        }
    }
}
