namespace Sistema_facturacion
{
    partial class OpcionSeguridad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAdmiUsuarios = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.textUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboxIdEmpleadoS = new System.Windows.Forms.ComboBox();
            this.buttonActualizarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSalirUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEliminaUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdmiUsuarios
            // 
            this.labelAdmiUsuarios.AutoSize = true;
            this.labelAdmiUsuarios.Depth = 0;
            this.labelAdmiUsuarios.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAdmiUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAdmiUsuarios.Location = new System.Drawing.Point(49, 25);
            this.labelAdmiUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAdmiUsuarios.Name = "labelAdmiUsuarios";
            this.labelAdmiUsuarios.Size = new System.Drawing.Size(329, 19);
            this.labelAdmiUsuarios.TabIndex = 0;
            this.labelAdmiUsuarios.Text = "ADMINISTRACION DE USUARIOS DEL SISTEMA";
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Depth = 0;
            this.labelEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmpleado.Location = new System.Drawing.Point(3, 27);
            this.labelEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(76, 19);
            this.labelEmpleado.TabIndex = 1;
            this.labelEmpleado.Text = "Empleado";
            // 
            // textUsuario
            // 
            this.textUsuario.Depth = 0;
            this.textUsuario.Hint = "Usuario ";
            this.textUsuario.Location = new System.Drawing.Point(7, 74);
            this.textUsuario.MaxLength = 32767;
            this.textUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.PasswordChar = '\0';
            this.textUsuario.SelectedText = "";
            this.textUsuario.SelectionLength = 0;
            this.textUsuario.SelectionStart = 0;
            this.textUsuario.Size = new System.Drawing.Size(241, 23);
            this.textUsuario.TabIndex = 2;
            this.textUsuario.TabStop = false;
            this.textUsuario.UseSystemPasswordChar = false;
            // 
            // textClave
            // 
            this.textClave.Depth = 0;
            this.textClave.Hint = "Clave";
            this.textClave.Location = new System.Drawing.Point(7, 127);
            this.textClave.MaxLength = 32767;
            this.textClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '\0';
            this.textClave.SelectedText = "";
            this.textClave.SelectionLength = 0;
            this.textClave.SelectionStart = 0;
            this.textClave.Size = new System.Drawing.Size(241, 23);
            this.textClave.TabIndex = 3;
            this.textClave.TabStop = false;
            this.textClave.UseSystemPasswordChar = false;
            // 
            // comboxIdEmpleadoS
            // 
            this.comboxIdEmpleadoS.FormattingEnabled = true;
            this.comboxIdEmpleadoS.Location = new System.Drawing.Point(85, 27);
            this.comboxIdEmpleadoS.Name = "comboxIdEmpleadoS";
            this.comboxIdEmpleadoS.Size = new System.Drawing.Size(163, 21);
            this.comboxIdEmpleadoS.TabIndex = 4;
            this.comboxIdEmpleadoS.SelectedIndexChanged += new System.EventHandler(this.comboxIdEmpleadoS_SelectedIndexChanged);
            // 
            // buttonActualizarUsuario
            // 
            this.buttonActualizarUsuario.AutoSize = true;
            this.buttonActualizarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualizarUsuario.Depth = 0;
            this.buttonActualizarUsuario.Icon = null;
            this.buttonActualizarUsuario.Location = new System.Drawing.Point(319, 74);
            this.buttonActualizarUsuario.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarUsuario.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            this.buttonActualizarUsuario.Primary = true;
            this.buttonActualizarUsuario.Size = new System.Drawing.Size(90, 30);
            this.buttonActualizarUsuario.TabIndex = 5;
            this.buttonActualizarUsuario.Text = "Actualizar";
            this.buttonActualizarUsuario.UseVisualStyleBackColor = true;
            this.buttonActualizarUsuario.Click += new System.EventHandler(this.buttonActualizarUsuario_Click);
            // 
            // buttonSalirUsuario
            // 
            this.buttonSalirUsuario.AutoSize = true;
            this.buttonSalirUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirUsuario.Depth = 0;
            this.buttonSalirUsuario.Icon = null;
            this.buttonSalirUsuario.Location = new System.Drawing.Point(332, 265);
            this.buttonSalirUsuario.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirUsuario.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirUsuario.Name = "buttonSalirUsuario";
            this.buttonSalirUsuario.Primary = true;
            this.buttonSalirUsuario.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirUsuario.TabIndex = 6;
            this.buttonSalirUsuario.Text = "Salir";
            this.buttonSalirUsuario.UseVisualStyleBackColor = true;
            this.buttonSalirUsuario.Click += new System.EventHandler(this.buttonSalirUsuario_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.AutoSize = true;
            this.buttonConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConsultar.Depth = 0;
            this.buttonConsultar.Icon = null;
            this.buttonConsultar.Location = new System.Drawing.Point(319, 22);
            this.buttonConsultar.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonConsultar.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Primary = true;
            this.buttonConsultar.Size = new System.Drawing.Size(90, 30);
            this.buttonConsultar.TabIndex = 7;
            this.buttonConsultar.Text = "CONSULTAR";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonEliminaUsuario
            // 
            this.buttonEliminaUsuario.AutoSize = true;
            this.buttonEliminaUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEliminaUsuario.Depth = 0;
            this.buttonEliminaUsuario.Icon = null;
            this.buttonEliminaUsuario.Location = new System.Drawing.Point(319, 127);
            this.buttonEliminaUsuario.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonEliminaUsuario.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonEliminaUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminaUsuario.Name = "buttonEliminaUsuario";
            this.buttonEliminaUsuario.Primary = true;
            this.buttonEliminaUsuario.Size = new System.Drawing.Size(90, 30);
            this.buttonEliminaUsuario.TabIndex = 8;
            this.buttonEliminaUsuario.Text = "Eliminar";
            this.buttonEliminaUsuario.UseVisualStyleBackColor = true;
            this.buttonEliminaUsuario.Click += new System.EventHandler(this.buttonEliminaUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textUsuario);
            this.panel1.Controls.Add(this.buttonEliminaUsuario);
            this.panel1.Controls.Add(this.labelEmpleado);
            this.panel1.Controls.Add(this.buttonConsultar);
            this.panel1.Controls.Add(this.textClave);
            this.panel1.Controls.Add(this.comboxIdEmpleadoS);
            this.panel1.Controls.Add(this.buttonActualizarUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 190);
            this.panel1.TabIndex = 9;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // OpcionSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSalirUsuario);
            this.Controls.Add(this.labelAdmiUsuarios);
            this.Name = "OpcionSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.Load += new System.EventHandler(this.OpcionSeguridad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelAdmiUsuarios;
        private MaterialSkin.Controls.MaterialLabel labelEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField textUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField textClave;
        private System.Windows.Forms.ComboBox comboxIdEmpleadoS;
        private MaterialSkin.Controls.MaterialRaisedButton buttonActualizarUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton buttonConsultar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminaUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}