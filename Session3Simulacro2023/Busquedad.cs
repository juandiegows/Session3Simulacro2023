using Session3Simulacro2023.helpers;
using Session3Simulacro2023.Model;
using Session3Simulacro2023.Model.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3Simulacro2023 {
    public partial class Busquedad : Form {
        public Busquedad() {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        public void Llenar(DataGridView tabla, int salida = 0, int destinon = 0, DateTime? date = null) {
            using (Session3Entities db = new Session3Entities()) {
                CabinType type = cmbCabina.SelectedItem as CabinType;
                var list = db.Schedules.ToList().Where(x => (x.Route.DepartureAirportID== salida || salida == 0)
                && (x.Route.ArrivalAirportID == destinon || destinon == 0)
                &&  (date == null || date.Value.Date == DateTime.Now.Date  || date.Value.Date ==x.Date.Date )
                ).ToList().Select(x => new Vuelo(x, type)).ToList();
                tabla.DataSource = list;
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            using (Session3Entities db = new Session3Entities()) {
                var list = db.Airports.ToList();
                list.Insert(0, new Airport() { IATACode = "Todos" });
                cmbDestino.LlenarCombo(list.ToList(), "IATACode", "ID");
                cmbOrigen.LlenarCombo(list.ToList(), "IATACode", "ID");
                cmbCabina.LlenarCombo(db.CabinTypes.ToList(), "Name", "ID");
            }
            Llenar(TSoloIda);
            Llenar(TRetorno);
        }

        private void Rretorno_CheckedChanged(object sender, EventArgs e) {
            DRetorno.Enabled = PRetorno.Visible = Rretorno.Checked;

        }

        private void btnFiltro_Click(object sender, EventArgs e) {
            int salida = (int)cmbOrigen.SelectedValue;
            int destino = (int)cmbDestino.SelectedValue;
            if (salida != 0 && salida == destino) {
                errorProvider1.SetError(cmbDestino, "Debe ser diferente al destino");
                errorProvider1.SetError(cmbOrigen, "Debe ser diferente al origen");
                return;
            }
            Llenar(TSoloIda, salida,destino, DFechaSalida.Value);
            Llenar(TRetorno, destino, salida,DRetorno.Value);
        }
    }
}
