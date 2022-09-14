using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaDeNegocios;
using MaterialSkin.Controls;


namespace Sistema_facturacion
{
    public partial class InformacionEmpleado : MaterialForm
    {
        public InformacionEmpleado()
        {
            InitializeComponent();
        }

        public int idEmpleado { get; set; }
        clsEmpleados capaLog_Empleados = new clsEmpleados();

        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable();
            // llenamos el combo con los clientes empleados
            dt = capaLog_Empleados.ConsultarEmpleado();
            comboBoxRolEmpleado.DataSource = dt;
            comboBoxRolEmpleado.ValueMember = "IdRolEmpleado";
            comboBoxRolEmpleado.DisplayMember = "StrDescripcion";
            
        }

        private void InformacionEmpleado_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
            if (idEmpleado == 0)
            {
                labelTitulo.Text = "NUEVO EMPLEADO";
            }
            else
            {
                labelTitulo.Text = "EDITAR EMPLEADO";
                var dt = capaLog_Empleados.ConsultaEmpleadoId(idEmpleado);
                foreach(DataRow fila in dt.Rows)
                {
                    textBoxIdEmpleado.Text = fila[0].ToString();
                    textNombreEmpleado.Text = fila[1].ToString();
                    textDocumentoEmpleado.Text = fila[2].ToString();
                    textDirecciónEmpleado.Text = fila[3].ToString();
                    textTelefonoEmpleado.Text = fila[4].ToString();
                    textEmailEmpleado.Text = fila[5].ToString();
                    comboBoxRolEmpleado.SelectedValue = fila[6].ToString();
                    dateTimeFIngresos.Text = fila[7].ToString();
                    dateTimeFRetiro.Text = fila[8].ToString();
                    textBoxDatosAEmpleado.Text = fila[9].ToString();
                }
            }
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

        private Boolean Validar()
        {
            Boolean errorCampos = true;
            if (textNombreEmpleado.Text == string.Empty)
            {
                mensajeError.SetError(textNombreEmpleado, "Debe de ingresar el nombre de el Empleado");
                textNombreEmpleado.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textNombreEmpleado, ""); }

            if (textDocumentoEmpleado.Text == string.Empty)
            {
                mensajeError.SetError(textDocumentoEmpleado, "Debe de ingresar el documento de el Empleado");
                textDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textDocumentoEmpleado, ""); }

            if (textTelefonoEmpleado.Text == string.Empty)
            {
                mensajeError.SetError(textTelefonoEmpleado, "Debe de ingresar el telefono de el empleado");
                textTelefonoEmpleado.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textTelefonoEmpleado, ""); }

            if (textEmailEmpleado.Text == string.Empty)
            {
                mensajeError.SetError(textEmailEmpleado, "Debe de ingresar el Correo de el empleado");
                textEmailEmpleado.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textEmailEmpleado, ""); }

            if (!Numerico(textDocumentoEmpleado.Text))
            {
                mensajeError.SetError(textDocumentoEmpleado, "El documento debe de ser numerico");
                textDocumentoEmpleado.Focus();
                return false;

            }
            mensajeError.SetError(textDocumentoEmpleado, "");

            if (!Numerico(textTelefonoEmpleado.Text))
            {
                mensajeError.SetError(textTelefonoEmpleado, "El Telefono debe de ser numerico");
                textTelefonoEmpleado.Focus();
                return false;

            }
            mensajeError.SetError(textTelefonoEmpleado, "");

            return errorCampos;
        }



        public bool Guardar()
        {
            Boolean actualizado = false;
            if (Validar())
            {
                try
                {
                    capaLog_Empleados.c_IdEmpleado = Convert.ToInt32(comboBoxRolEmpleado.SelectedValue);
                    capaLog_Empleados.c_Nombre = textNombreEmpleado.Text;
                    capaLog_Empleados.c_Documento = Convert.ToDouble(textDocumentoEmpleado.Text);
                    capaLog_Empleados.c_Direccion = textDirecciónEmpleado.Text;
                    capaLog_Empleados.c_Telefono = textTelefonoEmpleado.Text;
                    capaLog_Empleados.c_Email = textEmailEmpleado.Text;
                    capaLog_Empleados.c_DatosAdicionales = textBoxDatosAEmpleado.Text;
                    capaLog_Empleados.c_UsuarioModifica = "Maria";//
                    capaLog_Empleados.c_RolEmpleado = comboBoxRolEmpleado.SelectedValue.ToString();
                    string mensaje = capaLog_Empleados.ActualizarEmpleado();
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

        public void LlenarCombo()
        {

        }

        private void buttonSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
