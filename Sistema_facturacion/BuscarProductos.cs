using System;
using System.Windows.Forms;
using System.Data;
using CapaLogicaDeNegocios;

namespace Sistema_facturacion
{
    public partial class BuscarProductos : Form
    {
        clsProductos clsProductos = new clsProductos();
        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void buttonSalirProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNuevoProducto_Click(object sender, EventArgs e)
        {
            OpcProductos productos = new OpcProductos();
            productos.CodigoProducto = 0;
            productos.ShowDialog();
            llenar_grid();
        }

        private void dataProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si la columna que se presiono es igual al nombre de ColuBorrarProducto, entonces
            //realice las siguientes instrucciones   
            if (dataProductos.Columns[e.ColumnIndex].Name == "ColuBorrarProducto")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataProductos.CurrentRow.Index;
                string mensaje = $"Codigo de Referencia: {dataProductos[0, posActual].Value.ToString()}, {dataProductos[1, posActual].Value.ToString()}";
                //Sale un mensaje preguntando si se esta seguro de eliminar al producto, si la respuesta es si
                if (MessageBox.Show("¿Seguro que desea borrar este Producto? \n\n" + mensaje, "Borrar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dataTable = clsProductos.ConsultarProducto(Convert.ToInt32(dataProductos[0, posActual].Value.ToString()));
                    foreach(DataRow Rows in dataTable.Rows)
                    {
                        clsProductos.c_ID_Producto = Convert.ToInt32(Rows[0].ToString());
                    }
                    MessageBox.Show(clsProductos.EliminarProducto());
                    llenar_grid();
                }
            }
            //si la columna que se presiono es igual al nombre de ColuEditar, entonces
            //realice las siguientes instrucciones   
            if (dataProductos.Columns[e.ColumnIndex].Name == "ColuEditarProducto")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataProductos.CurrentRow.Index;
                // llama al otro formulario
                OpcProductos productos = new OpcProductos();
                productos.CodigoProducto = int.Parse(dataProductos[0, posActual].Value.ToString());
                productos.Show();
                llenar_grid();
            }


        }

        public void llenar_grid()
        {
            dataProductos.Rows.Clear();
            DataTable dataTable = clsProductos.ConsultarProducto();
            foreach(DataRow Rows in dataTable.Rows)
            {
                dataProductos.Rows.Add(Rows[2], Rows[1], Rows[3], Rows[4], Rows[8]);
            }
        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            dataProductos.Rows.Clear();
            DataTable dataTable = clsProductos.BuscarProducto(textBuscarProducto.Text);
            foreach (DataRow Rows in dataTable.Rows)
            {
                dataProductos.Rows.Add(Rows[2], Rows[1], Rows[3], Rows[4], Rows[8]);
            }
        }
    }
}
