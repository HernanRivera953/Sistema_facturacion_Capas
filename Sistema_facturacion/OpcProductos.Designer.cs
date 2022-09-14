namespace Sistema_facturacion
{
    partial class OpcProductos
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
            this.labelTituloProductos = new MaterialSkin.Controls.MaterialLabel();
            this.textNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonActualizarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSalirProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.textCatidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIDProducto = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDetallesProductos = new MaterialSkin.Controls.MaterialLabel();
            this.textRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloProductos
            // 
            this.labelTituloProductos.AutoSize = true;
            this.labelTituloProductos.Depth = 0;
            this.labelTituloProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTituloProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTituloProductos.Location = new System.Drawing.Point(263, 9);
            this.labelTituloProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTituloProductos.Name = "labelTituloProductos";
            this.labelTituloProductos.Size = new System.Drawing.Size(59, 19);
            this.labelTituloProductos.TabIndex = 0;
            this.labelTituloProductos.Text = "TITULO";
            // 
            // textNombreProducto
            // 
            this.textNombreProducto.Depth = 0;
            this.textNombreProducto.Hint = "Nombre Producto";
            this.textNombreProducto.Location = new System.Drawing.Point(3, 41);
            this.textNombreProducto.MaxLength = 32767;
            this.textNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNombreProducto.Name = "textNombreProducto";
            this.textNombreProducto.PasswordChar = '\0';
            this.textNombreProducto.SelectedText = "";
            this.textNombreProducto.SelectionLength = 0;
            this.textNombreProducto.SelectionStart = 0;
            this.textNombreProducto.Size = new System.Drawing.Size(257, 23);
            this.textNombreProducto.TabIndex = 1;
            this.textNombreProducto.TabStop = false;
            this.textNombreProducto.UseSystemPasswordChar = false;
            // 
            // textCodigoReferencia
            // 
            this.textCodigoReferencia.Depth = 0;
            this.textCodigoReferencia.Hint = "Codigo Referencia";
            this.textCodigoReferencia.Location = new System.Drawing.Point(3, 73);
            this.textCodigoReferencia.MaxLength = 32767;
            this.textCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.textCodigoReferencia.Name = "textCodigoReferencia";
            this.textCodigoReferencia.PasswordChar = '\0';
            this.textCodigoReferencia.SelectedText = "";
            this.textCodigoReferencia.SelectionLength = 0;
            this.textCodigoReferencia.SelectionStart = 0;
            this.textCodigoReferencia.Size = new System.Drawing.Size(257, 23);
            this.textCodigoReferencia.TabIndex = 2;
            this.textCodigoReferencia.TabStop = false;
            this.textCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // textPrecioCompra
            // 
            this.textPrecioCompra.Depth = 0;
            this.textPrecioCompra.Hint = "Precio Compra";
            this.textPrecioCompra.Location = new System.Drawing.Point(3, 107);
            this.textPrecioCompra.MaxLength = 32767;
            this.textPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.PasswordChar = '\0';
            this.textPrecioCompra.SelectedText = "";
            this.textPrecioCompra.SelectionLength = 0;
            this.textPrecioCompra.SelectionStart = 0;
            this.textPrecioCompra.Size = new System.Drawing.Size(257, 23);
            this.textPrecioCompra.TabIndex = 4;
            this.textPrecioCompra.TabStop = false;
            this.textPrecioCompra.UseSystemPasswordChar = false;
            // 
            // textPrecioVenta
            // 
            this.textPrecioVenta.Depth = 0;
            this.textPrecioVenta.Hint = "Precio Venta";
            this.textPrecioVenta.Location = new System.Drawing.Point(3, 147);
            this.textPrecioVenta.MaxLength = 32767;
            this.textPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.PasswordChar = '\0';
            this.textPrecioVenta.SelectedText = "";
            this.textPrecioVenta.SelectionLength = 0;
            this.textPrecioVenta.SelectionStart = 0;
            this.textPrecioVenta.Size = new System.Drawing.Size(257, 23);
            this.textPrecioVenta.TabIndex = 5;
            this.textPrecioVenta.TabStop = false;
            this.textPrecioVenta.UseSystemPasswordChar = false;
            // 
            // buttonActualizarProducto
            // 
            this.buttonActualizarProducto.AutoSize = true;
            this.buttonActualizarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualizarProducto.Depth = 0;
            this.buttonActualizarProducto.Icon = null;
            this.buttonActualizarProducto.Location = new System.Drawing.Point(525, 100);
            this.buttonActualizarProducto.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarProducto.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualizarProducto.Name = "buttonActualizarProducto";
            this.buttonActualizarProducto.Primary = true;
            this.buttonActualizarProducto.Size = new System.Drawing.Size(90, 30);
            this.buttonActualizarProducto.TabIndex = 7;
            this.buttonActualizarProducto.Text = "Actualizar";
            this.buttonActualizarProducto.UseVisualStyleBackColor = true;
            this.buttonActualizarProducto.Click += new System.EventHandler(this.buttonActualizarProducto_Click);
            // 
            // buttonSalirProductos
            // 
            this.buttonSalirProductos.AutoSize = true;
            this.buttonSalirProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirProductos.Depth = 0;
            this.buttonSalirProductos.Icon = null;
            this.buttonSalirProductos.Location = new System.Drawing.Point(565, 257);
            this.buttonSalirProductos.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirProductos.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirProductos.Name = "buttonSalirProductos";
            this.buttonSalirProductos.Primary = true;
            this.buttonSalirProductos.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirProductos.TabIndex = 9;
            this.buttonSalirProductos.Text = "Salir";
            this.buttonSalirProductos.UseVisualStyleBackColor = true;
            this.buttonSalirProductos.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Depth = 0;
            this.labelCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCategoria.Location = new System.Drawing.Point(277, 45);
            this.labelCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(74, 19);
            this.labelCategoria.TabIndex = 13;
            this.labelCategoria.Text = "Categoría";
            // 
            // textCatidadStock
            // 
            this.textCatidadStock.Depth = 0;
            this.textCatidadStock.Hint = "Catidad Stock";
            this.textCatidadStock.Location = new System.Drawing.Point(3, 187);
            this.textCatidadStock.MaxLength = 32767;
            this.textCatidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.textCatidadStock.Name = "textCatidadStock";
            this.textCatidadStock.PasswordChar = '\0';
            this.textCatidadStock.SelectedText = "";
            this.textCatidadStock.SelectionLength = 0;
            this.textCatidadStock.SelectionStart = 0;
            this.textCatidadStock.Size = new System.Drawing.Size(257, 23);
            this.textCatidadStock.TabIndex = 14;
            this.textCatidadStock.TabStop = false;
            this.textCatidadStock.UseSystemPasswordChar = false;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(357, 46);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCategorias.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxIDProducto);
            this.panel1.Controls.Add(this.textBoxDescripcion);
            this.panel1.Controls.Add(this.labelDetallesProductos);
            this.panel1.Controls.Add(this.textRutaImagen);
            this.panel1.Controls.Add(this.textCodigoReferencia);
            this.panel1.Controls.Add(this.labelCategoria);
            this.panel1.Controls.Add(this.buttonActualizarProducto);
            this.panel1.Controls.Add(this.comboBoxCategorias);
            this.panel1.Controls.Add(this.textNombreProducto);
            this.panel1.Controls.Add(this.textCatidadStock);
            this.panel1.Controls.Add(this.textPrecioCompra);
            this.panel1.Controls.Add(this.textPrecioVenta);
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 220);
            this.panel1.TabIndex = 16;
            // 
            // textBoxIDProducto
            // 
            this.textBoxIDProducto.Enabled = false;
            this.textBoxIDProducto.Location = new System.Drawing.Point(1, 15);
            this.textBoxIDProducto.Name = "textBoxIDProducto";
            this.textBoxIDProducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDProducto.TabIndex = 19;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(281, 131);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(224, 79);
            this.textBoxDescripcion.TabIndex = 18;
            // 
            // labelDetallesProductos
            // 
            this.labelDetallesProductos.AutoSize = true;
            this.labelDetallesProductos.Depth = 0;
            this.labelDetallesProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDetallesProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDetallesProductos.Location = new System.Drawing.Point(277, 100);
            this.labelDetallesProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDetallesProductos.Name = "labelDetallesProductos";
            this.labelDetallesProductos.Size = new System.Drawing.Size(152, 19);
            this.labelDetallesProductos.TabIndex = 17;
            this.labelDetallesProductos.Text = "Detalles del producto";
            // 
            // textRutaImagen
            // 
            this.textRutaImagen.Depth = 0;
            this.textRutaImagen.Hint = "RutaImagen";
            this.textRutaImagen.Location = new System.Drawing.Point(281, 73);
            this.textRutaImagen.MaxLength = 32767;
            this.textRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.textRutaImagen.Name = "textRutaImagen";
            this.textRutaImagen.PasswordChar = '\0';
            this.textRutaImagen.SelectedText = "";
            this.textRutaImagen.SelectionLength = 0;
            this.textRutaImagen.SelectionStart = 0;
            this.textRutaImagen.Size = new System.Drawing.Size(227, 23);
            this.textRutaImagen.TabIndex = 16;
            this.textRutaImagen.TabStop = false;
            this.textRutaImagen.UseSystemPasswordChar = false;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // OpcProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(667, 299);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSalirProductos);
            this.Controls.Add(this.labelTituloProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.OpcProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelTituloProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField textCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPrecioVenta;
        private MaterialSkin.Controls.MaterialRaisedButton buttonActualizarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirProductos;
        private MaterialSkin.Controls.MaterialLabel labelCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField textCatidadStock;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textRutaImagen;
        private MaterialSkin.Controls.MaterialLabel labelDetallesProductos;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxIDProducto;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}