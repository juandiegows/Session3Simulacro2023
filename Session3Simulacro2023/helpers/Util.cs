using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3Simulacro2023.helpers {
    public static class Util {

        public static void LlenarCombo<E>(this ComboBox combo, List<E> lista, String DisplayName, String ValueMember) {

            combo.DataSource = lista;
            combo.DisplayMember = DisplayName;
            combo.ValueMember = ValueMember;
        }
    }
}
