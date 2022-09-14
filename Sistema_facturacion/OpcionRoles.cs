using System;
using System.Data;
using CapaLogicaDeNegocios;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class OpcionRoles : Form
    {
        clsRoles clsRoles = new clsRoles();
        public OpcionRoles()
        {
            InitializeComponent();
        }

        private void buttonSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpcionRoles_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void buttonNuevoRol_Click(object sender, EventArgs e)
        {
            CrearEditarRol roles = new CrearEditarRol();
            roles.NumeroRoles = 0;
            roles.ShowDialog();
            llenar_grid();
        }

        private void dataRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si la columna que se presiono es igual al nombre de ColuBorrarRol, entonces
            //realice las siguientes instrucciones   
            if (dataRoles.Columns[e.ColumnIndex].Name == "ColuBorrarRol")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataRoles.CurrentRow.Index;
                string mensaje = $"Id Rol:{dataRoles[0, posActual].Value.ToString()},  {dataRoles[1, posActual].Value.ToString()}";
                //Sale un mensaje preguntando si se esta seguro de eliminar el Rol, si la respuesta es si
                if (MessageBox.Show("¿Seguro que desea borrar este Rol?\n\n"+mensaje, "Borrar Rol de empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsRoles.c_ID_Rol = Convert.ToInt32(dataRoles[0, posActual].Value.ToString());
                    MessageBox.Show(clsRoles.EliminarRol());
                    llenar_grid();
                }
            }
            //si la columna que se presiono es igual al nombre de ColuEditarRol, entonces
            //realice las siguientes instrucciones   
            if (dataRoles.Columns[e.ColumnIndex].Name == "ColuEditarRol")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataRoles.CurrentRow.Index;
                // llama al otro formulario
                CrearEditarRol RolesEditar = new CrearEditarRol();
                RolesEditar.NumeroRoles = int.Parse(dataRoles[0, posActual].Value.ToString());
                RolesEditar.ShowDialog();
                llenar_grid();
            }
        }

        private void labelRoles_Click(object sender, EventArgs e)
        {

        }

        public void llenar_grid()
        {
            dataRoles.Rows.Clear();
            DataTable dataTable = clsRoles.ConsultarRoles();

            foreach(DataRow row in dataTable.Rows)
            {
                dataRoles.Rows.Add(row[0], row[1]);
            }
        }

        private void buttonBuscarRol_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void buscar()
        {
            dataRoles.Rows.Clear();
            DataTable dataTable = clsRoles.BuscarRol(textBuscarRol.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                dataRoles.Rows.Add(row[0], row[1]);
            }
        }
    }
}
