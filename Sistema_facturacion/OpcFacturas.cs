using System;
using System.Data;
using CapaLogicaDeNegocios;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class OpcFacturas : Form
    {
        clsFacturas clsFacturas = new clsFacturas();
        public OpcFacturas()
        {
            InitializeComponent();
        }

        private void buttonSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpcFacturas_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void buttonNuevaFactura_Click(object sender, EventArgs e)
        {
            CreacionFactura factura = new CreacionFactura();
            factura.NumeroFactura = 0;
            factura.ShowDialog();
            llenar_grid();
        }

        private void dataInformacionFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataInformacionFactura.Columns[e.ColumnIndex].Name == "ColuEditar")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataInformacionFactura.CurrentRow.Index;
                // llama al otro formulario
                CreacionFactura factura = new CreacionFactura();
                factura.NumeroFactura = int.Parse(dataInformacionFactura[0, posActual].Value.ToString());
                factura.ShowDialog();
                llenar_grid();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBuscaPorCliente_Click(object sender, EventArgs e)
        {

        }

        public void llenar_grid()
        {
            dataInformacionFactura.Rows.Clear();
            DataTable dataTable = clsFacturas.ConsultarFactura();
            foreach(DataRow row in dataTable.Rows)
            {
                dataInformacionFactura.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        public void buscar()
        {
            dataInformacionFactura.Rows.Clear();
            DataTable dataTable = clsFacturas.ConsultarFactura(textBuscaPorCliente.Text);
            foreach (DataRow row in dataTable.Rows)
            {
                dataInformacionFactura.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        private void buttonBuscarFactura_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
