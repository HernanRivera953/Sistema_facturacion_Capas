using CapaLogicaDeNegocios;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class OpcClientes : MaterialForm
    {
        public OpcClientes()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }
        clsClientes capaLog_Clientes = new clsClientes();

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TextTelefono_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (Validar())
            {
                try
                {
                    capaLog_Clientes.c_IdCliente = IdCliente;
                    capaLog_Clientes.c_Nombre = textNombreCliente.Text;
                    capaLog_Clientes.c_Documento = Convert.ToDouble(textDocumentoCliente.Text);
                    capaLog_Clientes.c_Direccion = textDireccionCliente.Text;
                    capaLog_Clientes.c_Telefono = TextTelefonoCliente.Text;
                    capaLog_Clientes.c_Email = textEmailCliente.Text;
                    capaLog_Clientes.c_UsuarioModifica = "Maria";
                    string mensaje = capaLog_Clientes.ActualizarCliente();
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
            if (textNombreCliente.Text == string.Empty)
            {
                mensajeError.SetError(textNombreCliente, "Debe de ingresar el nombre de el cliente ");
                textNombreCliente.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textNombreCliente, ""); }

            if (textDocumentoCliente.Text == string.Empty)
            {
                mensajeError.SetError(textDocumentoCliente, "Debe de ingresar el documento del cliente");
                textDocumentoCliente.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textDocumentoCliente, ""); }

            if (TextTelefonoCliente.Text == string.Empty)
            {
                mensajeError.SetError(TextTelefonoCliente, "Debe de ingresar el telefono del cliente");
                TextTelefonoCliente.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(TextTelefonoCliente, ""); }

            if (textEmailCliente.Text == string.Empty)
            {
                mensajeError.SetError(textEmailCliente, "Debe de ingresar el Correo del cliente");
                textEmailCliente.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textEmailCliente, ""); }

            if (!Numerico(textDocumentoCliente.Text))
            {
                mensajeError.SetError(textDocumentoCliente, "El documento debe de ser numerico");
                textDocumentoCliente.Focus();
                return false;

            }
            mensajeError.SetError(textDocumentoCliente, "");

            if (!Numerico(TextTelefonoCliente.Text))
            {
                mensajeError.SetError(TextTelefonoCliente, "El Telefono debe de ser numerico");
                TextTelefonoCliente.Focus();
                return false;

            }
            mensajeError.SetError(TextTelefonoCliente, "");

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

        private void OpcClientes_Load(object sender, EventArgs e)
        {

            if (IdCliente == 0)
            {
                labelTituloCliente.Text = "NUEVO CLIENTE";
            }
            else
            {
                labelTituloCliente.Text = "EDITAR CLIENTE";
                var dt = capaLog_Clientes.ConsultaClienteId(IdCliente);
                foreach (DataRow fila in dt.Rows)
                {
                    textBoxIdCliente.Text = fila[0].ToString();
                    textNombreCliente.Text = fila[1].ToString();
                    textDocumentoCliente.Text = fila[2].ToString();
                    textDireccionCliente.Text = fila[3].ToString();
                    TextTelefonoCliente.Text = fila[4].ToString();
                    textEmailCliente.Text = fila[5].ToString();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTituloCliente_Click(object sender, EventArgs e)
        {
        }
    }
}
