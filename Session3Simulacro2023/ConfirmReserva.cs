﻿using Session3Simulacro2023.helpers;
using Session3Simulacro2023.Model;
using Session3Simulacro2023.Model.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3Simulacro2023 {
    public partial class ConfirmReserva : Form {
        public int Cantidad { set; get; }
        public List<Pasajero> Pasajeros = new List<Pasajero>();
        public ConfirmReserva(Schedule salida, Schedule retorno, CabinType cabinType, int cantidad) {
            InitializeComponent();

            txtApellido.Required();
            txtCelular.Required();
            txtNombre.Required();
            txtNumberPass.Required();


            lblSOrigen.Text = salida.Route.Airport.IATACode;
            lblSDestino.Text = salida.Route.Airport1.IATACode;
            lblSFecha.Text = salida.Date.ToShortDateString();
            lblSNumeroVuelo.Text = salida.FlightNumber.ToString();
            lblSCabina.Text = cabinType.Name;
            Cantidad = cantidad;

            if (retorno != null) {
                lblROrigen.Text = retorno.Route.Airport1.IATACode;
                lblRDestino.Text = retorno.Route.Airport.IATACode;
                lblRFecha.Text = retorno.Date.ToShortDateString();
                lblRNumero.Text = retorno.FlightNumber.ToString();
                lblRCabina.Text = cabinType.Name;
            }
            else {
                BGRegreso.Visible = false;
            }
            using (Session3Entities db = new Session3Entities()) {
                cmbPassport.LlenarCombo(db.Countries.ToList(), "Name", "ID");
            }
     

        }

        private void btnFiltro_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                PBPasaporte.Image = Image.FromFile( openFileDialog1.FileName);
                //obtener el nombre de la imagen
                //lblFileName.Text = openFileDialog1.FileName.Split('\\').Last();
                //obtener el nombre de la iamgen forma 2
                var info = new FileInfo(openFileDialog1.FileName);
                lblFileName.Text = info.Name;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            if (MessageBox.Show( "¿Desea salir sin guardar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if(Pasajeros.Count >= Cantidad) {
                MessageBox.Show("Ya alcanzo el limite de pasajero a registrar");
                GBPasajero.Enabled = false;
                return;
            }
            if (GBPasajero.IsValid()) {
                
                if(PBPasaporte.Image == null) {
                    MessageBox.Show("Seleccione una foto");
                    return;
                }
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                string url = Environment.CurrentDirectory+"/img/"+txtNumberPass.Text.Trim()+fileInfo.Extension;
                if(!Directory.Exists(Environment.CurrentDirectory + "/img")) {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "/img/");
                }
           
                File.Copy(fileInfo.FullName, url );
                Country country = cmbPassport.SelectedItem as Country;
                Pasajeros.Add(new Pasajero() {
                    Nombres = txtNombre.Text,
                    Apellidos =txtApellido.Text,
                    Fecha = DFechaNacimiento.Value.ToShortDateString(),
                    NumeroPasaporte = txtNumberPass.Text,
                    PaisId = country.ID,
                    PaisPasaporte = country.Name,
                    Telefono = txtCelular.Text,
                    URl = "/img/" + txtNumberPass.Text.Trim() + fileInfo.Extension
                });
                dataGridView1.DataSource = Pasajeros;
                if (Pasajeros.Count >= Cantidad) {
                    GBPasajero.Enabled = false;
                    btnConfirm.Enabled = true;
                    return;
                }
            }
            else {
                MessageBox.Show("Llene todos los datos");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dataGridView1.ColumnCount - 1) {
                int row = e.RowIndex;
                Pasajero pasajero = Pasajeros[row];
                new VerPasaporte(pasajero).ShowDialog();
            }
        }
    }
}
