using System;
using System.Windows.Forms;
using CapaLogicaDeNegocios;

namespace Sistema_facturacion
{
    public partial class Ingreso : Form
    {
        Validar_usuario validUsuario = new Validar_usuario();

        public Ingreso()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "" && textContraseña.Text != string.Empty)
            {
                validUsuario.c_Clave = textContraseña.Text;
                validUsuario.c_Usuario = textUsuario.Text;
                validUsuario.ValidarUsuario();
                if (validUsuario.c_IdEmpleado != 0)
                {
                    Usuario.setterUsuario(textUsuario.Text);
                    MessageBox.Show($"Bienvenido: {Usuario.getterUsuario()} ");
                    VPrincipal vPrincipal = new VPrincipal(); //Creamos el objeto del formulario FrmPrincipal
                    this.Hide();
                    vPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIOS Y CLAVE NO ENCONTRADOS");
                    textUsuario.Text = "";
                    textUsuario.Focus();
                    textContraseña.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }

        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
    public class Usuario
    {
        public static string usuario;
        public static void setterUsuario(string entrada)
        {
            usuario = entrada;
        }

        public static string getterUsuario()
        {
            return usuario;
        }
    }
}
