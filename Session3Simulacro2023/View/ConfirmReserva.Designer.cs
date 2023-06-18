namespace Session3Simulacro2023 {
    partial class ConfirmReserva {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSNumeroVuelo = new System.Windows.Forms.Label();
            this.lblSOrigen = new System.Windows.Forms.Label();
            this.lblSFecha = new System.Windows.Forms.Label();
            this.lblSCabina = new System.Windows.Forms.Label();
            this.lblSDestino = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BGRegreso = new System.Windows.Forms.GroupBox();
            this.lblROrigen = new System.Windows.Forms.Label();
            this.lblRNumero = new System.Windows.Forms.Label();
            this.lblRFecha = new System.Windows.Forms.Label();
            this.lblRCabina = new System.Windows.Forms.Label();
            this.lblRDestino = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.PBPasaporte = new System.Windows.Forms.PictureBox();
            this.DFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPassport = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DPasajero = new System.Windows.Forms.DataGridView();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPasaporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisPasaporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerPasaporte = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.BGRegreso.SuspendLayout();
            this.btnEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasaporte)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DPasajero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSNumeroVuelo);
            this.groupBox1.Controls.Add(this.lblSOrigen);
            this.groupBox1.Controls.Add(this.lblSFecha);
            this.groupBox1.Controls.Add(this.lblSCabina);
            this.groupBox1.Controls.Add(this.lblSDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1357, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del vuelo de salida";
            // 
            // lblSNumeroVuelo
            // 
            this.lblSNumeroVuelo.AutoSize = true;
            this.lblSNumeroVuelo.Location = new System.Drawing.Point(911, 44);
            this.lblSNumeroVuelo.Name = "lblSNumeroVuelo";
            this.lblSNumeroVuelo.Size = new System.Drawing.Size(61, 21);
            this.lblSNumeroVuelo.TabIndex = 0;
            this.lblSNumeroVuelo.Text = "[valor]";
            // 
            // lblSOrigen
            // 
            this.lblSOrigen.AutoSize = true;
            this.lblSOrigen.Location = new System.Drawing.Point(93, 45);
            this.lblSOrigen.Name = "lblSOrigen";
            this.lblSOrigen.Size = new System.Drawing.Size(61, 21);
            this.lblSOrigen.TabIndex = 0;
            this.lblSOrigen.Text = "[valor]";
            // 
            // lblSFecha
            // 
            this.lblSFecha.AutoSize = true;
            this.lblSFecha.Location = new System.Drawing.Point(709, 44);
            this.lblSFecha.Name = "lblSFecha";
            this.lblSFecha.Size = new System.Drawing.Size(61, 21);
            this.lblSFecha.TabIndex = 0;
            this.lblSFecha.Text = "[valor]";
            // 
            // lblSCabina
            // 
            this.lblSCabina.AutoSize = true;
            this.lblSCabina.Location = new System.Drawing.Point(492, 44);
            this.lblSCabina.Name = "lblSCabina";
            this.lblSCabina.Size = new System.Drawing.Size(61, 21);
            this.lblSCabina.TabIndex = 0;
            this.lblSCabina.Text = "[valor]";
            // 
            // lblSDestino
            // 
            this.lblSDestino.AutoSize = true;
            this.lblSDestino.Location = new System.Drawing.Point(269, 45);
            this.lblSDestino.Name = "lblSDestino";
            this.lblSDestino.Size = new System.Drawing.Size(61, 21);
            this.lblSDestino.TabIndex = 0;
            this.lblSDestino.Text = "[valor]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Origen : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(819, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "N° Vuelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de cabina : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino :";
            // 
            // BGRegreso
            // 
            this.BGRegreso.Controls.Add(this.lblROrigen);
            this.BGRegreso.Controls.Add(this.lblRNumero);
            this.BGRegreso.Controls.Add(this.lblRFecha);
            this.BGRegreso.Controls.Add(this.lblRCabina);
            this.BGRegreso.Controls.Add(this.lblRDestino);
            this.BGRegreso.Controls.Add(this.label16);
            this.BGRegreso.Controls.Add(this.label17);
            this.BGRegreso.Controls.Add(this.label18);
            this.BGRegreso.Controls.Add(this.label19);
            this.BGRegreso.Controls.Add(this.label20);
            this.BGRegreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BGRegreso.Location = new System.Drawing.Point(0, 100);
            this.BGRegreso.Name = "BGRegreso";
            this.BGRegreso.Size = new System.Drawing.Size(1357, 100);
            this.BGRegreso.TabIndex = 1;
            this.BGRegreso.TabStop = false;
            this.BGRegreso.Text = "Detalles del vuelo de regreso";
            // 
            // lblROrigen
            // 
            this.lblROrigen.AutoSize = true;
            this.lblROrigen.Location = new System.Drawing.Point(93, 45);
            this.lblROrigen.Name = "lblROrigen";
            this.lblROrigen.Size = new System.Drawing.Size(61, 21);
            this.lblROrigen.TabIndex = 0;
            this.lblROrigen.Text = "[valor]";
            // 
            // lblRNumero
            // 
            this.lblRNumero.AutoSize = true;
            this.lblRNumero.Location = new System.Drawing.Point(900, 47);
            this.lblRNumero.Name = "lblRNumero";
            this.lblRNumero.Size = new System.Drawing.Size(61, 21);
            this.lblRNumero.TabIndex = 0;
            this.lblRNumero.Text = "[valor]";
            // 
            // lblRFecha
            // 
            this.lblRFecha.AutoSize = true;
            this.lblRFecha.Location = new System.Drawing.Point(709, 47);
            this.lblRFecha.Name = "lblRFecha";
            this.lblRFecha.Size = new System.Drawing.Size(61, 21);
            this.lblRFecha.TabIndex = 0;
            this.lblRFecha.Text = "[valor]";
            // 
            // lblRCabina
            // 
            this.lblRCabina.AutoSize = true;
            this.lblRCabina.Location = new System.Drawing.Point(492, 45);
            this.lblRCabina.Name = "lblRCabina";
            this.lblRCabina.Size = new System.Drawing.Size(61, 21);
            this.lblRCabina.TabIndex = 0;
            this.lblRCabina.Text = "[valor]";
            // 
            // lblRDestino
            // 
            this.lblRDestino.AutoSize = true;
            this.lblRDestino.Location = new System.Drawing.Point(269, 45);
            this.lblRDestino.Name = "lblRDestino";
            this.lblRDestino.Size = new System.Drawing.Size(61, 21);
            this.lblRDestino.TabIndex = 0;
            this.lblRDestino.Text = "[valor]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Origen : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(819, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "N° Vuelo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(628, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "Fecha :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(353, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tipo de cabina : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(188, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Destino :";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Controls.Add(this.btnAgregar);
            this.btnEliminar.Controls.Add(this.btnFiltro);
            this.btnEliminar.Controls.Add(this.PBPasaporte);
            this.btnEliminar.Controls.Add(this.DFechaNacimiento);
            this.btnEliminar.Controls.Add(this.cmbPassport);
            this.btnEliminar.Controls.Add(this.label8);
            this.btnEliminar.Controls.Add(this.label21);
            this.btnEliminar.Controls.Add(this.txtCelular);
            this.btnEliminar.Controls.Add(this.label10);
            this.btnEliminar.Controls.Add(this.txtApellido);
            this.btnEliminar.Controls.Add(this.label6);
            this.btnEliminar.Controls.Add(this.txtNumberPass);
            this.btnEliminar.Controls.Add(this.label4);
            this.btnEliminar.Controls.Add(this.txtNombre);
            this.btnEliminar.Controls.Add(this.lblFileName);
            this.btnEliminar.Controls.Add(this.label2);
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.Location = new System.Drawing.Point(0, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(1357, 212);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "Datos del pasajero :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.Location = new System.Drawing.Point(1179, 164);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar pasajero";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.Color.Green;
            this.btnFiltro.Location = new System.Drawing.Point(942, 167);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(208, 36);
            this.btnFiltro.TabIndex = 6;
            this.btnFiltro.Text = "Seleccionar foto";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // PBPasaporte
            // 
            this.PBPasaporte.Location = new System.Drawing.Point(687, 17);
            this.PBPasaporte.Name = "PBPasaporte";
            this.PBPasaporte.Size = new System.Drawing.Size(208, 114);
            this.PBPasaporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPasaporte.TabIndex = 6;
            this.PBPasaporte.TabStop = false;
            // 
            // DFechaNacimiento
            // 
            this.DFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DFechaNacimiento.Location = new System.Drawing.Point(517, 128);
            this.DFechaNacimiento.Name = "DFechaNacimiento";
            this.DFechaNacimiento.Size = new System.Drawing.Size(134, 27);
            this.DFechaNacimiento.TabIndex = 5;
            // 
            // cmbPassport
            // 
            this.cmbPassport.FormattingEnabled = true;
            this.cmbPassport.Location = new System.Drawing.Point(496, 79);
            this.cmbPassport.Name = "cmbPassport";
            this.cmbPassport.Size = new System.Drawing.Size(155, 29);
            this.cmbPassport.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pais del pasaporte";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(338, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 21);
            this.label21.TabIndex = 1;
            this.label21.Text = "Fecha Nacimiento";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(109, 130);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(161, 27);
            this.txtCelular.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Celular";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(365, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 27);
            this.txtApellido.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellidos";
            // 
            // txtNumberPass
            // 
            this.txtNumberPass.Location = new System.Drawing.Point(156, 82);
            this.txtNumberPass.Name = "txtNumberPass";
            this.txtNumberPass.Size = new System.Drawing.Size(161, 27);
            this.txtNumberPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "N° Pasaporte";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(683, 136);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 21);
            this.lblFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.DPasajero);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1357, 247);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de pasajeros";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1172, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar pasajero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DPasajero
            // 
            this.DPasajero.AllowUserToAddRows = false;
            this.DPasajero.AllowUserToDeleteRows = false;
            this.DPasajero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DPasajero.AutoGenerateColumns = false;
            this.DPasajero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DPasajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.numeroPasaporteDataGridViewTextBoxColumn,
            this.paisIdDataGridViewTextBoxColumn,
            this.paisPasaporteDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.VerPasaporte});
            this.DPasajero.DataSource = this.pasajeroBindingSource;
            this.DPasajero.Location = new System.Drawing.Point(6, 26);
            this.DPasajero.Name = "DPasajero";
            this.DPasajero.ReadOnly = true;
            this.DPasajero.Size = new System.Drawing.Size(1339, 165);
            this.DPasajero.TabIndex = 0;
            this.DPasajero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPasaporteDataGridViewTextBoxColumn
            // 
            this.numeroPasaporteDataGridViewTextBoxColumn.DataPropertyName = "NumeroPasaporte";
            this.numeroPasaporteDataGridViewTextBoxColumn.HeaderText = "Número de pasaporte";
            this.numeroPasaporteDataGridViewTextBoxColumn.Name = "numeroPasaporteDataGridViewTextBoxColumn";
            this.numeroPasaporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisIdDataGridViewTextBoxColumn
            // 
            this.paisIdDataGridViewTextBoxColumn.DataPropertyName = "PaisId";
            this.paisIdDataGridViewTextBoxColumn.HeaderText = "PaisId";
            this.paisIdDataGridViewTextBoxColumn.Name = "paisIdDataGridViewTextBoxColumn";
            this.paisIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisPasaporteDataGridViewTextBoxColumn
            // 
            this.paisPasaporteDataGridViewTextBoxColumn.DataPropertyName = "PaisPasaporte";
            this.paisPasaporteDataGridViewTextBoxColumn.HeaderText = "Pais de pasaporte";
            this.paisPasaporteDataGridViewTextBoxColumn.Name = "paisPasaporteDataGridViewTextBoxColumn";
            this.paisPasaporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VerPasaporte
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            this.VerPasaporte.DefaultCellStyle = dataGridViewCellStyle1;
            this.VerPasaporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerPasaporte.HeaderText = "Ver pasaporte";
            this.VerPasaporte.Name = "VerPasaporte";
            this.VerPasaporte.ReadOnly = true;
            this.VerPasaporte.Text = "Ver pasaporte";
            this.VerPasaporte.UseColumnTextForButtonValue = true;
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Session3Simulacro2023.Model.Data.Pasajero);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 67);
            this.panel1.TabIndex = 4;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Red;
            this.btnRegresar.Location = new System.Drawing.Point(437, 16);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(251, 39);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar a buscar vuelos";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Green;
            this.btnConfirm.Location = new System.Drawing.Point(716, 16);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(172, 39);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirmar reserva";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg";
            // 
            // ConfirmReserva
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1374, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BGRegreso);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfirmReserva";
            this.Text = "Confirmación de la reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BGRegreso.ResumeLayout(false);
            this.BGRegreso.PerformLayout();
            this.btnEliminar.ResumeLayout(false);
            this.btnEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasaporte)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DPasajero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSNumeroVuelo;
        private System.Windows.Forms.Label lblSOrigen;
        private System.Windows.Forms.Label lblSFecha;
        private System.Windows.Forms.Label lblSCabina;
        private System.Windows.Forms.Label lblSDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox BGRegreso;
        private System.Windows.Forms.Label lblROrigen;
        private System.Windows.Forms.Label lblRNumero;
        private System.Windows.Forms.Label lblRFecha;
        private System.Windows.Forms.Label lblRCabina;
        private System.Windows.Forms.Label lblRDestino;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox btnEliminar;
        private System.Windows.Forms.ComboBox cmbPassport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DFechaNacimiento;
        private System.Windows.Forms.PictureBox PBPasaporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DPasajero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPasaporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisPasaporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn VerPasaporte;
        private System.Windows.Forms.BindingSource pasajeroBindingSource;
    }
}