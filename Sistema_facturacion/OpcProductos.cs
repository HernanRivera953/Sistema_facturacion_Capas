using System;
using System.Windows.Forms;
using System.Data;
using CapaLogicaDeNegocios;

namespace Sistema_facturacion
{
    public partial class OpcProductos : Form
    {
        clsProductos clsProductos = new clsProductos();
        public int CodigoProducto { get; set; }

        public OpcProductos()
        {
            InitializeComponent();
        }
        

        private void OpcProductos_Load(object sender, EventArgs e)
        {
            if (CodigoProducto == 0)
            {
                labelTituloProductos.Text = "NUEVO PRODUCTO";
                textBoxIDProducto.Text = "0";
                textBoxIDProducto.Visible = false;

                comboBoxCategorias.DataSource = clsProductos.ConsultarCategoria();
                comboBoxCategorias.ValueMember = "IdCategoria";
                comboBoxCategorias.DisplayMember = "StrDescripcion";
            }
            else
            {
                labelTituloProductos.Text = "EDITAR PRODUCTO";
                textBoxIDProducto.Visible = true;

                DataTable dataTable = clsProductos.ConsultarProducto(CodigoProducto);
                foreach(DataRow Rows in dataTable.Rows)
                {
                    comboBoxCategorias.DataSource = clsProductos.ConsultarCategoria();
                    comboBoxCategorias.ValueMember = "IdCategoria";
                    comboBoxCategorias.DisplayMember = "StrDescripcion";
                    comboBoxCategorias.SelectedValue = Convert.ToInt16(Rows[5].ToString());

                    textBoxIDProducto.Text = Rows[0].ToString();
                    textNombreProducto.Text = Rows[1].ToString();
                    textCodigoReferencia.Text = Rows[2].ToString();
                    textPrecioCompra.Text = Rows[3].ToString();
                    textPrecioVenta.Text = Rows[4].ToString();
                    textCatidadStock.Text = Rows[8].ToString();
                    textRutaImagen.Text = Rows[7].ToString();
                    textBoxDescripcion.Text = Rows[6].ToString();
                }
                
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonActualizarProducto_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                this.Close();
            }
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (Validar())
            {
                try
                {
                    clsProductos.c_ID_Producto = Convert.ToInt32(textBoxIDProducto.Text);
                    clsProductos.c_Nombre = textNombreProducto.Text;
                    clsProductos.c_Codigo = Convert.ToInt32(textCodigoReferencia.Text);
                    clsProductos.c_Precio_Compra = Convert.ToInt32(textPrecioCompra.Text);
                    clsProductos.c_Precio_Venta = Convert.ToInt32(textPrecioVenta.Text);
                    clsProductos.c_Cantidad_Stock = Convert.ToInt32(textCatidadStock.Text);
                    clsProductos.c_ID_Categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
                    clsProductos.c_Ruta_Imagen = textRutaImagen.Text;
                    clsProductos.c_Detalle_Producto = textBoxDescripcion.Text;
                    clsProductos.c_Usuario_Modifica = "Maria & Hernan";
                    string mensaje = clsProductos.ActualizarProducto();
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
            if (textNombreProducto.Text == string.Empty)
            {
                mensajeError.SetError(textNombreProducto, "Debe de ingresar el nombre del Producto");
                textNombreProducto.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textNombreProducto, ""); }

            if (textCodigoReferencia.Text == string.Empty)
            {
                mensajeError.SetError(textCodigoReferencia, "Debe de ingresar el codigo de referencia");
                textCodigoReferencia.Focus();
                errorCampos = false;
            }
            else { mensajeError.SetError(textCodigoReferencia, ""); }

            if (!Numerico(textCodigoReferencia.Text))
            {
                mensajeError.SetError(textCodigoReferencia, "El codigo de referencia debe de ser numerico");
                textCodigoReferencia.Focus();
                return false;

            }
            mensajeError.SetError(textCodigoReferencia, "");


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
