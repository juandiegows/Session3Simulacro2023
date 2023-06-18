using Session3Simulacro2023.helpers;
using Session3Simulacro2023.Model;

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
        public ConfirmReserva(Schedule salida, Schedule retorno, CabinType cabinType) {
            InitializeComponent();
            lblSOrigen.Text = salida.Route.Airport.IATACode;
            lblSDestino.Text = salida.Route.Airport1.IATACode;
            lblSFecha.Text = salida.Date.ToShortDateString();
            lblSNumeroVuelo.Text = salida.FlightNumber.ToString();
            lblSCabina.Text = cabinType.Name;

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
                cmbPais.LlenarCombo(db.Countries.ToList(), "Name", "ID");
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
    }
}
