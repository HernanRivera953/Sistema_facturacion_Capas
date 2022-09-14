using CapaLogicaDeNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        clsClientes capaLog_Clientes = new clsClientes();

        private void LlenarGrid(string filtro = "")
        {
            try
            {
                dataClientes.Rows.Clear();
                DataTable dt = capaLog_Clientes.ConsultaCliente(filtro);
                foreach (DataRow fila in dt.Rows) { dataClientes.Rows.Add(fila[0], fila[1], fila[2], fila[4], fila[5], fila[7]); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un ERROR a la hora de consultar los datos" + ex);
            }
        }


        private void buttonSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();

        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            OpcClientes Nuevocliente = new OpcClientes();
            Nuevocliente.IdCliente = 0;
            Nuevocliente.ShowDialog();
            LlenarGrid();

        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si la columna que se presiono es igual al nombre de ColuBorrar, entonces
            //realice las siguientes instrucciones   
            if (dataClientes.Columns[e.ColumnIndex].Name == "ColuBorrar")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataClientes.CurrentRow.Index;
                //Sale un mensaje preguntando si se esta seguro de eliminar al cliente, si la respuesta es si
                if (MessageBox.Show($"¿Seguro que desea borrar el cliente {dataClientes[1, posActual].Value.ToString()}", "Borrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    capaLog_Clientes.c_IdCliente = Convert.ToInt32(dataClientes[0, posActual].Value.ToString());
                    string mensaje = capaLog_Clientes.EliminarCliente();
                    MessageBox.Show(mensaje);
                }
            }
            //si la columna que se presiono es igual al nombre de ColuEditar, entonces
            //realice las siguientes instrucciones   
            if (dataClientes.Columns[e.ColumnIndex].Name == "ColuEditar")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataClientes.CurrentRow.Index;
                // llama al otro formulario
                OpcClientes clientes = new OpcClientes();
                clientes.IdCliente = int.Parse(dataClientes[0, posActual].Value.ToString());
                clientes.ShowDialog();
            }
            LlenarGrid();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            if (textBuscarClientes.Text != string.Empty)
            {
                LlenarGrid(textBuscarClientes.Text);
                textBuscarClientes.Text = "";
            }
            else
            {
                LlenarGrid();
                textBuscarClientes.Text = "";
            }
        }

        private void textBuscarClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
