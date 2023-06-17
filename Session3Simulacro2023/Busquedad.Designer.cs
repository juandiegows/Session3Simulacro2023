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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PRetorno = new System.Windows.Forms.Panel();
            this.TRetorno = new System.Windows.Forms.DataGridView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSoloIda)).BeginInit();
            this.PRetorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRetorno)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.DRetorno);
            this.groupBox1.Controls.Add(this.DFechaSalida);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.Rretorno);
            this.groupBox1.Controls.Add(this.cmbCabina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1303, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busquedad";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.Color.Green;
            this.btnFiltro.Location = new System.Drawing.Point(1159, 167);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(128, 48);
            this.btnFiltro.TabIndex = 5;
            this.btnFiltro.Text = "Aplicar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // DRetorno
            // 
            this.DRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DRetorno.Location = new System.Drawing.Point(912, 135);
            this.DRetorno.Margin = new System.Windows.Forms.Padding(4);
            this.DRetorno.Name = "DRetorno";
            this.DRetorno.Size = new System.Drawing.Size(177, 32);
            this.DRetorno.TabIndex = 4;
            // 
            // DFechaSalida
            // 
            this.DFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DFechaSalida.Location = new System.Drawing.Point(505, 135);
            this.DFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.DFechaSalida.Name = "DFechaSalida";
            this.DFechaSalida.Size = new System.Drawing.Size(177, 32);
            this.DFechaSalida.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(173, 135);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 27);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Solo ida";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Rretorno
            // 
            this.Rretorno.AutoSize = true;
            this.Rretorno.Checked = true;
            this.Rretorno.Location = new System.Drawing.Point(36, 135);
            this.Rretorno.Margin = new System.Windows.Forms.Padding(4);
            this.Rretorno.Name = "Rretorno";
            this.Rretorno.Size = new System.Drawing.Size(107, 27);
            this.Rretorno.TabIndex = 2;
            this.Rretorno.TabStop = true;
            this.Rretorno.Text = "Retorno";
            this.Rretorno.UseVisualStyleBackColor = true;
            this.Rretorno.CheckedChanged += new System.EventHandler(this.Rretorno_CheckedChanged);
            // 
            // cmbCabina
            // 
            this.cmbCabina.FormattingEnabled = true;
            this.cmbCabina.Location = new System.Drawing.Point(917, 58);
            this.cmbCabina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCabina.Name = "cmbCabina";
            this.cmbCabina.Size = new System.Drawing.Size(216, 31);
            this.cmbCabina.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de cabina";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(480, 54);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(216, 31);
            this.cmbDestino.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destino";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de regreso";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Salida";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(135, 58);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(216, 31);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TSoloIda);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 257);
            this.panel1.TabIndex = 1;
            // 
            // TSoloIda
            // 
            this.TSoloIda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSoloIda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TSoloIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TSoloIda.Location = new System.Drawing.Point(16, 48);
            this.TSoloIda.Margin = new System.Windows.Forms.Padding(4);
            this.TSoloIda.Name = "TSoloIda";
            this.TSoloIda.RowHeadersWidth = 51;
            this.TSoloIda.Size = new System.Drawing.Size(1271, 206);
            this.TSoloIda.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(917, 14);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(371, 27);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Visualizar tres dias antes y despues";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Detalle de vuelos de salida";
            // 
            // PRetorno
            // 
            this.PRetorno.Controls.Add(this.TRetorno);
            this.PRetorno.Controls.Add(this.checkBox2);
            this.PRetorno.Controls.Add(this.label7);
            this.PRetorno.Dock = System.Windows.Forms.DockStyle.Top;
            this.PRetorno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRetorno.Location = new System.Drawing.Point(0, 480);
            this.PRetorno.Margin = new System.Windows.Forms.Padding(4);
            this.PRetorno.Name = "PRetorno";
            this.PRetorno.Size = new System.Drawing.Size(1303, 257);
            this.PRetorno.TabIndex = 2;
            // 
            // TRetorno
            // 
            this.TRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TRetorno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRetorno.Location = new System.Drawing.Point(16, 48);
            this.TRetorno.Margin = new System.Windows.Forms.Padding(4);
            this.TRetorno.Name = "TRetorno";
            this.TRetorno.RowHeadersWidth = 51;
            this.TRetorno.Size = new System.Drawing.Size(1271, 206);
            this.TRetorno.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(917, 14);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(371, 27);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Visualizar tres dias antes y despues";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Detalle de vuelos de salida";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 737);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1303, 123);
            this.panel3.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(1086, 49);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 48);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnReservar);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(294, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(615, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmación reserva para : ";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.Green;
            this.btnReservar.Location = new System.Drawing.Point(364, 49);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(243, 48);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar vuelo";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 32);
            this.textBox1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pasajeros";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Busquedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1324, 614);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PRetorno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Busquedad";
            this.Text = "Busqueda de vuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PRetorno;
        private System.Windows.Forms.DataGridView TRetorno;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

