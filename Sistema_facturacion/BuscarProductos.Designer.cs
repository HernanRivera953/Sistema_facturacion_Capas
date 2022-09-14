namespace Sistema_facturacion
{
    partial class BuscarProductos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNuevoProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.ColuCodigoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuCantidadS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEditarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColuBorrarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelBuscarProductos = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSalirProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNuevoProducto);
            this.panel2.Controls.Add(this.dataProductos);
            this.panel2.Controls.Add(this.textBuscarProducto);
            this.panel2.Controls.Add(this.buttonBuscarProducto);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 273);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonNuevoProducto
            // 
            this.buttonNuevoProducto.AutoSize = true;
            this.buttonNuevoProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNuevoProducto.Depth = 0;
            this.buttonNuevoProducto.Icon = null;
            this.buttonNuevoProducto.Location = new System.Drawing.Point(555, 30);
            this.buttonNuevoProducto.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoProducto.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNuevoProducto.Name = "buttonNuevoProducto";
            this.buttonNuevoProducto.Primary = true;
            this.buttonNuevoProducto.Size = new System.Drawing.Size(90, 30);
            this.buttonNuevoProducto.TabIndex = 17;
            this.buttonNuevoProducto.Text = "Nuevo";
            this.buttonNuevoProducto.UseVisualStyleBackColor = true;
            this.buttonNuevoProducto.Click += new System.EventHandler(this.buttonNuevoProducto_Click);
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToAddRows = false;
            this.dataProductos.AllowUserToDeleteRows = false;
            this.dataProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuCodigoReferencia,
            this.ColuNombreProducto,
            this.ColuPrecioCompra,
            this.ColuPrecioVenta,
            this.ColuCantidadS,
            this.ColuEditarProducto,
            this.ColuBorrarProducto});
            this.dataProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataProductos.Location = new System.Drawing.Point(3, 66);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            this.dataProductos.Size = new System.Drawing.Size(647, 202);
            this.dataProductos.TabIndex = 16;
            this.dataProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductos_CellContentClick);
            // 
            // ColuCodigoReferencia
            // 
            this.ColuCodigoReferencia.HeaderText = "Codigo Referencia";
            this.ColuCodigoReferencia.Name = "ColuCodigoReferencia";
            this.ColuCodigoReferencia.ReadOnly = true;
            this.ColuCodigoReferencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuCodigoReferencia.Width = 120;
            // 
            // ColuNombreProducto
            // 
            this.ColuNombreProducto.HeaderText = "Nombre Producto";
            this.ColuNombreProducto.Name = "ColuNombreProducto";
            this.ColuNombreProducto.ReadOnly = true;
            this.ColuNombreProducto.Width = 223;
            // 
            // ColuPrecioCompra
            // 
            this.ColuPrecioCompra.HeaderText = "Precio Compra";
            this.ColuPrecioCompra.Name = "ColuPrecioCompra";
            this.ColuPrecioCompra.ReadOnly = true;
            this.ColuPrecioCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuPrecioCompra.Width = 130;
            // 
            // ColuPrecioVenta
            // 
            this.ColuPrecioVenta.HeaderText = "Precio Venta";
            this.ColuPrecioVenta.Name = "ColuPrecioVenta";
            this.ColuPrecioVenta.ReadOnly = true;
            this.ColuPrecioVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuPrecioVenta.Width = 120;
            // 
            // ColuCantidadS
            // 
            this.ColuCantidadS.HeaderText = "Cantidad Stock";
            this.ColuCantidadS.Name = "ColuCantidadS";
            this.ColuCantidadS.ReadOnly = true;
            this.ColuCantidadS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuCantidadS.Width = 110;
            // 
            // ColuEditarProducto
            // 
            this.ColuEditarProducto.HeaderText = "Editar";
            this.ColuEditarProducto.Name = "ColuEditarProducto";
            this.ColuEditarProducto.ReadOnly = true;
            this.ColuEditarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuEditarProducto.Text = "Editar";
            this.ColuEditarProducto.UseColumnTextForButtonValue = true;
            this.ColuEditarProducto.Width = 85;
            // 
            // ColuBorrarProducto
            // 
            this.ColuBorrarProducto.HeaderText = "Borrar";
            this.ColuBorrarProducto.Name = "ColuBorrarProducto";
            this.ColuBorrarProducto.ReadOnly = true;
            this.ColuBorrarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuBorrarProducto.Text = "Borrar";
            this.ColuBorrarProducto.UseColumnTextForButtonValue = true;
            this.ColuBorrarProducto.Width = 85;
            // 
            // textBuscarProducto
            // 
            this.textBuscarProducto.Depth = 0;
            this.textBuscarProducto.Hint = "Buscar Producto";
            this.textBuscarProducto.Location = new System.Drawing.Point(24, 30);
            this.textBuscarProducto.MaxLength = 32767;
            this.textBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBuscarProducto.Name = "textBuscarProducto";
            this.textBuscarProducto.PasswordChar = '\0';
            this.textBuscarProducto.SelectedText = "";
            this.textBuscarProducto.SelectionLength = 0;
            this.textBuscarProducto.SelectionStart = 0;
            this.textBuscarProducto.Size = new System.Drawing.Size(257, 23);
            this.textBuscarProducto.TabIndex = 15;
            this.textBuscarProducto.TabStop = false;
            this.textBuscarProducto.UseSystemPasswordChar = false;
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.AutoSize = true;
            this.buttonBuscarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscarProducto.Depth = 0;
            this.buttonBuscarProducto.Icon = null;
            this.buttonBuscarProducto.Location = new System.Drawing.Point(287, 30);
            this.buttonBuscarProducto.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarProducto.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Primary = true;
            this.buttonBuscarProducto.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscarProducto.TabIndex = 10;
            this.buttonBuscarProducto.Text = "Buscar";
            this.buttonBuscarProducto.UseVisualStyleBackColor = true;
            this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
            // 
            // labelBuscarProductos
            // 
            this.labelBuscarProductos.AutoSize = true;
            this.labelBuscarProductos.Depth = 0;
            this.labelBuscarProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBuscarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBuscarProductos.Location = new System.Drawing.Point(307, 9);
            this.labelBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBuscarProductos.Name = "labelBuscarProductos";
            this.labelBuscarProductos.Size = new System.Drawing.Size(156, 19);
            this.labelBuscarProductos.TabIndex = 19;
            this.labelBuscarProductos.Text = "BUSCAR PRODUCTOS";
            // 
            // buttonSalirProductos
            // 
            this.buttonSalirProductos.AutoSize = true;
            this.buttonSalirProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirProductos.Depth = 0;
            this.buttonSalirProductos.Icon = null;
            this.buttonSalirProductos.Location = new System.Drawing.Point(577, 310);
            this.buttonSalirProductos.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirProductos.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirProductos.Name = "buttonSalirProductos";
            this.buttonSalirProductos.Primary = true;
            this.buttonSalirProductos.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirProductos.TabIndex = 20;
            this.buttonSalirProductos.Text = "Salir";
            this.buttonSalirProductos.UseVisualStyleBackColor = true;
            this.buttonSalirProductos.Click += new System.EventHandler(this.buttonSalirProductos_Click);
            // 
            // BuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(670, 354);
            this.Controls.Add(this.buttonSalirProductos);
            this.Controls.Add(this.labelBuscarProductos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProductos";
            this.Load += new System.EventHandler(this.BuscarProductos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBuscarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBuscarProducto;
        private MaterialSkin.Controls.MaterialLabel labelBuscarProductos;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNuevoProducto;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuCodigoReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuCantidadS;
        private System.Windows.Forms.DataGridViewButtonColumn ColuEditarProducto;
        private System.Windows.Forms.DataGridViewButtonColumn ColuBorrarProducto;
    }
}