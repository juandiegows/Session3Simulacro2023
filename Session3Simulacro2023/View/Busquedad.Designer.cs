namespace Session3Simulacro2023 {
    partial class Busquedad {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rSalida = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.DRetorno = new System.Windows.Forms.DateTimePicker();
            this.DFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Rretorno = new System.Windows.Forms.RadioButton();
            this.cmbCabina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TSoloIda = new System.Windows.Forms.DataGridView();
            this.Csalida = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PRetorno = new System.Windows.Forms.Panel();
            this.TRetorno = new System.Windows.Forms.DataGridView();
            this.RDestino = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rSalida.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSoloIda)).BeginInit();
            this.PRetorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRetorno)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // rSalida
            // 
            this.rSalida.Controls.Add(this.btnFiltro);
            this.rSalida.Controls.Add(this.DRetorno);
            this.rSalida.Controls.Add(this.DFechaSalida);
            this.rSalida.Controls.Add(this.radioButton2);
            this.rSalida.Controls.Add(this.Rretorno);
            this.rSalida.Controls.Add(this.cmbCabina);
            this.rSalida.Controls.Add(this.label3);
            this.rSalida.Controls.Add(this.cmbDestino);
            this.rSalida.Controls.Add(this.label4);
            this.rSalida.Controls.Add(this.label5);
            this.rSalida.Controls.Add(this.label2);
            this.rSalida.Controls.Add(this.cmbOrigen);
            this.rSalida.Controls.Add(this.label1);
            this.rSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.rSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSalida.Location = new System.Drawing.Point(0, 0);
            this.rSalida.Name = "rSalida";
            this.rSalida.Size = new System.Drawing.Size(993, 181);
            this.rSalida.TabIndex = 0;
            this.rSalida.TabStop = false;
            this.rSalida.Text = "Filtros de busquedad";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.Color.Green;
            this.btnFiltro.Location = new System.Drawing.Point(885, 136);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(96, 39);
            this.btnFiltro.TabIndex = 5;
            this.btnFiltro.Text = "Aplicar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // DRetorno
            // 
            this.DRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DRetorno.Location = new System.Drawing.Point(684, 110);
            this.DRetorno.Name = "DRetorno";
            this.DRetorno.Size = new System.Drawing.Size(134, 27);
            this.DRetorno.TabIndex = 4;
            // 
            // DFechaSalida
            // 
            this.DFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DFechaSalida.Location = new System.Drawing.Point(379, 110);
            this.DFechaSalida.Name = "DFechaSalida";
            this.DFechaSalida.Size = new System.Drawing.Size(134, 27);
            this.DFechaSalida.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(130, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 25);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Solo ida";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Rretorno
            // 
            this.Rretorno.AutoSize = true;
            this.Rretorno.Checked = true;
            this.Rretorno.Location = new System.Drawing.Point(27, 110);
            this.Rretorno.Name = "Rretorno";
            this.Rretorno.Size = new System.Drawing.Size(90, 25);
            this.Rretorno.TabIndex = 2;
            this.Rretorno.TabStop = true;
            this.Rretorno.Text = "Retorno";
            this.Rretorno.UseVisualStyleBackColor = true;
            this.Rretorno.CheckedChanged += new System.EventHandler(this.Rretorno_CheckedChanged);
            // 
            // cmbCabina
            // 
            this.cmbCabina.FormattingEnabled = true;
            this.cmbCabina.Location = new System.Drawing.Point(688, 47);
            this.cmbCabina.Name = "cmbCabina";
            this.cmbCabina.Size = new System.Drawing.Size(163, 29);
            this.cmbCabina.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de cabina";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(360, 44);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(163, 29);
            this.cmbDestino.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de regreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Salida";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(101, 47);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(163, 29);
            this.cmbOrigen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TSoloIda);
            this.panel1.Controls.Add(this.Csalida);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 209);
            this.panel1.TabIndex = 1;
            // 
            // TSoloIda
            // 
            this.TSoloIda.AllowUserToAddRows = false;
            this.TSoloIda.AllowUserToDeleteRows = false;
            this.TSoloIda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSoloIda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TSoloIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TSoloIda.Location = new System.Drawing.Point(12, 39);
            this.TSoloIda.Name = "TSoloIda";
            this.TSoloIda.ReadOnly = true;
            this.TSoloIda.RowHeadersWidth = 51;
            this.TSoloIda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TSoloIda.Size = new System.Drawing.Size(969, 167);
            this.TSoloIda.TabIndex = 3;
            // 
            // Csalida
            // 
            this.Csalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Csalida.AutoSize = true;
            this.Csalida.Location = new System.Drawing.Point(688, 11);
            this.Csalida.Name = "Csalida";
            this.Csalida.Size = new System.Drawing.Size(294, 25);
            this.Csalida.TabIndex = 2;
            this.Csalida.Text = "Visualizar tres dias antes y despues";
            this.Csalida.UseVisualStyleBackColor = true;
            this.Csalida.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Detalle de vuelos de salida";
            // 
            // PRetorno
            // 
            this.PRetorno.Controls.Add(this.TRetorno);
            this.PRetorno.Controls.Add(this.RDestino);
            this.PRetorno.Controls.Add(this.label7);
            this.PRetorno.Dock = System.Windows.Forms.DockStyle.Top;
            this.PRetorno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRetorno.Location = new System.Drawing.Point(0, 390);
            this.PRetorno.Name = "PRetorno";
            this.PRetorno.Size = new System.Drawing.Size(993, 209);
            this.PRetorno.TabIndex = 2;
            // 
            // TRetorno
            // 
            this.TRetorno.AllowUserToAddRows = false;
            this.TRetorno.AllowUserToDeleteRows = false;
            this.TRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TRetorno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRetorno.Location = new System.Drawing.Point(12, 39);
            this.TRetorno.Name = "TRetorno";
            this.TRetorno.ReadOnly = true;
            this.TRetorno.RowHeadersWidth = 51;
            this.TRetorno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TRetorno.Size = new System.Drawing.Size(969, 167);
            this.TRetorno.TabIndex = 3;
            // 
            // RDestino
            // 
            this.RDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RDestino.AutoSize = true;
            this.RDestino.Location = new System.Drawing.Point(688, 11);
            this.RDestino.Name = "RDestino";
            this.RDestino.Size = new System.Drawing.Size(294, 25);
            this.RDestino.TabIndex = 2;
            this.RDestino.Text = "Visualizar tres dias antes y despues";
            this.RDestino.UseVisualStyleBackColor = true;
            this.RDestino.CheckedChanged += new System.EventHandler(this.RDestino_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Detalle de vuelos de salida";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 100);
            this.panel3.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(830, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 39);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btnReservar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(228, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmación reserva para : ";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.Green;
            this.btnReservar.Location = new System.Drawing.Point(250, 31);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(182, 39);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar vuelo";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pasajeros";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Busquedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1010, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PRetorno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rSalida);
            this.Name = "Busquedad";
            this.Text = "Busqueda de vuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rSalida.ResumeLayout(false);
            this.rSalida.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSoloIda)).EndInit();
            this.PRetorno.ResumeLayout(false);
            this.PRetorno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRetorno)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox rSalida;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DateTimePicker DRetorno;
        private System.Windows.Forms.DateTimePicker DFechaSalida;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Rretorno;
        private System.Windows.Forms.ComboBox cmbCabina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TSoloIda;
        private System.Windows.Forms.CheckBox Csalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PRetorno;
        private System.Windows.Forms.DataGridView TRetorno;
        private System.Windows.Forms.CheckBox RDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

