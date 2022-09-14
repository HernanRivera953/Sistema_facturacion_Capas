using CapaLogicaDeNegocios;
using System;
using System.Data;
using System.Windows.Forms;


namespace Sistema_facturacion
{
    public partial class OpcionEmpleado : Form
    {
        public OpcionEmpleado()
        {
            InitializeComponent();
        }

        clsEmpleados capaLog_Empleados = new clsEmpleados();

        private void LlenarGrid(string filtro = "")
        {
            try
            {
                dataEmpleado.Rows.Clear();
                DataTable dt = capaLog_Empleados.ConsultarEmpleado(filtro);
                foreach (DataRow fila in dt.Rows) { dataEmpleado.Rows.Add(fila[0], fila[1], fila[2], fila[4], fila[5], fila[6]); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un ERROR a la hora de consultar los datos" + ex);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNuevoEmpleado_Click(object sender, EventArgs e)
        {
            InformacionEmpleado empleado = new InformacionEmpleado();
            empleado.idEmpleado = 0;
            empleado.ShowDialog();
            LlenarGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpcionEmpleado_Load(object sender, EventArgs e)
        {
            LlenarGrid();

        }

        private void dataEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si la columna que se presiono es igual al nombre de ColuBorrarEmpleado, entonces
            //realice las siguientes instrucciones   
            if (dataEmpleado.Columns[e.ColumnIndex].Name == "ColuBorrarEmpleado")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataEmpleado.CurrentRow.Index;
                //Sale un mensaje preguntando si se esta seguro de eliminar al empleado, si la respuesta es si
                if (MessageBox.Show($"¿Seguro que desea borrar el Empleado {dataEmpleado[1,posActual].Value.ToString()} ", "Borrar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    capaLog_Empleados.c_IdEmpleado = Convert.ToInt32(dataEmpleado[0, posActual].Value.ToString());
                    string mensaje =  capaLog_Empleados.EliminarCliente();
                    MessageBox.Show(mensaje);
                }
            }
            //si la columna que se presiono es igual al nombre de ColuEditarEmpleado, entonces
            //realice las siguientes instrucciones   
            if (dataEmpleado.Columns[e.ColumnIndex].Name == "ColuEditarEmpleado")
            {
                //toma la posicion que se acabo de presionar
                int posActual = dataEmpleado.CurrentRow.Index;
                // llama al otro formulario
                InformacionEmpleado empleado = new InformacionEmpleado();
                empleado.idEmpleado = int.Parse(dataEmpleado[0, posActual].Value.ToString());

                empleado.ShowDialog();
            }
            LlenarGrid();
        }

        private void buttonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (textBuscarEmpleado.Text != string.Empty)
            {
                LlenarGrid(textBuscarEmpleado.Text);
                textBuscarEmpleado.Text = "";
            }
            else
            {
                LlenarGrid();
                textBuscarEmpleado.Text = "";
            }
        }
    }
}
