namespace Sistema_facturacion
{
    partial class BuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarClientes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNuevoCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.ColuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuModifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColuBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBuscarClientes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNuevoCliente);
            this.panel2.Controls.Add(this.dataClientes);
            this.panel2.Controls.Add(this.textBuscarClientes);
            this.panel2.Controls.Add(this.buttonBuscarCliente);
            this.panel2.Location = new System.Drawing.Point(5, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 308);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonNuevoCliente
            // 
            this.buttonNuevoCliente.AutoSize = true;
            this.buttonNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNuevoCliente.Depth = 0;
            this.buttonNuevoCliente.Icon = null;
            this.buttonNuevoCliente.Location = new System.Drawing.Point(554, 17);
            this.buttonNuevoCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNuevoCliente.Name = "buttonNuevoCliente";
            this.buttonNuevoCliente.Primary = true;
            this.buttonNuevoCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonNuevoCliente.TabIndex = 5;
            this.buttonNuevoCliente.Text = "Nuevo";
            this.buttonNuevoCliente.UseVisualStyleBackColor = true;
            this.buttonNuevoCliente.Click += new System.EventHandler(this.buttonNuevoCliente_Click);
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuId,
            this.ColuNombre,
            this.ColuDocumento,
            this.ColuTelefono,
            this.ColuEmail,
            this.ColuModifico,
            this.ColuEditar,
            this.ColuBorrar});
            this.dataClientes.Location = new System.Drawing.Point(3, 53);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.Size = new System.Drawing.Size(654, 250);
            this.dataClientes.TabIndex = 4;
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClientes_CellContentClick);
            // 
            // ColuId
            // 
            this.ColuId.HeaderText = "ID";
            this.ColuId.Name = "ColuId";
            this.ColuId.ReadOnly = true;
            this.ColuId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuId.Visible = false;
            this.ColuId.Width = 50;
            // 
            // ColuNombre
            // 
            this.ColuNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColuNombre.HeaderText = "Nombre";
            this.ColuNombre.Name = "ColuNombre";
            this.ColuNombre.ReadOnly = true;
            this.ColuNombre.Width = 240;
            // 
            // ColuDocumento
            // 
            this.ColuDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColuDocumento.HeaderText = "Documento";
            this.ColuDocumento.Name = "ColuDocumento";
            this.ColuDocumento.ReadOnly = true;
            this.ColuDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuDocumento.Width = 110;
            // 
            // ColuTelefono
            // 
            this.ColuTelefono.HeaderText = "Telefono";
            this.ColuTelefono.Name = "ColuTelefono";
            this.ColuTelefono.ReadOnly = true;
            this.ColuTelefono.Width = 110;
            // 
            // ColuEmail
            // 
            this.ColuEmail.HeaderText = "Email";
            this.ColuEmail.Name = "ColuEmail";
            this.ColuEmail.ReadOnly = true;
            this.ColuEmail.Width = 220;
            // 
            // ColuModifico
            // 
            this.ColuModifico.HeaderText = "Modifico";
            this.ColuModifico.Name = "ColuModifico";
            this.ColuModifico.ReadOnly = true;
            // 
            // ColuEditar
            // 
            this.ColuEditar.HeaderText = "Editar";
            this.ColuEditar.Name = "ColuEditar";
            this.ColuEditar.ReadOnly = true;
            this.ColuEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuEditar.Text = "Editar";
            this.ColuEditar.UseColumnTextForButtonValue = true;
            this.ColuEditar.Width = 75;
            // 
            // ColuBorrar
            // 
            this.ColuBorrar.HeaderText = "Borrar";
            this.ColuBorrar.Name = "ColuBorrar";
            this.ColuBorrar.ReadOnly = true;
            this.ColuBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuBorrar.Text = "Borrar";
            this.ColuBorrar.UseColumnTextForButtonValue = true;
            this.ColuBorrar.Width = 75;
            // 
            // textBuscarClientes
            // 
            this.textBuscarClientes.Depth = 0;
            this.textBuscarClientes.Hint = "Buscar Cliente";
            this.textBuscarClientes.Location = new System.Drawing.Point(8, 22);
            this.textBuscarClientes.MaxLength = 32767;
            this.textBuscarClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBuscarClientes.Name = "textBuscarClientes";
            this.textBuscarClientes.PasswordChar = '\0';
            this.textBuscarClientes.SelectedText = "";
            this.textBuscarClientes.SelectionLength = 0;
            this.textBuscarClientes.SelectionStart = 0;
            this.textBuscarClientes.Size = new System.Drawing.Size(274, 23);
            this.textBuscarClientes.TabIndex = 2;
            this.textBuscarClientes.TabStop = false;
            this.textBuscarClientes.UseSystemPasswordChar = false;
            this.textBuscarClientes.Click += new System.EventHandler(this.textBuscarClientes_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.AutoSize = true;
            this.buttonBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscarCliente.Depth = 0;
            this.buttonBuscarCliente.Icon = null;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(288, 15);
            this.buttonBuscarCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Primary = true;
            this.buttonBuscarCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscarCliente.TabIndex = 3;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Depth = 0;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitulo.Location = new System.Drawing.Point(231, 9);
            this.labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(229, 19);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // buttonSalirCliente
            // 
            this.buttonSalirCliente.AutoSize = true;
            this.buttonSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirCliente.Depth = 0;
            this.buttonSalirCliente.Icon = null;
            this.buttonSalirCliente.Location = new System.Drawing.Point(573, 345);
            this.buttonSalirCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirCliente.Name = "buttonSalirCliente";
            this.buttonSalirCliente.Primary = true;
            this.buttonSalirCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.TabIndex = 7;
            this.buttonSalirCliente.Text = "Salir";
            this.buttonSalirCliente.UseVisualStyleBackColor = true;
            this.buttonSalirCliente.Click += new System.EventHandler(this.buttonSalirCliente_Click);
            // 
            // BuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(675, 388);
            this.Controls.Add(this.buttonSalirCliente);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarClientes";
            this.Text = "BuscarClientes";
            this.Load += new System.EventHandler(this.BuscarClientes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBuscarClientes;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBuscarCliente;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirCliente;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNuevoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuModifico;
        private System.Windows.Forms.DataGridViewButtonColumn ColuEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColuBorrar;
    }
}