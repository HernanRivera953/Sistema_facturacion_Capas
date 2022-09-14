using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Sistema_facturacion
{
    public partial class VPrincipal : MaterialForm
    {
        public VPrincipal()
        {
            InitializeComponent();
        }

        public void Abrir_Ventana(Form formsecundario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            formsecundario.TopLevel = false;
            formsecundario.FormBorderStyle = FormBorderStyle.None;
            formsecundario.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formsecundario);
            formsecundario.Show();

        }



        private void buttonSalir_Click(object sender, EventArgs e)
        {
            //Cierra la ventana 
            Application.Exit();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            BuscarClientes clientes = new BuscarClientes();
            Abrir_Ventana(clientes);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            //llama a la ventana de productos
            BuscarProductos producto = new BuscarProductos();
            Abrir_Ventana(producto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpcCategoria categoria = new OpcCategoria();
            Abrir_Ventana(categoria);
        }

        private void buttonFacturas_Click(object sender, EventArgs e)
        {
            OpcFacturas facturas = new OpcFacturas();
            Abrir_Ventana(facturas);
        }

        private void buttonInformes_Click(object sender, EventArgs e)
        {
            OpcionInformes informes = new OpcionInformes();
            Abrir_Ventana(informes);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            OpcionEmpleado empleado = new OpcionEmpleado();
            Abrir_Ventana(empleado);
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            OpcionRoles roles = new OpcionRoles();
            Abrir_Ventana(roles);
        }

        private void buttonSeguridad_Click(object sender, EventArgs e)
        {
            OpcionSeguridad seguridad = new OpcionSeguridad();
            Abrir_Ventana(seguridad);
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            OpcAyuda ayuda = new OpcAyuda();
            Abrir_Ventana(ayuda);
        }

        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            OpcAcercade acercade = new OpcAcercade();
            Abrir_Ventana(acercade);
        }
    }
}
