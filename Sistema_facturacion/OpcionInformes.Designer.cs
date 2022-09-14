namespace Sistema_facturacion
{
    partial class OpcionInformes
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelSeleccionarInforme = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelOrdenarPor = new System.Windows.Forms.Label();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonEnExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonEnPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(191, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(324, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // labelSeleccionarInforme
            // 
            this.labelSeleccionarInforme.AutoSize = true;
            this.labelSeleccionarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionarInforme.Location = new System.Drawing.Point(21, 19);
            this.labelSeleccionarInforme.Name = "labelSeleccionarInforme";
            this.labelSeleccionarInforme.Size = new System.Drawing.Size(135, 18);
            this.labelSeleccionarInforme.TabIndex = 1;
            this.labelSeleccionarInforme.Text = "Seleccione Informe";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(16, 62);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(87, 18);
            this.labelFechaInicio.TabIndex = 2;
            this.labelFechaInicio.Text = "Fecha Inicio";
            // 
            // labelOrdenarPor
            // 
            this.labelOrdenarPor.AutoSize = true;
            this.labelOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.labelOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenarPor.Location = new System.Drawing.Point(344, 19);
            this.labelOrdenarPor.Name = "labelOrdenarPor";
            this.labelOrdenarPor.Size = new System.Drawing.Size(90, 18);
            this.labelOrdenarPor.TabIndex = 3;
            this.labelOrdenarPor.Text = "Ordenar Por";
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFinal.Location = new System.Drawing.Point(318, 61);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(84, 18);
            this.labelFechaFinal.TabIndex = 4;
            this.labelFechaFinal.Text = "Fecha Final";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonEnExcel);
            this.panel1.Controls.Add(this.radioButtonEnPdf);
            this.panel1.Controls.Add(this.radioButtonEnPantalla);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelSeleccionarInforme);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelFechaFinal);
            this.panel1.Controls.Add(this.labelOrdenarPor);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 135);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonEnExcel
            // 
            this.radioButtonEnExcel.Depth = 0;
            this.radioButtonEnExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEnExcel.Location = new System.Drawing.Point(356, 95);
            this.radioButtonEnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonEnExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonEnExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonEnExcel.Name = "radioButtonEnExcel";
            this.radioButtonEnExcel.Ripple = true;
            this.radioButtonEnExcel.Size = new System.Drawing.Size(97, 29);
            this.radioButtonEnExcel.TabIndex = 11;
            this.radioButtonEnExcel.TabStop = true;
            this.radioButtonEnExcel.Text = "En Excel";
            this.radioButtonEnExcel.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnPdf
            // 
            this.radioButtonEnPdf.Depth = 0;
            this.radioButtonEnPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEnPdf.Location = new System.Drawing.Point(259, 95);
            this.radioButtonEnPdf.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonEnPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonEnPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonEnPdf.Name = "radioButtonEnPdf";
            this.radioButtonEnPdf.Ripple = true;
            this.radioButtonEnPdf.Size = new System.Drawing.Size(97, 29);
            this.radioButtonEnPdf.TabIndex = 10;
            this.radioButtonEnPdf.TabStop = true;
            this.radioButtonEnPdf.Text = "En Pdf";
            this.radioButtonEnPdf.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnPantalla
            // 
            this.radioButtonEnPantalla.Depth = 0;
            this.radioButtonEnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEnPantalla.Location = new System.Drawing.Point(138, 95);
            this.radioButtonEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonEnPantalla.Name = "radioButtonEnPantalla";
            this.radioButtonEnPantalla.Ripple = true;
            this.radioButtonEnPantalla.Size = new System.Drawing.Size(97, 29);
            this.radioButtonEnPantalla.TabIndex = 9;
            this.radioButtonEnPantalla.TabStop = true;
            this.radioButtonEnPantalla.Text = "En Pantalla";
            this.radioButtonEnPantalla.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(416, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(445, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 146);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.AutoSize = true;
            this.buttonGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerarInforme.Depth = 0;
            this.buttonGenerarInforme.Icon = null;
            this.buttonGenerarInforme.Location = new System.Drawing.Point(168, 181);
            this.buttonGenerarInforme.MaximumSize = new System.Drawing.Size(130, 30);
            this.buttonGenerarInforme.MinimumSize = new System.Drawing.Size(130, 30);
            this.buttonGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Primary = true;
            this.buttonGenerarInforme.Size = new System.Drawing.Size(130, 30);
            this.buttonGenerarInforme.TabIndex = 13;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.AutoSize = true;
            this.buttonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalir.Depth = 0;
            this.buttonSalir.Icon = null;
            this.buttonSalir.Location = new System.Drawing.Point(314, 181);
            this.buttonSalir.MaximumSize = new System.Drawing.Size(90, 30);
            this.buttonSalir.MinimumSize = new System.Drawing.Size(90, 30);
            this.buttonSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Primary = true;
            this.buttonSalir.Size = new System.Drawing.Size(90, 30);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // OpcionInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(621, 375);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGenerarInforme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpcionInformes";
            this.Load += new System.EventHandler(this.OpcionInformes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label labelSeleccionarInforme;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelOrdenarPor;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEnPantalla;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEnPdf;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEnExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSalir;
    }
}