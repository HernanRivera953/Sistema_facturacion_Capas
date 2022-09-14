namespace Sistema_facturacion
{
    partial class OpcionRoles
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
            this.labelRoles = new MaterialSkin.Controls.MaterialLabel();
            this.textBuscarRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataRoles = new System.Windows.Forms.DataGridView();
            this.ColuNumeRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuNombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEditarRol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColuBorrarRol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNuevoRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBuscarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Depth = 0;
            this.labelRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRoles.Location = new System.Drawing.Point(175, 9);
            this.labelRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(154, 19);
            this.labelRoles.TabIndex = 0;
            this.labelRoles.Text = "ROL DE EMPLEADOS ";
            this.labelRoles.Click += new System.EventHandler(this.labelRoles_Click);
            // 
            // textBuscarRol
            // 
            this.textBuscarRol.Depth = 0;
            this.textBuscarRol.Hint = "Buscar Rol";
            this.textBuscarRol.Location = new System.Drawing.Point(3, 26);
            this.textBuscarRol.MaxLength = 32767;
            this.textBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBuscarRol.Name = "textBuscarRol";
            this.textBuscarRol.PasswordChar = '\0';
            this.textBuscarRol.SelectedText = "";
            this.textBuscarRol.SelectionLength = 0;
            this.textBuscarRol.SelectionStart = 0;
            this.textBuscarRol.Size = new System.Drawing.Size(217, 23);
            this.textBuscarRol.TabIndex = 1;
            this.textBuscarRol.TabStop = false;
            this.textBuscarRol.UseSystemPasswordChar = false;
            // 
            // dataRoles
            // 
            this.dataRoles.AllowUserToAddRows = false;
            this.dataRoles.AllowUserToDeleteRows = false;
            this.dataRoles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuNumeRol,
            this.ColuNombreRol,
            this.ColuEditarRol,
            this.ColuBorrarRol});
            this.dataRoles.Location = new System.Drawing.Point(3, 59);
            this.dataRoles.Name = "dataRoles";
            this.dataRoles.ReadOnly = true;
            this.dataRoles.Size = new System.Drawing.Size(490, 214);
            this.dataRoles.TabIndex = 3;
            this.dataRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRoles_CellContentClick);
            // 
            // ColuNumeRol
            // 
            this.ColuNumeRol.HeaderText = "Nº";
            this.ColuNumeRol.Name = "ColuNumeRol";
            this.ColuNumeRol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuNumeRol.Width = 86;
            // 
            // ColuNombreRol
            // 
            this.ColuNombreRol.HeaderText = "Nombre del Rol";
            this.ColuNombreRol.Name = "ColuNombreRol";
            this.ColuNombreRol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuNombreRol.Width = 226;
            // 
            // ColuEditarRol
            // 
            this.ColuEditarRol.HeaderText = "Editar";
            this.ColuEditarRol.Name = "ColuEditarRol";
            this.ColuEditarRol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuEditarRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColuEditarRol.Text = "Editar";
            this.ColuEditarRol.UseColumnTextForButtonValue = true;
            // 
            // ColuBorrarRol
            // 
            this.ColuBorrarRol.HeaderText = "Borrar";
            this.ColuBorrarRol.Name = "ColuBorrarRol";
            this.ColuBorrarRol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColuBorrarRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColuBorrarRol.Text = "Borrar";
            this.ColuBorrarRol.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonNuevoRol);
            this.panel1.Controls.Add(this.buttonBuscarRol);
            this.panel1.Controls.Add(this.textBuscarRol);
            this.panel1.Controls.Add(this.dataRoles);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 278);
            this.panel1.TabIndex = 4;
            // 
            // buttonNuevoRol
            // 
            this.buttonNuevoRol.AutoSize = true;
            this.buttonNuevoRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNuevoRol.Depth = 0;
            this.buttonNuevoRol.Icon = null;
            this.buttonNuevoRol.Location = new System.Drawing.Point(400, 23);
            this.buttonNuevoRol.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoRol.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNuevoRol.Name = "buttonNuevoRol";
            this.buttonNuevoRol.Primary = true;
            this.buttonNuevoRol.Size = new System.Drawing.Size(90, 30);
            this.buttonNuevoRol.TabIndex = 6;
            this.buttonNuevoRol.Text = "Nuevo";
            this.buttonNuevoRol.UseVisualStyleBackColor = true;
            this.buttonNuevoRol.Click += new System.EventHandler(this.buttonNuevoRol_Click);
            // 
            // buttonBuscarRol
            // 
            this.buttonBuscarRol.AutoSize = true;
            this.buttonBuscarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscarRol.Depth = 0;
            this.buttonBuscarRol.Icon = null;
            this.buttonBuscarRol.Location = new System.Drawing.Point(226, 26);
            this.buttonBuscarRol.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarRol.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBuscarRol.Name = "buttonBuscarRol";
            this.buttonBuscarRol.Primary = true;
            this.buttonBuscarRol.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscarRol.TabIndex = 4;
            this.buttonBuscarRol.Text = "Buscar";
            this.buttonBuscarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarRol.UseVisualStyleBackColor = true;
            this.buttonBuscarRol.Click += new System.EventHandler(this.buttonBuscarRol_Click);
            // 
            // buttonSalirRol
            // 
            this.buttonSalirRol.AutoSize = true;
            this.buttonSalirRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirRol.Depth = 0;
            this.buttonSalirRol.Icon = null;
            this.buttonSalirRol.Location = new System.Drawing.Point(420, 329);
            this.buttonSalirRol.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirRol.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirRol.Name = "buttonSalirRol";
            this.buttonSalirRol.Primary = true;
            this.buttonSalirRol.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirRol.TabIndex = 8;
            this.buttonSalirRol.Text = "Salir";
            this.buttonSalirRol.UseVisualStyleBackColor = true;
            this.buttonSalirRol.Click += new System.EventHandler(this.buttonSalirRol_Click);
            // 
            // OpcionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(528, 364);
            this.Controls.Add(this.buttonSalirRol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionRoles";
            this.Text = "OpcionRoles";
            this.Load += new System.EventHandler(this.OpcionRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRoles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelRoles;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBuscarRol;
        private System.Windows.Forms.DataGridView dataRoles;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBuscarRol;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNuevoRol;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNumeRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNombreRol;
        private System.Windows.Forms.DataGridViewButtonColumn ColuEditarRol;
        private System.Windows.Forms.DataGridViewButtonColumn ColuBorrarRol;
    }
}