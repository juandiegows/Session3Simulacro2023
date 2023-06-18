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

        public void Llenar(DataGridView tabla, int salida = 0, int destino = 0, DateTime? dateStart = null, bool range = false) {
            using (Session3Entities db = new Session3Entities()) {
                CabinType type = cmbCabina.SelectedItem as CabinType;
                var list = db.Schedules.ToList().Where(x =>
                (x.Route.DepartureAirportID == salida || salida == 0)
                && (x.Route.ArrivalAirportID == destino || destino == 0)
                && (!range ?
                (dateStart == null || dateStart.Value.Date == DateTime.Now.Date || dateStart.Value.Date == x.Date.Date) :
                (x.Date.Date > dateStart.Value.Date.AddDays(-3) && x.Date.Date < dateStart.Value.AddDays(3)))
                ).ToList().Select(x => new Vuelo(x, type)).ToList();
                tabla.DataSource = list;
                tabla.Columns[0].Visible = false;
                tabla.Select();
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
            errorProvider1.Clear();
            if (salida != 0 && salida == destino) {
                errorProvider1.SetError(cmbDestino, "Debe ser diferente al destino");
                errorProvider1.SetError(cmbOrigen, "Debe ser diferente al origen");
                return;
            }
            Llenar(TSoloIda, salida, destino, DFechaSalida.Value);
            Llenar(TRetorno, destino, salida, DRetorno.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            int salida = (int)cmbOrigen.SelectedValue;
            int destino = (int)cmbDestino.SelectedValue;
            Llenar(TSoloIda, salida, destino, DFechaSalida.Value, Csalida.Checked);
        }

        private void RDestino_CheckedChanged(object sender, EventArgs e) {
            int salida = (int)cmbOrigen.SelectedValue;
            int destino = (int)cmbDestino.SelectedValue;
            Llenar(TRetorno, destino, salida, DRetorno.Value, RDestino.Checked);
        }

        private void btnReservar_Click(object sender, EventArgs e) {


            using (Session3Entities db = new Session3Entities()) {
                if(TSoloIda.CurrentRow == null) {
                    MessageBox.Show("Seleccione un vuelo de salida");
                    return;
                }
                if(Rretorno.Checked) {
                    if (TRetorno.CurrentRow == null) {
                        MessageBox.Show("Seleccione un vuelo de retorno");
                        return;
                    }
                }
            
                int totalPasajero = (int)numericUpDown1.Value;
                //obtener el id de la tabla salida
                int.TryParse(TSoloIda.CurrentRow.Cells["ID"].Value.ToString(), out int salidaId);
                //obtener el vuelo de salida
                Schedule salida = db.Schedules.Where(x => x.ID == salidaId).FirstOrDefault();

                //comprueba si hay sillas disponible disponible
                int totalSillaDisponible = salida.Aircraft.TotalSeats - salida.Tickets.Count;

                string mensaje = "";
                if (totalSillaDisponible < totalPasajero) {
                    mensaje += $"el total de silla disponible es superado por la cantidad de pasajero del vuelo de salida N° {salida.FlightNumber} \n silla disponible : {totalSillaDisponible}";

                }

                //obtener el id de la tabla retorno
                int.TryParse(TRetorno.CurrentRow.Cells["ID"].Value.ToString(), out int retornoId);
                //obtener el vuelo de retorno
                Schedule retorno = db.Schedules.Where(x => x.ID == salidaId).FirstOrDefault();
                if (retorno != null) {
                    //comprueba si hay sillas disponible disponible
                    int totalSillaDisponibleRetorn = retorno.Aircraft.TotalSeats - retorno.Tickets.Count;

                    if (totalSillaDisponibleRetorn < totalPasajero) {
                        mensaje += $"el total de silla disponible es superado por la cantidad de pasajero del vuelo de retorno N° {retorno.FlightNumber} \n silla disponible : {totalSillaDisponibleRetorn}";

                    }


                }

                errorProvider1.SetError(numericUpDown1, mensaje);
                if (mensaje != "") {
                    return;
                }
                if (!Rretorno.Checked) {
                    retorno = null;
                }
                CabinType cabinType = cmbCabina.SelectedItem as CabinType;
                //ocultamos el formulario
                this.Hide();
                //abrimos el formulario
                new ConfirmReserva(salida, retorno, cabinType,totalPasajero).ShowDialog();
                //mostramos el formulario cuando se cierre el de arriba
                this.Show();
            }


        }
    }
}
