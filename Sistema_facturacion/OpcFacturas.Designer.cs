namespace Sistema_facturacion
{
    partial class OpcFacturas
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
            this.dataInformacionFactura = new System.Windows.Forms.DataGridView();
            this.ColuNumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelTituloFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.textBuscaPorCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNuevaFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBuscarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformacionFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataInformacionFactura
            // 
            this.dataInformacionFactura.AllowUserToAddRows = false;
            this.dataInformacionFactura.AllowUserToDeleteRows = false;
            this.dataInformacionFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataInformacionFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInformacionFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuNumFactura,
            this.ColuCliente,
            this.ColuEmision,
            this.ColuValor,
            this.ColuEstado,
            this.ColuEditar});
            this.dataInformacionFactura.Location = new System.Drawing.Point(3, 43);
            this.dataInformacionFactura.Name = "dataInformacionFactura";
            this.dataInformacionFactura.ReadOnly = true;
            this.dataInformacionFactura.Size = new System.Drawing.Size(621, 223);
            this.dataInformacionFactura.TabIndex = 0;
            this.dataInformacionFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInformacionFactura_CellContentClick);
            // 
            // ColuNumFactura
            // 
            this.ColuNumFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColuNumFactura.HeaderText = "Nº Factura";
            this.ColuNumFactura.Name = "ColuNumFactura";
            this.ColuNumFactura.ReadOnly = true;
            this.ColuNumFactura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuNumFactura.Width = 108;
            // 
            // ColuCliente
            // 
            this.ColuCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColuCliente.HeaderText = "Cliente";
            this.ColuCliente.Name = "ColuCliente";
            this.ColuCliente.ReadOnly = true;
            this.ColuCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuCliente.Width = 335;
            // 
            // ColuEmision
            // 
            this.ColuEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColuEmision.HeaderText = "Emision";
            this.ColuEmision.Name = "ColuEmision";
            this.ColuEmision.ReadOnly = true;
            this.ColuEmision.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuEmision.Width = 113;
            // 
            // ColuValor
            // 
            this.ColuValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColuValor.HeaderText = "Valor";
            this.ColuValor.Name = "ColuValor";
            this.ColuValor.ReadOnly = true;
            this.ColuValor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuValor.Width = 125;
            // 
            // ColuEstado
            // 
            this.ColuEstado.HeaderText = "Estado";
            this.ColuEstado.Name = "ColuEstado";
            this.ColuEstado.ReadOnly = true;
            this.ColuEstado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuEstado.Width = 105;
            // 
            // ColuEditar
            // 
            this.ColuEditar.HeaderText = "EDITAR";
            this.ColuEditar.Name = "ColuEditar";
            this.ColuEditar.ReadOnly = true;
            this.ColuEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColuEditar.Text = "Editar";
            this.ColuEditar.ToolTipText = "Editar";
            this.ColuEditar.UseColumnTextForButtonValue = true;
            this.ColuEditar.Width = 103;
            // 
            // labelTituloFacturas
            // 
            this.labelTituloFacturas.AutoSize = true;
            this.labelTituloFacturas.Depth = 0;
            this.labelTituloFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTituloFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTituloFacturas.Location = new System.Drawing.Point(219, 28);
            this.labelTituloFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTituloFacturas.Name = "labelTituloFacturas";
            this.labelTituloFacturas.Size = new System.Drawing.Size(235, 19);
            this.labelTituloFacturas.TabIndex = 1;
            this.labelTituloFacturas.Text = "ADMINISTRACIÓN DE FACTURAS";
            // 
            // textBuscaPorCliente
            // 
            this.textBuscaPorCliente.Depth = 0;
            this.textBuscaPorCliente.Hint = "Buscar por Cliente";
            this.textBuscaPorCliente.Location = new System.Drawing.Point(3, 3);
            this.textBuscaPorCliente.MaxLength = 32767;
            this.textBuscaPorCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBuscaPorCliente.Name = "textBuscaPorCliente";
            this.textBuscaPorCliente.PasswordChar = '\0';
            this.textBuscaPorCliente.SelectedText = "";
            this.textBuscaPorCliente.SelectionLength = 0;
            this.textBuscaPorCliente.SelectionStart = 0;
            this.textBuscaPorCliente.Size = new System.Drawing.Size(290, 23);
            this.textBuscaPorCliente.TabIndex = 2;
            this.textBuscaPorCliente.TabStop = false;
            this.textBuscaPorCliente.UseSystemPasswordChar = false;
            this.textBuscaPorCliente.Click += new System.EventHandler(this.textBuscaPorCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonNuevaFactura);
            this.panel1.Controls.Add(this.buttonBuscarFactura);
            this.panel1.Controls.Add(this.textBuscaPorCliente);
            this.panel1.Controls.Add(this.dataInformacionFactura);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 267);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonNuevaFactura
            // 
            this.buttonNuevaFactura.AutoSize = true;
            this.buttonNuevaFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNuevaFactura.Depth = 0;
            this.buttonNuevaFactura.Icon = null;
            this.buttonNuevaFactura.Location = new System.Drawing.Point(500, 3);
            this.buttonNuevaFactura.MaximumSize = new System.Drawing.Size(124, 30);
            this.buttonNuevaFactura.MinimumSize = new System.Drawing.Size(124, 30);
            this.buttonNuevaFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNuevaFactura.Name = "buttonNuevaFactura";
            this.buttonNuevaFactura.Primary = true;
            this.buttonNuevaFactura.Size = new System.Drawing.Size(124, 30);
            this.buttonNuevaFactura.TabIndex = 5;
            this.buttonNuevaFactura.Text = "NUEVA FACTURA";
            this.buttonNuevaFactura.UseVisualStyleBackColor = true;
            this.buttonNuevaFactura.Click += new System.EventHandler(this.buttonNuevaFactura_Click);
            // 
            // buttonBuscarFactura
            // 
            this.buttonBuscarFactura.AutoSize = true;
            this.buttonBuscarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscarFactura.Depth = 0;
            this.buttonBuscarFactura.Icon = null;
            this.buttonBuscarFactura.Location = new System.Drawing.Point(299, 3);
            this.buttonBuscarFactura.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarFactura.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBuscarFactura.Name = "buttonBuscarFactura";
            this.buttonBuscarFactura.Primary = true;
            this.buttonBuscarFactura.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscarFactura.TabIndex = 4;
            this.buttonBuscarFactura.Text = "Buscar";
            this.buttonBuscarFactura.UseVisualStyleBackColor = true;
            this.buttonBuscarFactura.Click += new System.EventHandler(this.buttonBuscarFactura_Click);
            // 
            // buttonSalirCliente
            // 
            this.buttonSalirCliente.AutoSize = true;
            this.buttonSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirCliente.Depth = 0;
            this.buttonSalirCliente.Icon = null;
            this.buttonSalirCliente.Location = new System.Drawing.Point(551, 346);
            this.buttonSalirCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirCliente.Name = "buttonSalirCliente";
            this.buttonSalirCliente.Primary = true;
            this.buttonSalirCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirCliente.TabIndex = 6;
            this.buttonSalirCliente.Text = "Salir";
            this.buttonSalirCliente.UseVisualStyleBackColor = true;
            this.buttonSalirCliente.Click += new System.EventHandler(this.buttonSalirCliente_Click);
            // 
            // OpcFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(653, 383);
            this.Controls.Add(this.buttonSalirCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTituloFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcFacturas";
            this.Text = "OpcFacturas";
            this.Load += new System.EventHandler(this.OpcFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataInformacionFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataInformacionFactura;
        private MaterialSkin.Controls.MaterialLabel labelTituloFacturas;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBuscaPorCliente;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNuevaFactura;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBuscarFactura;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuEstado;
        private System.Windows.Forms.DataGridViewButtonColumn ColuEditar;
    }
}