using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3Simulacro2023.helpers {
    public static class Util {

        public static ErrorProvider ErrorProvider = new ErrorProvider();
        public static void LlenarCombo<E>(this ComboBox combo, List<E> lista, String DisplayName, String ValueMember) {

            combo.DataSource = lista;
            combo.DisplayMember = DisplayName;
            combo.ValueMember = ValueMember;
        }
        public static bool IsValid(this GroupBox panel) {
            bool valid = true;

            foreach (Control ctrl in panel.Controls) {
                ctrl.Focus();
                ctrl.Parent.Focus();
                if (ErrorProvider.GetError(ctrl) != null && ErrorProvider.GetError(ctrl) != "") {
                    valid = false;
                }
            }
            return valid;
        }

      public  static string GenerarCadenaAleatoria() {

            int longitud = 6; // Longitud de la cadena aleatoria
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


            Random random = new Random();
            StringBuilder cadena = new StringBuilder();

            for (int i = 0; i < longitud; i++) {
                int index = random.Next(caracteresPermitidos.Length);
                char caracterAleatorio = caracteresPermitidos[index];
                cadena.Append(caracterAleatorio);
            }

            return cadena.ToString();
        }
    




    public static void Required(this TextBox text) {
        text.Validating += (sender, e) => {
            ErrorProvider.SetError(text, "");
            if (text.Text == String.Empty) {
                ErrorProvider.SetError(text, "Este campo es obligatorio");
                e.Cancel = true;
            }
        };
    }
}
}
