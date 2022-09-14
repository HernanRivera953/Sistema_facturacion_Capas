namespace Sistema_facturacion
{
    partial class OpcClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textEmailCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textDireccionCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textDocumentoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextTelefonoCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonActualizarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelTituloCliente = new MaterialSkin.Controls.MaterialLabel();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSalirCliente);
            this.panel1.Controls.Add(this.textBoxIdCliente);
            this.panel1.Controls.Add(this.textEmailCliente);
            this.panel1.Controls.Add(this.textDireccionCliente);
            this.panel1.Controls.Add(this.textDocumentoCliente);
            this.panel1.Controls.Add(this.textNombreCliente);
            this.panel1.Controls.Add(this.TextTelefonoCliente);
            this.panel1.Controls.Add(this.buttonActualizarCliente);
            this.panel1.Location = new System.Drawing.Point(21, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 235);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSalirCliente
            // 
            this.buttonSalirCliente.AutoSize = true;
            this.buttonSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirCliente.Depth = 0;
            this.buttonSalirCliente.Icon = null;
            this.buttonSalirCliente.Location = new System.Drawing.Point(325, 200);
            this.buttonSalirCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirCliente.Name = "buttonSalirCliente";
            this.buttonSalirCliente.Primary = true;
            this.buttonSalirCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.TabIndex = 5;
            this.buttonSalirCliente.Text = "Salir";
            this.buttonSalirCliente.UseVisualStyleBackColor = true;
            this.buttonSalirCliente.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(13, 3);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(35, 20);
            this.textBoxIdCliente.TabIndex = 5;
            this.textBoxIdCliente.Visible = false;
            // 
            // textEmailCliente
            // 
            this.textEmailCliente.Depth = 0;
            this.textEmailCliente.Hint = "Email";
            this.textEmailCliente.Location = new System.Drawing.Point(13, 193);
            this.textEmailCliente.MaxLength = 32767;
            this.textEmailCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.textEmailCliente.Name = "textEmailCliente";
            this.textEmailCliente.PasswordChar = '\0';
            this.textEmailCliente.SelectedText = "";
            this.textEmailCliente.SelectionLength = 0;
            this.textEmailCliente.SelectionStart = 0;
            this.textEmailCliente.Size = new System.Drawing.Size(263, 23);
            this.textEmailCliente.TabIndex = 4;
            this.textEmailCliente.TabStop = false;
            this.textEmailCliente.UseSystemPasswordChar = false;
            // 
            // textDireccionCliente
            // 
            this.textDireccionCliente.Depth = 0;
            this.textDireccionCliente.Hint = "Dirección";
            this.textDireccionCliente.Location = new System.Drawing.Point(13, 154);
            this.textDireccionCliente.MaxLength = 32767;
            this.textDireccionCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDireccionCliente.Name = "textDireccionCliente";
            this.textDireccionCliente.PasswordChar = '\0';
            this.textDireccionCliente.SelectedText = "";
            this.textDireccionCliente.SelectionLength = 0;
            this.textDireccionCliente.SelectionStart = 0;
            this.textDireccionCliente.Size = new System.Drawing.Size(263, 23);
            this.textDireccionCliente.TabIndex = 3;
            this.textDireccionCliente.TabStop = false;
            this.textDireccionCliente.UseSystemPasswordChar = false;
            // 
            // textDocumentoCliente
            // 
            this.textDocumentoCliente.Depth = 0;
            this.textDocumentoCliente.Hint = "Documento";
            this.textDocumentoCliente.Location = new System.Drawing.Point(13, 72);
            this.textDocumentoCliente.MaxLength = 32767;
            this.textDocumentoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDocumentoCliente.Name = "textDocumentoCliente";
            this.textDocumentoCliente.PasswordChar = '\0';
            this.textDocumentoCliente.SelectedText = "";
            this.textDocumentoCliente.SelectionLength = 0;
            this.textDocumentoCliente.SelectionStart = 0;
            this.textDocumentoCliente.Size = new System.Drawing.Size(263, 23);
            this.textDocumentoCliente.TabIndex = 1;
            this.textDocumentoCliente.TabStop = false;
            this.textDocumentoCliente.UseSystemPasswordChar = false;
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Depth = 0;
            this.textNombreCliente.Hint = "Nombre";
            this.textNombreCliente.Location = new System.Drawing.Point(13, 30);
            this.textNombreCliente.MaxLength = 32767;
            this.textNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.PasswordChar = '\0';
            this.textNombreCliente.SelectedText = "";
            this.textNombreCliente.SelectionLength = 0;
            this.textNombreCliente.SelectionStart = 0;
            this.textNombreCliente.Size = new System.Drawing.Size(263, 23);
            this.textNombreCliente.TabIndex = 0;
            this.textNombreCliente.TabStop = false;
            this.textNombreCliente.UseSystemPasswordChar = false;
            // 
            // TextTelefonoCliente
            // 
            this.TextTelefonoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.TextTelefonoCliente.Depth = 0;
            this.TextTelefonoCliente.Hint = "Teléfono";
            this.TextTelefonoCliente.Location = new System.Drawing.Point(13, 110);
            this.TextTelefonoCliente.MaxLength = 32767;
            this.TextTelefonoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextTelefonoCliente.Name = "TextTelefonoCliente";
            this.TextTelefonoCliente.PasswordChar = '\0';
            this.TextTelefonoCliente.SelectedText = "";
            this.TextTelefonoCliente.SelectionLength = 0;
            this.TextTelefonoCliente.SelectionStart = 0;
            this.TextTelefonoCliente.Size = new System.Drawing.Size(263, 23);
            this.TextTelefonoCliente.TabIndex = 2;
            this.TextTelefonoCliente.TabStop = false;
            this.TextTelefonoCliente.UseSystemPasswordChar = false;
            this.TextTelefonoCliente.Click += new System.EventHandler(this.TextTelefono_Click);
            // 
            // buttonActualizarCliente
            // 
            this.buttonActualizarCliente.AutoSize = true;
            this.buttonActualizarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualizarCliente.Depth = 0;
            this.buttonActualizarCliente.Icon = null;
            this.buttonActualizarCliente.Location = new System.Drawing.Point(325, 103);
            this.buttonActualizarCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualizarCliente.Name = "buttonActualizarCliente";
            this.buttonActualizarCliente.Primary = true;
            this.buttonActualizarCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonActualizarCliente.TabIndex = 3;
            this.buttonActualizarCliente.Text = "Actualizar";
            this.buttonActualizarCliente.UseVisualStyleBackColor = true;
            this.buttonActualizarCliente.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Depth = 0;
            this.labelTituloCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(177, 74);
            this.labelTituloCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(59, 19);
            this.labelTituloCliente.TabIndex = 1;
            this.labelTituloCliente.Text = "TITULO";
            this.labelTituloCliente.Click += new System.EventHandler(this.labelTituloCliente_Click);
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // OpcClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 359);
            this.Controls.Add(this.labelTituloCliente);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpcClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Clientes";
            this.Load += new System.EventHandler(this.OpcClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel labelTituloCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField textEmailCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField textDireccionCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextTelefonoCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField textDocumentoCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNombreCliente;
        private MaterialSkin.Controls.MaterialRaisedButton buttonActualizarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}