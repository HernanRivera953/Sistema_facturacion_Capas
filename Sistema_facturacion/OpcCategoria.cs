using System;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class OpcCategoria : Form
    {
        public OpcCategoria()
        {
            InitializeComponent();
        }

        private void buttonSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpcCategoria_Load(object sender, EventArgs e)
        {
            //Prueba de llenar el datagridview de Categorias
            for (int i = 1; i < 10; i++)
            {
                dataCategorias.Rows.Add(i, (i * 32451), $"Nombre categoria{i}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si la columna que se presiono es igual al nombre de ColuBorrarCategoria, entonces
            //realice las siguientes instrucciones   
            if (dataCategorias.Columns[e.ColumnIndex].Name == "ColuBorrarCategoria")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataCategorias.CurrentRow.Index;
                //Sale un mensaje preguntando si se esta seguro de eliminar al cliente, si la respuesta es si
                if (MessageBox.Show("¿Seguro que desea borrar esta categoria?", "Borrar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // sale este mensaje
                    MessageBox.Show($"Codigo de Categoria: {dataCategorias[1, posActual].Value.ToString()}");
                }
            }
            if (dataCategorias.Columns[e.ColumnIndex].Name == "ColuEditarCategoria")
            {
                int posActual = dataCategorias.CurrentRow.Index;
                this.panelNuevaCategoria.Visible = true;
                textCodigoCategoria.Text = (dataCategorias[1, posActual].Value.ToString());
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            //Va a mostrar la ventana para la creacion de una nueva categoria o
            //para  editar una categoria existente
            this.panelNuevaCategoria.Visible = true;

        }

        private void panelNuevaCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textNombreCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
