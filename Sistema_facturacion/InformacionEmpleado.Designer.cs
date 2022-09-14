namespace Sistema_facturacion
{
    partial class InformacionEmpleado
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
            this.labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.textNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxIdEmpleado = new System.Windows.Forms.TextBox();
            this.buttonActualizarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimeFRetiro = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFIngresos = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRolEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxDatosAEmpleado = new System.Windows.Forms.TextBox();
            this.labelDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.labelFRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.labelFIngresos = new MaterialSkin.Controls.MaterialLabel();
            this.labelRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.textEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textDirecciónEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Depth = 0;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitulo.Location = new System.Drawing.Point(302, 74);
            this.labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(59, 19);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TITULO";
            // 
            // textNombreEmpleado
            // 
            this.textNombreEmpleado.Depth = 0;
            this.textNombreEmpleado.Hint = "NombreEmpleado";
            this.textNombreEmpleado.Location = new System.Drawing.Point(7, 40);
            this.textNombreEmpleado.MaxLength = 32767;
            this.textNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNombreEmpleado.Name = "textNombreEmpleado";
            this.textNombreEmpleado.PasswordChar = '\0';
            this.textNombreEmpleado.SelectedText = "";
            this.textNombreEmpleado.SelectionLength = 0;
            this.textNombreEmpleado.SelectionStart = 0;
            this.textNombreEmpleado.Size = new System.Drawing.Size(246, 23);
            this.textNombreEmpleado.TabIndex = 1;
            this.textNombreEmpleado.TabStop = false;
            this.textNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSalirEmpleado);
            this.panel1.Controls.Add(this.textBoxIdEmpleado);
            this.panel1.Controls.Add(this.buttonActualizarEmpleado);
            this.panel1.Controls.Add(this.dateTimeFRetiro);
            this.panel1.Controls.Add(this.dateTimeFIngresos);
            this.panel1.Controls.Add(this.comboBoxRolEmpleado);
            this.panel1.Controls.Add(this.textBoxDatosAEmpleado);
            this.panel1.Controls.Add(this.labelDatosAdicionales);
            this.panel1.Controls.Add(this.labelFRetiro);
            this.panel1.Controls.Add(this.labelFIngresos);
            this.panel1.Controls.Add(this.labelRolEmpleado);
            this.panel1.Controls.Add(this.textEmailEmpleado);
            this.panel1.Controls.Add(this.textDirecciónEmpleado);
            this.panel1.Controls.Add(this.textDocumentoEmpleado);
            this.panel1.Controls.Add(this.textTelefonoEmpleado);
            this.panel1.Controls.Add(this.textNombreEmpleado);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 282);
            this.panel1.TabIndex = 2;
            // 
            // buttonSalirEmpleado
            // 
            this.buttonSalirEmpleado.AutoSize = true;
            this.buttonSalirEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirEmpleado.Depth = 0;
            this.buttonSalirEmpleado.Icon = null;
            this.buttonSalirEmpleado.Location = new System.Drawing.Point(585, 247);
            this.buttonSalirEmpleado.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirEmpleado.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirEmpleado.Name = "buttonSalirEmpleado";
            this.buttonSalirEmpleado.Primary = true;
            this.buttonSalirEmpleado.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirEmpleado.TabIndex = 6;
            this.buttonSalirEmpleado.Text = "Salir";
            this.buttonSalirEmpleado.UseVisualStyleBackColor = true;
            this.buttonSalirEmpleado.Click += new System.EventHandler(this.buttonSalirEmpleado_Click);
            // 
            // textBoxIdEmpleado
            // 
            this.textBoxIdEmpleado.Location = new System.Drawing.Point(7, 3);
            this.textBoxIdEmpleado.Name = "textBoxIdEmpleado";
            this.textBoxIdEmpleado.Size = new System.Drawing.Size(45, 20);
            this.textBoxIdEmpleado.TabIndex = 19;
            this.textBoxIdEmpleado.Visible = false;
            // 
            // buttonActualizarEmpleado
            // 
            this.buttonActualizarEmpleado.AutoSize = true;
            this.buttonActualizarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualizarEmpleado.Depth = 0;
            this.buttonActualizarEmpleado.Icon = null;
            this.buttonActualizarEmpleado.Location = new System.Drawing.Point(573, 121);
            this.buttonActualizarEmpleado.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarEmpleado.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualizarEmpleado.Name = "buttonActualizarEmpleado";
            this.buttonActualizarEmpleado.Primary = true;
            this.buttonActualizarEmpleado.Size = new System.Drawing.Size(90, 30);
            this.buttonActualizarEmpleado.TabIndex = 18;
            this.buttonActualizarEmpleado.Text = "Actualizar";
            this.buttonActualizarEmpleado.UseVisualStyleBackColor = true;
            this.buttonActualizarEmpleado.Click += new System.EventHandler(this.buttonActualizarEmpleado_Click);
            // 
            // dateTimeFRetiro
            // 
            this.dateTimeFRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFRetiro.Location = new System.Drawing.Point(387, 120);
            this.dateTimeFRetiro.Name = "dateTimeFRetiro";
            this.dateTimeFRetiro.Size = new System.Drawing.Size(114, 20);
            this.dateTimeFRetiro.TabIndex = 17;
            // 
            // dateTimeFIngresos
            // 
            this.dateTimeFIngresos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFIngresos.Location = new System.Drawing.Point(387, 75);
            this.dateTimeFIngresos.Name = "dateTimeFIngresos";
            this.dateTimeFIngresos.Size = new System.Drawing.Size(114, 20);
            this.dateTimeFIngresos.TabIndex = 16;
            // 
            // comboBoxRolEmpleado
            // 
            this.comboBoxRolEmpleado.FormattingEnabled = true;
            this.comboBoxRolEmpleado.Location = new System.Drawing.Point(407, 23);
            this.comboBoxRolEmpleado.Name = "comboBoxRolEmpleado";
            this.comboBoxRolEmpleado.Size = new System.Drawing.Size(118, 21);
            this.comboBoxRolEmpleado.TabIndex = 15;
            // 
            // textBoxDatosAEmpleado
            // 
            this.textBoxDatosAEmpleado.Location = new System.Drawing.Point(303, 183);
            this.textBoxDatosAEmpleado.Multiline = true;
            this.textBoxDatosAEmpleado.Name = "textBoxDatosAEmpleado";
            this.textBoxDatosAEmpleado.Size = new System.Drawing.Size(208, 89);
            this.textBoxDatosAEmpleado.TabIndex = 14;
            // 
            // labelDatosAdicionales
            // 
            this.labelDatosAdicionales.AutoSize = true;
            this.labelDatosAdicionales.Depth = 0;
            this.labelDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDatosAdicionales.Location = new System.Drawing.Point(299, 161);
            this.labelDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDatosAdicionales.Name = "labelDatosAdicionales";
            this.labelDatosAdicionales.Size = new System.Drawing.Size(128, 19);
            this.labelDatosAdicionales.TabIndex = 13;
            this.labelDatosAdicionales.Text = "DatosAdicionales";
            // 
            // labelFRetiro
            // 
            this.labelFRetiro.AutoSize = true;
            this.labelFRetiro.Depth = 0;
            this.labelFRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFRetiro.Location = new System.Drawing.Point(316, 121);
            this.labelFRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFRetiro.Name = "labelFRetiro";
            this.labelFRetiro.Size = new System.Drawing.Size(65, 19);
            this.labelFRetiro.TabIndex = 12;
            this.labelFRetiro.Text = "F. Retiro";
            // 
            // labelFIngresos
            // 
            this.labelFIngresos.AutoSize = true;
            this.labelFIngresos.Depth = 0;
            this.labelFIngresos.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFIngresos.Location = new System.Drawing.Point(299, 75);
            this.labelFIngresos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFIngresos.Name = "labelFIngresos";
            this.labelFIngresos.Size = new System.Drawing.Size(83, 19);
            this.labelFIngresos.TabIndex = 11;
            this.labelFIngresos.Text = "F. Ingresos";
            // 
            // labelRolEmpleado
            // 
            this.labelRolEmpleado.AutoSize = true;
            this.labelRolEmpleado.Depth = 0;
            this.labelRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRolEmpleado.Location = new System.Drawing.Point(299, 25);
            this.labelRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRolEmpleado.Name = "labelRolEmpleado";
            this.labelRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.labelRolEmpleado.TabIndex = 10;
            this.labelRolEmpleado.Text = "Rol Empleado";
            // 
            // textEmailEmpleado
            // 
            this.textEmailEmpleado.Depth = 0;
            this.textEmailEmpleado.Hint = "Email";
            this.textEmailEmpleado.Location = new System.Drawing.Point(7, 227);
            this.textEmailEmpleado.MaxLength = 32767;
            this.textEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.textEmailEmpleado.Name = "textEmailEmpleado";
            this.textEmailEmpleado.PasswordChar = '\0';
            this.textEmailEmpleado.SelectedText = "";
            this.textEmailEmpleado.SelectionLength = 0;
            this.textEmailEmpleado.SelectionStart = 0;
            this.textEmailEmpleado.Size = new System.Drawing.Size(246, 23);
            this.textEmailEmpleado.TabIndex = 9;
            this.textEmailEmpleado.TabStop = false;
            this.textEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // textDirecciónEmpleado
            // 
            this.textDirecciónEmpleado.Depth = 0;
            this.textDirecciónEmpleado.Hint = "Dirección";
            this.textDirecciónEmpleado.Location = new System.Drawing.Point(7, 176);
            this.textDirecciónEmpleado.MaxLength = 32767;
            this.textDirecciónEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDirecciónEmpleado.Name = "textDirecciónEmpleado";
            this.textDirecciónEmpleado.PasswordChar = '\0';
            this.textDirecciónEmpleado.SelectedText = "";
            this.textDirecciónEmpleado.SelectionLength = 0;
            this.textDirecciónEmpleado.SelectionStart = 0;
            this.textDirecciónEmpleado.Size = new System.Drawing.Size(246, 23);
            this.textDirecciónEmpleado.TabIndex = 8;
            this.textDirecciónEmpleado.TabStop = false;
            this.textDirecciónEmpleado.UseSystemPasswordChar = false;
            // 
            // textDocumentoEmpleado
            // 
            this.textDocumentoEmpleado.Depth = 0;
            this.textDocumentoEmpleado.Hint = "Documento";
            this.textDocumentoEmpleado.Location = new System.Drawing.Point(7, 86);
            this.textDocumentoEmpleado.MaxLength = 32767;
            this.textDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDocumentoEmpleado.Name = "textDocumentoEmpleado";
            this.textDocumentoEmpleado.PasswordChar = '\0';
            this.textDocumentoEmpleado.SelectedText = "";
            this.textDocumentoEmpleado.SelectionLength = 0;
            this.textDocumentoEmpleado.SelectionStart = 0;
            this.textDocumentoEmpleado.Size = new System.Drawing.Size(246, 23);
            this.textDocumentoEmpleado.TabIndex = 6;
            this.textDocumentoEmpleado.TabStop = false;
            this.textDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // textTelefonoEmpleado
            // 
            this.textTelefonoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.textTelefonoEmpleado.Depth = 0;
            this.textTelefonoEmpleado.Hint = "Teléfono";
            this.textTelefonoEmpleado.Location = new System.Drawing.Point(7, 131);
            this.textTelefonoEmpleado.MaxLength = 32767;
            this.textTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.textTelefonoEmpleado.Name = "textTelefonoEmpleado";
            this.textTelefonoEmpleado.PasswordChar = '\0';
            this.textTelefonoEmpleado.SelectedText = "";
            this.textTelefonoEmpleado.SelectionLength = 0;
            this.textTelefonoEmpleado.SelectionStart = 0;
            this.textTelefonoEmpleado.Size = new System.Drawing.Size(246, 23);
            this.textTelefonoEmpleado.TabIndex = 7;
            this.textTelefonoEmpleado.TabStop = false;
            this.textTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // InformacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(716, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "InformacionEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Empleados";
            this.Load += new System.EventHandler(this.InformacionEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNombreEmpleado;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField textDirecciónEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField textDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField textTelefonoEmpleado;
        private System.Windows.Forms.DateTimePicker dateTimeFRetiro;
        private System.Windows.Forms.DateTimePicker dateTimeFIngresos;
        private System.Windows.Forms.ComboBox comboBoxRolEmpleado;
        private System.Windows.Forms.TextBox textBoxDatosAEmpleado;
        private MaterialSkin.Controls.MaterialLabel labelDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel labelFRetiro;
        private MaterialSkin.Controls.MaterialLabel labelFIngresos;
        private MaterialSkin.Controls.MaterialLabel labelRolEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton buttonActualizarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirEmpleado;
        private System.Windows.Forms.TextBox textBoxIdEmpleado;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}