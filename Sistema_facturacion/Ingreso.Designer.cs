namespace Sistema_facturacion
{
    partial class Ingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.textUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonIngresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(181)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 309);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_facturacion.Properties.Resources.login_3_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Depth = 0;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitulo.Location = new System.Drawing.Point(288, 24);
            this.labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(150, 19);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "INGRESAR USUARIO ";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // textUsuario
            // 
            this.textUsuario.Depth = 0;
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Hint = "Usuario ";
            this.textUsuario.Location = new System.Drawing.Point(250, 94);
            this.textUsuario.MaxLength = 32767;
            this.textUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.PasswordChar = '\0';
            this.textUsuario.SelectedText = "";
            this.textUsuario.SelectionLength = 0;
            this.textUsuario.SelectionStart = 0;
            this.textUsuario.Size = new System.Drawing.Size(246, 23);
            this.textUsuario.TabIndex = 2;
            this.textUsuario.TabStop = false;
            this.textUsuario.UseSystemPasswordChar = false;
            // 
            // textContraseña
            // 
            this.textContraseña.Depth = 0;
            this.textContraseña.Hint = "Contraseña";
            this.textContraseña.Location = new System.Drawing.Point(250, 157);
            this.textContraseña.MaxLength = 32767;
            this.textContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '*';
            this.textContraseña.SelectedText = "";
            this.textContraseña.SelectionLength = 0;
            this.textContraseña.SelectionStart = 0;
            this.textContraseña.Size = new System.Drawing.Size(246, 23);
            this.textContraseña.TabIndex = 3;
            this.textContraseña.TabStop = false;
            this.textContraseña.UseSystemPasswordChar = false;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.AutoSize = true;
            this.buttonIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIngresar.BackColor = System.Drawing.Color.Beige;
            this.buttonIngresar.Depth = 0;
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIngresar.Icon = null;
            this.buttonIngresar.Location = new System.Drawing.Point(237, 235);
            this.buttonIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Primary = true;
            this.buttonIngresar.Size = new System.Drawing.Size(86, 36);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "INGRESAR";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelar.BackColor = System.Drawing.Color.Beige;
            this.buttonCancelar.Depth = 0;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Icon = null;
            this.buttonCancelar.Location = new System.Drawing.Point(405, 235);
            this.buttonCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Primary = true;
            this.buttonCancelar.Size = new System.Drawing.Size(91, 36);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(550, 309);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingreso";
            this.Opacity = 0.89D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField textUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField textContraseña;
        private MaterialSkin.Controls.MaterialRaisedButton buttonIngresar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonCancelar;
    }
}

