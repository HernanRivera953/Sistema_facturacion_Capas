using System;
using System.Data;
using CapaLogicaDeNegocios;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class CreacionFactura : Form
    {
        clsFacturas clsFacturas = new clsFacturas();

        public CreacionFactura()
        {
            InitializeComponent();
        }
        public int NumeroFactura { get; set; }

        private void CreacionFactura_Load(object sender, EventArgs e)
        {
            if (NumeroFactura == 0)
            {
                groupBox1.Visible = false;
                textNumFactura.Text = NumeroFactura.ToString();

                labelTituloFactura.Text = "NUEVA FACTURA";

                comboBoxCliente.DataSource = clsFacturas.ConsultarCliente();
                comboBoxCliente.ValueMember = "IdCliente";
                comboBoxCliente.DisplayMember = "StrNombre";

                comboBoxEmpleado.DataSource = clsFacturas.ConsultarEmpleado();
                comboBoxEmpleado.ValueMember = "IdEmpleado";
                comboBoxEmpleado.DisplayMember = "strNombre";

                comboBoxEstado.DataSource = clsFacturas.ConsultarEstadoFactura();
                comboBoxEstado.ValueMember = "IdEstadoFactura";
                comboBoxEstado.DisplayMember = "StrDescripcion";

                dateTimeFechaRegistro.Value = DateTime.Now;
            }
            else
            {
                groupBox1.Visible = true;
                labelTituloFactura.Text = "EDITAR FACTURA";
                textNumFactura.Text = NumeroFactura.ToString();

                comboBoxCliente.DataSource = clsFacturas.ConsultarCliente();
                comboBoxCliente.ValueMember = "IdCliente";
                comboBoxCliente.DisplayMember = "StrNombre";

                comboBoxEmpleado.DataSource = clsFacturas.ConsultarEmpleado();
                comboBoxEmpleado.ValueMember = "IdEmpleado";
                comboBoxEmpleado.DisplayMember = "strNombre";

                comboBoxEstado.DataSource = clsFacturas.ConsultarEstadoFactura();
                comboBoxEstado.ValueMember = "IdEstadoFactura";
                comboBoxEstado.DisplayMember = "StrDescripcion";

                DataTable dataTable = clsFacturas.ConsultarFacturaUnica(NumeroFactura);
                foreach(DataRow row in dataTable.Rows)
                {
                    comboBoxCliente.SelectedValue = row[2].ToString();
                    comboBoxEmpleado.SelectedValue = row[3].ToString();
                    comboBoxEstado.SelectedValue = row[7].ToString();

                    textDescuento.Text = row[4].ToString();
                    textTotalIva.Text = row[5].ToString();
                    textTotalFactura.Text = row[6].ToString();
                    dateTimeFechaRegistro.Value = Convert.ToDateTime(row[1].ToString());
                }

                llenar_grid();
            }
        }

        public void llenar_grid()
        {
            clsFacturas.c_ID_Factura = Convert.ToInt32(textNumFactura.Text);
            DataTable dataTable = clsFacturas.ConsultarFacturaDetallada();
            foreach (DataRow row in dataTable.Rows)
            {
                datadetalleFactura.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        }

        private void buttonSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textDescuento.Text = "";
            textTotalFactura.Text = "";
            textTotalIva.Text = "";

            comboBoxCliente.SelectedValue = "1";
            comboBoxEmpleado.SelectedValue = "1";
            comboBoxEstado.SelectedValue = "1";

            dateTimeFechaRegistro.Value = DateTime.Now;
        }

        private void buttonActualizarCliente_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                llenar_grid();
                DialogResult result = MessageBox.Show("¿Desea seguir editando esta factura?", "Cerrar ventana de edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    this.Close();
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
                    clsFacturas.c_ID_Factura = Convert.ToInt32(textNumFactura.Text);
                    clsFacturas.c_ID_Cliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                    clsFacturas.c_ID_Empleado = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
                    clsFacturas.c_ID_Estado = Convert.ToInt32(comboBoxEstado.SelectedValue);
                    clsFacturas.c_Numero_descuento = Convert.ToInt32(textDescuento.Text);
                    clsFacturas.c_Numero_Impuesto = Convert.ToInt32(textTotalIva.Text);
                    clsFacturas.c_Valor_Total = Convert.ToInt32(textTotalFactura.Text);
                    clsFacturas.c_Fecha_Registro = dateTimeFechaRegistro.Value;
                    string mensaje = clsFacturas.ActualizarFactura();
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

            if (textDescuento.Text == string.Empty)
            {
                mensajeError.SetError(textDescuento, "Debe de ingresar el valor del Descuento");
                textDescuento.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textDescuento, ""); }

            if (textTotalIva.Text == string.Empty)
            {
                mensajeError.SetError(textTotalIva, "Debe de ingresar el valor del IVA");
                textTotalIva.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textTotalIva, ""); }

            if (textTotalFactura.Text == string.Empty)
            {
                mensajeError.SetError(textTotalFactura, "Debe de ingresar el valor Total");
                textTotalFactura.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textTotalFactura, ""); }

            if (!Numerico(textDescuento.Text))
            {
                mensajeError.SetError(textDescuento, "El Descuento debe de ser numerico");
                textDescuento.Focus();
                errorCampos = false;

            }
            mensajeError.SetError(textDescuento, "");

            if (!Numerico(textTotalIva.Text))
            {
                mensajeError.SetError(textTotalIva, "El IVA debe de ser numerico");
                textTotalIva.Focus();
                errorCampos = false;

            }
            mensajeError.SetError(textTotalIva, "");

            if (!Numerico(textTotalFactura.Text))
            {
                mensajeError.SetError(textTotalFactura, "El Descuento debe de ser numerico");
                textTotalFactura.Focus();
                errorCampos = false;

            }
            mensajeError.SetError(textTotalFactura, "");

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
    }
}
