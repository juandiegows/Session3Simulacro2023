using Session3Simulacro2023.helpers;
using Session3Simulacro2023.Model;

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

        private void Form1_Load(object sender, EventArgs e) {
            using (Session3Entities db = new Session3Entities())
            {
                var list = db.Airports.ToList();
                list.Insert(0, new Airport() { IATACode = "Todos" });
                cmbDestino.LlenarCombo(list.ToList(), "IATACode", "ID");
                cmbOrigen.LlenarCombo(list.ToList(), "IATACode", "ID");
                cmbCabina.LlenarCombo(db.CabinTypes.ToList(), "Name", "ID");
            }
        }

        private void Rretorno_CheckedChanged(object sender, EventArgs e)
        {
          DRetorno.Enabled =   PRetorno.Visible = Rretorno.Checked;

        }

        
    }
}
