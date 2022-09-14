namespace Sistema_facturacion
{
    partial class OpcCategoria
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
            this.panelNuevaCategoria = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textCodigoCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1TituloCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataCategorias = new System.Windows.Forms.DataGridView();
            this.ColuNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuCodigoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColuEditarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColuBorrarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonBuscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panelNuevaCategoria.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNuevaCategoria
            // 
            this.panelNuevaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panelNuevaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNuevaCategoria.Controls.Add(this.materialRaisedButton2);
            this.panelNuevaCategoria.Controls.Add(this.textNombreCategoria);
            this.panelNuevaCategoria.Controls.Add(this.textCodigoCategoria);
            this.panelNuevaCategoria.Location = new System.Drawing.Point(164, 206);
            this.panelNuevaCategoria.Name = "panelNuevaCategoria";
            this.panelNuevaCategoria.Size = new System.Drawing.Size(337, 136);
            this.panelNuevaCategoria.TabIndex = 0;
            this.panelNuevaCategoria.Visible = false;
            this.panelNuevaCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNuevaCategoria_Paint);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(242, 53);
            this.materialRaisedButton2.MaximumSize = new System.Drawing.Size(90, 30);
            this.materialRaisedButton2.MinimumSize = new System.Drawing.Size(90, 30);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(90, 30);
            this.materialRaisedButton2.TabIndex = 10;
            this.materialRaisedButton2.Text = "Actualizar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // textNombreCategoria
            // 
            this.textNombreCategoria.Depth = 0;
            this.textNombreCategoria.Hint = "Nombre Categoría";
            this.textNombreCategoria.Location = new System.Drawing.Point(12, 27);
            this.textNombreCategoria.MaxLength = 32767;
            this.textNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNombreCategoria.Name = "textNombreCategoria";
            this.textNombreCategoria.PasswordChar = '\0';
            this.textNombreCategoria.SelectedText = "";
            this.textNombreCategoria.SelectionLength = 0;
            this.textNombreCategoria.SelectionStart = 0;
            this.textNombreCategoria.Size = new System.Drawing.Size(210, 23);
            this.textNombreCategoria.TabIndex = 2;
            this.textNombreCategoria.TabStop = false;
            this.textNombreCategoria.UseSystemPasswordChar = false;
            this.textNombreCategoria.Click += new System.EventHandler(this.textNombreCategoria_Click);
            // 
            // textCodigoCategoria
            // 
            this.textCodigoCategoria.Depth = 0;
            this.textCodigoCategoria.Hint = "Código Categoría";
            this.textCodigoCategoria.Location = new System.Drawing.Point(12, 92);
            this.textCodigoCategoria.MaxLength = 32767;
            this.textCodigoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.textCodigoCategoria.Name = "textCodigoCategoria";
            this.textCodigoCategoria.PasswordChar = '\0';
            this.textCodigoCategoria.SelectedText = "";
            this.textCodigoCategoria.SelectionLength = 0;
            this.textCodigoCategoria.SelectionStart = 0;
            this.textCodigoCategoria.Size = new System.Drawing.Size(210, 23);
            this.textCodigoCategoria.TabIndex = 1;
            this.textCodigoCategoria.TabStop = false;
            this.textCodigoCategoria.UseSystemPasswordChar = false;
            // 
            // label1TituloCategoria
            // 
            this.label1TituloCategoria.AutoSize = true;
            this.label1TituloCategoria.Depth = 0;
            this.label1TituloCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1TituloCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1TituloCategoria.Location = new System.Drawing.Point(243, 9);
            this.label1TituloCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1TituloCategoria.Name = "label1TituloCategoria";
            this.label1TituloCategoria.Size = new System.Drawing.Size(203, 19);
            this.label1TituloCategoria.TabIndex = 1;
            this.label1TituloCategoria.Text = "CATEGORIA DE PRODUCTOS";
            // 
            // buttonSalirCategoria
            // 
            this.buttonSalirCategoria.AutoSize = true;
            this.buttonSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirCategoria.Depth = 0;
            this.buttonSalirCategoria.Icon = null;
            this.buttonSalirCategoria.Location = new System.Drawing.Point(507, 299);
            this.buttonSalirCategoria.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCategoria.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirCategoria.Name = "buttonSalirCategoria";
            this.buttonSalirCategoria.Primary = true;
            this.buttonSalirCategoria.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirCategoria.TabIndex = 6;
            this.buttonSalirCategoria.Text = "Salir";
            this.buttonSalirCategoria.UseVisualStyleBackColor = true;
            this.buttonSalirCategoria.Click += new System.EventHandler(this.buttonSalirCategoria_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNuevo);
            this.panel2.Controls.Add(this.dataCategorias);
            this.panel2.Controls.Add(this.buttonBuscarCategoria);
            this.panel2.Controls.Add(this.textBuscarCategoria);
            this.panel2.Location = new System.Drawing.Point(105, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 169);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.AutoSize = true;
            this.buttonNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNuevo.Depth = 0;
            this.buttonNuevo.Icon = null;
            this.buttonNuevo.Location = new System.Drawing.Point(384, 13);
            this.buttonNuevo.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevo.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Primary = true;
            this.buttonNuevo.Size = new System.Drawing.Size(90, 30);
            this.buttonNuevo.TabIndex = 10;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // dataCategorias
            // 
            this.dataCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuNumero,
            this.ColuCodigoCategoria,
            this.ColuNombreCategoria,
            this.ColuEditarCategoria,
            this.ColuBorrarCategoria});
            this.dataCategorias.Location = new System.Drawing.Point(3, 49);
            this.dataCategorias.Name = "dataCategorias";
            this.dataCategorias.Size = new System.Drawing.Size(471, 115);
            this.dataCategorias.TabIndex = 5;
            this.dataCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColuNumero
            // 
            this.ColuNumero.HeaderText = "Nº";
            this.ColuNumero.Name = "ColuNumero";
            this.ColuNumero.ReadOnly = true;
            this.ColuNumero.Width = 50;
            // 
            // ColuCodigoCategoria
            // 
            this.ColuCodigoCategoria.HeaderText = "Código Categoría";
            this.ColuCodigoCategoria.Name = "ColuCodigoCategoria";
            this.ColuCodigoCategoria.Width = 200;
            // 
            // ColuNombreCategoria
            // 
            this.ColuNombreCategoria.HeaderText = "Nombre Categoría";
            this.ColuNombreCategoria.Name = "ColuNombreCategoria";
            this.ColuNombreCategoria.Width = 223;
            // 
            // ColuEditarCategoria
            // 
            this.ColuEditarCategoria.HeaderText = "Editar";
            this.ColuEditarCategoria.Name = "ColuEditarCategoria";
            this.ColuEditarCategoria.ReadOnly = true;
            this.ColuEditarCategoria.Text = "Editar";
            this.ColuEditarCategoria.UseColumnTextForButtonValue = true;
            this.ColuEditarCategoria.Width = 95;
            // 
            // ColuBorrarCategoria
            // 
            this.ColuBorrarCategoria.HeaderText = "Borrar";
            this.ColuBorrarCategoria.Name = "ColuBorrarCategoria";
            this.ColuBorrarCategoria.ReadOnly = true;
            this.ColuBorrarCategoria.Text = "Borrar";
            this.ColuBorrarCategoria.UseColumnTextForButtonValue = true;
            this.ColuBorrarCategoria.Width = 95;
            // 
            // buttonBuscarCategoria
            // 
            this.buttonBuscarCategoria.AutoSize = true;
            this.buttonBuscarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBuscarCategoria.Depth = 0;
            this.buttonBuscarCategoria.Icon = null;
            this.buttonBuscarCategoria.Location = new System.Drawing.Point(251, 13);
            this.buttonBuscarCategoria.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarCategoria.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBuscarCategoria.Name = "buttonBuscarCategoria";
            this.buttonBuscarCategoria.Primary = true;
            this.buttonBuscarCategoria.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscarCategoria.TabIndex = 4;
            this.buttonBuscarCategoria.Text = "Buscar";
            this.buttonBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // textBuscarCategoria
            // 
            this.textBuscarCategoria.Depth = 0;
            this.textBuscarCategoria.Hint = "Buscar Categoría";
            this.textBuscarCategoria.Location = new System.Drawing.Point(16, 13);
            this.textBuscarCategoria.MaxLength = 32767;
            this.textBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBuscarCategoria.Name = "textBuscarCategoria";
            this.textBuscarCategoria.PasswordChar = '\0';
            this.textBuscarCategoria.SelectedText = "";
            this.textBuscarCategoria.SelectionLength = 0;
            this.textBuscarCategoria.SelectionStart = 0;
            this.textBuscarCategoria.Size = new System.Drawing.Size(229, 23);
            this.textBuscarCategoria.TabIndex = 2;
            this.textBuscarCategoria.TabStop = false;
            this.textBuscarCategoria.UseSystemPasswordChar = false;
            // 
            // OpcCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(670, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSalirCategoria);
            this.Controls.Add(this.label1TituloCategoria);
            this.Controls.Add(this.panelNuevaCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpcCategoria";
            this.Load += new System.EventHandler(this.OpcCategoria_Load);
            this.panelNuevaCategoria.ResumeLayout(false);
            this.panelNuevaCategoria.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNuevaCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField textCodigoCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNombreCategoria;
        private MaterialSkin.Controls.MaterialLabel label1TituloCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirCategoria;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNuevo;
        private System.Windows.Forms.DataGridView dataCategorias;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBuscarCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBuscarCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuCodigoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuNombreCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn ColuEditarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn ColuBorrarCategoria;
    }
}