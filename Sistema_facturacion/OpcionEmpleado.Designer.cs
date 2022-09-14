namespace Sistema_facturacion
{
    partial class OpcionEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNuevoEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataEmpleado = new System.Windows.Forms.DataGridView();
            this.ColuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEditarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColuBorrarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonNuevoEmpleado);
            this.panel1.Controls.Add(this.buttonBuscarEmpleado);
            this.panel1.Controls.Add(this.textBuscarEmpleado);
            this.panel1.Controls.Add(this.dataEmpleado);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 313);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonNuevoEmpleado
            // 
            this.buttonNuevoEmpleado.AutoSize = true;
            this.buttonNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNuevoEmpleado.Depth = 0;
            this.buttonNuevoEmpleado.Icon = null;
            this.buttonNuevoEmpleado.Location = new System.Drawing.Point(566, 8);
            this.buttonNuevoEmpleado.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoEmpleado.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNuevoEmpleado.Name = "buttonNuevoEmpleado";
            this.buttonNuevoEmpleado.Primary = true;
            this.buttonNuevoEmpleado.Size = new System.Drawing.Size(90, 30);
            this.buttonNuevoEmpleado.TabIndex = 6;
            this.buttonNuevoEmpleado.Text = "Nuevo";
            this.buttonNuevoEmpleado.UseVisualStyleBackColor = true;
            this.buttonNuevoEmpleado.Click += new System.EventHandler(this.buttonNuevoEmpleado_Click);
            // 
            // buttonBuscarEmpleado
            // 
            this.buttonBuscarEmpleado.AutoSize = true;
            this.buttonBuscarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscarEmpleado.Depth = 0;
            this.buttonBuscarEmpleado.Icon = null;
            this.buttonBuscarEmpleado.Location = new System.Drawing.Point(313, 8);
            this.buttonBuscarEmpleado.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarEmpleado.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBuscarEmpleado.Name = "buttonBuscarEmpleado";
            this.buttonBuscarEmpleado.Primary = true;
            this.buttonBuscarEmpleado.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscarEmpleado.TabIndex = 5;
            this.buttonBuscarEmpleado.Text = "Buscar";
            this.buttonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpleado.Click += new System.EventHandler(this.buttonBuscarEmpleado_Click);
            // 
            // textBuscarEmpleado
            // 
            this.textBuscarEmpleado.Depth = 0;
            this.textBuscarEmpleado.Hint = "Buscar Empleado";
            this.textBuscarEmpleado.Location = new System.Drawing.Point(17, 8);
            this.textBuscarEmpleado.MaxLength = 32767;
            this.textBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBuscarEmpleado.Name = "textBuscarEmpleado";
            this.textBuscarEmpleado.PasswordChar = '\0';
            this.textBuscarEmpleado.SelectedText = "";
            this.textBuscarEmpleado.SelectionLength = 0;
            this.textBuscarEmpleado.SelectionStart = 0;
            this.textBuscarEmpleado.Size = new System.Drawing.Size(290, 23);
            this.textBuscarEmpleado.TabIndex = 3;
            this.textBuscarEmpleado.TabStop = false;
            this.textBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // dataEmpleado
            // 
            this.dataEmpleado.AllowUserToAddRows = false;
            this.dataEmpleado.AllowUserToDeleteRows = false;
            this.dataEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuID,
            this.ColuNombreEmpleado,
            this.ColuDocumento,
            this.ColuTelefono,
            this.ColuEmail,
            this.ColuRol,
            this.ColuEditarEmpleado,
            this.ColuBorrarEmpleado});
            this.dataEmpleado.Location = new System.Drawing.Point(3, 44);
            this.dataEmpleado.Name = "dataEmpleado";
            this.dataEmpleado.ReadOnly = true;
            this.dataEmpleado.Size = new System.Drawing.Size(653, 264);
            this.dataEmpleado.TabIndex = 0;
            this.dataEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmpleado_CellContentClick);
            // 
            // ColuID
            // 
            this.ColuID.HeaderText = "ID";
            this.ColuID.Name = "ColuID";
            this.ColuID.ReadOnly = true;
            this.ColuID.Visible = false;
            this.ColuID.Width = 54;
            // 
            // ColuNombreEmpleado
            // 
            this.ColuNombreEmpleado.HeaderText = "Nombre Empleado";
            this.ColuNombreEmpleado.Name = "ColuNombreEmpleado";
            this.ColuNombreEmpleado.ReadOnly = true;
            this.ColuNombreEmpleado.Width = 236;
            // 
            // ColuDocumento
            // 
            this.ColuDocumento.HeaderText = "Documento";
            this.ColuDocumento.Name = "ColuDocumento";
            this.ColuDocumento.ReadOnly = true;
            this.ColuDocumento.Width = 110;
            // 
            // ColuTelefono
            // 
            this.ColuTelefono.HeaderText = "Teléfono";
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
            // ColuRol
            // 
            this.ColuRol.HeaderText = "Rol";
            this.ColuRol.Name = "ColuRol";
            this.ColuRol.ReadOnly = true;
            // 
            // ColuEditarEmpleado
            // 
            this.ColuEditarEmpleado.HeaderText = "Editar";
            this.ColuEditarEmpleado.Name = "ColuEditarEmpleado";
            this.ColuEditarEmpleado.ReadOnly = true;
            this.ColuEditarEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColuEditarEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColuEditarEmpleado.Text = "Editar";
            this.ColuEditarEmpleado.UseColumnTextForButtonValue = true;
            this.ColuEditarEmpleado.Width = 80;
            // 
            // ColuBorrarEmpleado
            // 
            this.ColuBorrarEmpleado.HeaderText = "Borrar";
            this.ColuBorrarEmpleado.Name = "ColuBorrarEmpleado";
            this.ColuBorrarEmpleado.ReadOnly = true;
            this.ColuBorrarEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColuBorrarEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColuBorrarEmpleado.Text = "Borrar";
            this.ColuBorrarEmpleado.UseColumnTextForButtonValue = true;
            this.ColuBorrarEmpleado.Width = 80;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(191, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(247, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // buttonSalir
            // 
            this.buttonSalir.AutoSize = true;
            this.buttonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalir.Depth = 0;
            this.buttonSalir.Icon = null;
            this.buttonSalir.Location = new System.Drawing.Point(573, 346);
            this.buttonSalir.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalir.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Primary = true;
            this.buttonSalir.Size = new System.Drawing.Size(90, 30);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // OpcionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(668, 392);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionEmpleado";
            this.Text = "OpcionEmpleado";
            this.Load += new System.EventHandler(this.OpcionEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataEmpleado;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNuevoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuRol;
        private System.Windows.Forms.DataGridViewButtonColumn ColuEditarEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn ColuBorrarEmpleado;
    }
}