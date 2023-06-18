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
    public partial class VerPasaporte : Form {
        public VerPasaporte(Pasajero pasajero) {
            InitializeComponent();
            lblNombre.Text = $"{pasajero.Nombres} {pasajero.Apellidos}";
            PImagen.Image = Image.FromFile(Environment.CurrentDirectory + pasajero.URl);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
