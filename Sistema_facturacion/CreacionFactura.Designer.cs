namespace Sistema_facturacion
{
    partial class CreacionFactura
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
            this.labelTituloFactura = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonActualizarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.textTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textTotalIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textNumFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.datadetalleFactura = new System.Windows.Forms.DataGridView();
            this.ColuIdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuValorT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuFechaModific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuUsuarioModi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloFactura
            // 
            this.labelTituloFactura.AutoSize = true;
            this.labelTituloFactura.Depth = 0;
            this.labelTituloFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTituloFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTituloFactura.Location = new System.Drawing.Point(291, 9);
            this.labelTituloFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTituloFactura.Name = "labelTituloFactura";
            this.labelTituloFactura.Size = new System.Drawing.Size(59, 19);
            this.labelTituloFactura.TabIndex = 0;
            this.labelTituloFactura.Text = "TITULO";
            this.labelTituloFactura.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLimpiar);
            this.panel1.Controls.Add(this.buttonActualizarCliente);
            this.panel1.Controls.Add(this.comboBoxEstado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeFechaRegistro);
            this.panel1.Controls.Add(this.labelFechaRegistro);
            this.panel1.Controls.Add(this.textTotalFactura);
            this.panel1.Controls.Add(this.textTotalIva);
            this.panel1.Controls.Add(this.comboBoxEmpleado);
            this.panel1.Controls.Add(this.comboBoxCliente);
            this.panel1.Controls.Add(this.labelEmpleado);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.textDescuento);
            this.panel1.Controls.Add(this.textNumFactura);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 187);
            this.panel1.TabIndex = 2;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.AutoSize = true;
            this.buttonLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLimpiar.Depth = 0;
            this.buttonLimpiar.Icon = null;
            this.buttonLimpiar.Location = new System.Drawing.Point(472, 75);
            this.buttonLimpiar.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonLimpiar.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Primary = true;
            this.buttonLimpiar.Size = new System.Drawing.Size(90, 30);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonActualizarCliente
            // 
            this.buttonActualizarCliente.AutoSize = true;
            this.buttonActualizarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualizarCliente.Depth = 0;
            this.buttonActualizarCliente.Icon = null;
            this.buttonActualizarCliente.Location = new System.Drawing.Point(472, 22);
            this.buttonActualizarCliente.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarCliente.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualizarCliente.Name = "buttonActualizarCliente";
            this.buttonActualizarCliente.Primary = true;
            this.buttonActualizarCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonActualizarCliente.TabIndex = 12;
            this.buttonActualizarCliente.Text = "Actualizar";
            this.buttonActualizarCliente.UseVisualStyleBackColor = true;
            this.buttonActualizarCliente.Click += new System.EventHandler(this.buttonActualizarCliente_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(299, 84);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(129, 21);
            this.comboBoxEstado.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado Factura";
            // 
            // dateTimeFechaRegistro
            // 
            this.dateTimeFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaRegistro.Location = new System.Drawing.Point(299, 30);
            this.dateTimeFechaRegistro.Name = "dateTimeFechaRegistro";
            this.dateTimeFechaRegistro.Size = new System.Drawing.Size(129, 20);
            this.dateTimeFechaRegistro.TabIndex = 9;
            this.dateTimeFechaRegistro.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistro.Location = new System.Drawing.Point(296, 10);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(104, 17);
            this.labelFechaRegistro.TabIndex = 8;
            this.labelFechaRegistro.Text = "Fecha Registro";
            // 
            // textTotalFactura
            // 
            this.textTotalFactura.Depth = 0;
            this.textTotalFactura.Hint = "TotalFactura";
            this.textTotalFactura.Location = new System.Drawing.Point(13, 150);
            this.textTotalFactura.MaxLength = 32767;
            this.textTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.textTotalFactura.Name = "textTotalFactura";
            this.textTotalFactura.PasswordChar = '\0';
            this.textTotalFactura.SelectedText = "";
            this.textTotalFactura.SelectionLength = 0;
            this.textTotalFactura.SelectionStart = 0;
            this.textTotalFactura.Size = new System.Drawing.Size(206, 23);
            this.textTotalFactura.TabIndex = 7;
            this.textTotalFactura.TabStop = false;
            this.textTotalFactura.UseSystemPasswordChar = false;
            // 
            // textTotalIva
            // 
            this.textTotalIva.Depth = 0;
            this.textTotalIva.Hint = "Total Iva";
            this.textTotalIva.Location = new System.Drawing.Point(13, 120);
            this.textTotalIva.MaxLength = 32767;
            this.textTotalIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.textTotalIva.Name = "textTotalIva";
            this.textTotalIva.PasswordChar = '\0';
            this.textTotalIva.SelectedText = "";
            this.textTotalIva.SelectionLength = 0;
            this.textTotalIva.SelectionStart = 0;
            this.textTotalIva.Size = new System.Drawing.Size(206, 23);
            this.textTotalIva.TabIndex = 6;
            this.textTotalIva.TabStop = false;
            this.textTotalIva.UseSystemPasswordChar = false;
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(87, 64);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(156, 21);
            this.comboBoxEmpleado.TabIndex = 5;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(87, 34);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(155, 21);
            this.comboBoxCliente.TabIndex = 4;
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.Location = new System.Drawing.Point(10, 64);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(71, 17);
            this.labelEmpleado.TabIndex = 3;
            this.labelEmpleado.Text = "Empleado";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(10, 35);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(51, 17);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente";
            // 
            // textDescuento
            // 
            this.textDescuento.Depth = 0;
            this.textDescuento.Hint = "Descuento";
            this.textDescuento.Location = new System.Drawing.Point(13, 91);
            this.textDescuento.MaxLength = 32767;
            this.textDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.PasswordChar = '\0';
            this.textDescuento.SelectedText = "";
            this.textDescuento.SelectionLength = 0;
            this.textDescuento.SelectionStart = 0;
            this.textDescuento.Size = new System.Drawing.Size(206, 23);
            this.textDescuento.TabIndex = 1;
            this.textDescuento.TabStop = false;
            this.textDescuento.UseSystemPasswordChar = false;
            // 
            // textNumFactura
            // 
            this.textNumFactura.Depth = 0;
            this.textNumFactura.Enabled = false;
            this.textNumFactura.Hint = "Nº Factura";
            this.textNumFactura.Location = new System.Drawing.Point(13, 3);
            this.textNumFactura.MaxLength = 32767;
            this.textNumFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNumFactura.Name = "textNumFactura";
            this.textNumFactura.PasswordChar = '\0';
            this.textNumFactura.SelectedText = "";
            this.textNumFactura.SelectionLength = 0;
            this.textNumFactura.SelectionStart = 0;
            this.textNumFactura.Size = new System.Drawing.Size(157, 23);
            this.textNumFactura.TabIndex = 0;
            this.textNumFactura.TabStop = false;
            this.textNumFactura.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datadetalleFactura);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE DE FACTURA";
            // 
            // buttonSalirCliente
            // 
            this.buttonSalirCliente.AutoSize = true;
            this.buttonSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirCliente.Depth = 0;
            this.buttonSalirCliente.Icon = null;
            this.buttonSalirCliente.Location = new System.Drawing.Point(525, 347);
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
            // datadetalleFactura
            // 
            this.datadetalleFactura.AllowUserToAddRows = false;
            this.datadetalleFactura.AllowUserToDeleteRows = false;
            this.datadetalleFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.datadetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuIdFactura,
            this.ColuFecha,
            this.ColuCliente,
            this.ColuEmpleado,
            this.ColuDescuento,
            this.ColuImpuesto,
            this.ColuValorT,
            this.ColuEstado,
            this.ColuFechaModific,
            this.ColuUsuarioModi});
            this.datadetalleFactura.Location = new System.Drawing.Point(6, 19);
            this.datadetalleFactura.Name = "datadetalleFactura";
            this.datadetalleFactura.ReadOnly = true;
            this.datadetalleFactura.Size = new System.Drawing.Size(591, 104);
            this.datadetalleFactura.TabIndex = 1;
            // 
            // ColuIdFactura
            // 
            this.ColuIdFactura.HeaderText = "ID Factura";
            this.ColuIdFactura.Name = "ColuIdFactura";
            this.ColuIdFactura.ReadOnly = true;
            this.ColuIdFactura.Width = 90;
            // 
            // ColuFecha
            // 
            this.ColuFecha.HeaderText = "Fecha";
            this.ColuFecha.Name = "ColuFecha";
            this.ColuFecha.ReadOnly = true;
            // 
            // ColuCliente
            // 
            this.ColuCliente.HeaderText = "Cliente";
            this.ColuCliente.Name = "ColuCliente";
            this.ColuCliente.ReadOnly = true;
            this.ColuCliente.Width = 210;
            // 
            // ColuEmpleado
            // 
            this.ColuEmpleado.HeaderText = "Empleado";
            this.ColuEmpleado.Name = "ColuEmpleado";
            this.ColuEmpleado.ReadOnly = true;
            this.ColuEmpleado.Width = 150;
            // 
            // ColuDescuento
            // 
            this.ColuDescuento.HeaderText = "Descuento";
            this.ColuDescuento.Name = "ColuDescuento";
            this.ColuDescuento.ReadOnly = true;
            // 
            // ColuImpuesto
            // 
            this.ColuImpuesto.HeaderText = "Impuesto";
            this.ColuImpuesto.Name = "ColuImpuesto";
            this.ColuImpuesto.ReadOnly = true;
            // 
            // ColuValorT
            // 
            this.ColuValorT.HeaderText = "Valor Total";
            this.ColuValorT.Name = "ColuValorT";
            this.ColuValorT.ReadOnly = true;
            // 
            // ColuEstado
            // 
            this.ColuEstado.HeaderText = "Estado";
            this.ColuEstado.Name = "ColuEstado";
            this.ColuEstado.ReadOnly = true;
            // 
            // ColuFechaModific
            // 
            this.ColuFechaModific.HeaderText = "Fecha Modificacion";
            this.ColuFechaModific.Name = "ColuFechaModific";
            this.ColuFechaModific.ReadOnly = true;
            // 
            // ColuUsuarioModi
            // 
            this.ColuUsuarioModi.HeaderText = "Usuario Modifico";
            this.ColuUsuarioModi.Name = "ColuUsuarioModi";
            this.ColuUsuarioModi.ReadOnly = true;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // CreacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(637, 391);
            this.Controls.Add(this.buttonSalirCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTituloFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreacionFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreacionFactura";
            this.Load += new System.EventHandler(this.CreacionFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datadetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelTituloFactura;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNumFactura;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Label labelCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField textDescuento;
        private System.Windows.Forms.Label labelFechaRegistro;
        private MaterialSkin.Controls.MaterialSingleLineTextField textTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField textTotalIva;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.DateTimePicker dateTimeFechaRegistro;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonActualizarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLimpiar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirCliente;
        private System.Windows.Forms.DataGridView datadetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuIdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuValorT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuFechaModific;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuUsuarioModi;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}