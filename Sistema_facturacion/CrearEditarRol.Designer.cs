namespace Sistema_facturacion
{
    partial class CrearEditarRol
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
            this.buttonSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelTituloRol = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNumRol = new System.Windows.Forms.TextBox();
            this.buttonActualizarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalirRol
            // 
            this.buttonSalirRol.AutoSize = true;
            this.buttonSalirRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalirRol.Depth = 0;
            this.buttonSalirRol.Icon = null;
            this.buttonSalirRol.Location = new System.Drawing.Point(343, 150);
            this.buttonSalirRol.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirRol.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalirRol.Name = "buttonSalirRol";
            this.buttonSalirRol.Primary = true;
            this.buttonSalirRol.Size = new System.Drawing.Size(90, 30);
            this.buttonSalirRol.TabIndex = 12;
            this.buttonSalirRol.Text = "Salir";
            this.buttonSalirRol.UseVisualStyleBackColor = true;
            this.buttonSalirRol.Click += new System.EventHandler(this.buttonSalirRol_Click);
            // 
            // labelTituloRol
            // 
            this.labelTituloRol.AutoSize = true;
            this.labelTituloRol.Depth = 0;
            this.labelTituloRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTituloRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTituloRol.Location = new System.Drawing.Point(181, 2);
            this.labelTituloRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTituloRol.Name = "labelTituloRol";
            this.labelTituloRol.Size = new System.Drawing.Size(59, 19);
            this.labelTituloRol.TabIndex = 10;
            this.labelTituloRol.Text = "TITULO";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textNumRol);
            this.panel1.Controls.Add(this.buttonActualizarRol);
            this.panel1.Controls.Add(this.textNombreRol);
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 117);
            this.panel1.TabIndex = 11;
            // 
            // textNumRol
            // 
            this.textNumRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumRol.Location = new System.Drawing.Point(3, 27);
            this.textNumRol.Name = "textNumRol";
            this.textNumRol.Size = new System.Drawing.Size(43, 24);
            this.textNumRol.TabIndex = 5;
            // 
            // buttonActualizarRol
            // 
            this.buttonActualizarRol.AutoSize = true;
            this.buttonActualizarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualizarRol.Depth = 0;
            this.buttonActualizarRol.Icon = null;
            this.buttonActualizarRol.Location = new System.Drawing.Point(283, 48);
            this.buttonActualizarRol.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarRol.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonActualizarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualizarRol.Name = "buttonActualizarRol";
            this.buttonActualizarRol.Primary = true;
            this.buttonActualizarRol.Size = new System.Drawing.Size(90, 30);
            this.buttonActualizarRol.TabIndex = 4;
            this.buttonActualizarRol.Text = "Actualizar";
            this.buttonActualizarRol.UseVisualStyleBackColor = true;
            this.buttonActualizarRol.Click += new System.EventHandler(this.buttonActualizarRol_Click);
            // 
            // textNombreRol
            // 
            this.textNombreRol.Depth = 0;
            this.textNombreRol.Hint = "Nombre del Rol";
            this.textNombreRol.Location = new System.Drawing.Point(3, 66);
            this.textNombreRol.MaxLength = 32767;
            this.textNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNombreRol.Name = "textNombreRol";
            this.textNombreRol.PasswordChar = '\0';
            this.textNombreRol.SelectedText = "";
            this.textNombreRol.SelectionLength = 0;
            this.textNombreRol.SelectionStart = 0;
            this.textNombreRol.Size = new System.Drawing.Size(225, 23);
            this.textNombreRol.TabIndex = 0;
            this.textNombreRol.TabStop = false;
            this.textNombreRol.UseSystemPasswordChar = false;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // CrearEditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(466, 192);
            this.Controls.Add(this.buttonSalirRol);
            this.Controls.Add(this.labelTituloRol);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearEditarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearEditarRol";
            this.Load += new System.EventHandler(this.CrearEditarRol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonSalirRol;
        private MaterialSkin.Controls.MaterialLabel labelTituloRol;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonActualizarRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNombreRol;
        private System.Windows.Forms.TextBox textNumRol;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}