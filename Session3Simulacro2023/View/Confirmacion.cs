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

namespace Session3Simulacro2023.View {
    public partial class Confirmacion : Form {
        List<Pasajero> Pasajeros = new List<Pasajero>();
        Schedule Salida, Retorno;
        CabinType CabinType;
        public Confirmacion(List<Pasajero> pasajeros, Schedule salida, Schedule retorn, CabinType cabinType) {
            InitializeComponent();
            Salida = salida;
            Retorno = retorn;
            CabinType = cabinType;
            Pasajeros = pasajeros;

            double total = 0;
            Double precio = (double)salida.EconomyPrice;
            if (cabinType.ID == 2 || cabinType.ID == 3) {
                precio += precio * 0.35;

            }
            if (cabinType.ID == 3) {
                precio += precio * 0.30;

            }
            total += precio;
            if (retorn != null) {
                precio = 0;
                precio = (double)retorn.EconomyPrice;
                if (cabinType.ID == 2 || cabinType.ID == 3) {
                    precio += precio * 0.35;

                }
                if (cabinType.ID == 3) {
                    precio += precio * 0.30;

                }
                total += precio;
            }
            lblPrecio.Text = $"$ {total}";
        }

        private void button2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            using(Session3Entities db = new Session3Entities()) {
                String booking = Util.GenerarCadenaAleatoria().ToUpper();
                db.Tickets.AddRange(Pasajeros.Select(x=> new Ticket() {
                    CabinTypeID = CabinType.ID,
                    Firstname = x.Nombres,
                    Confirmed = true,
                    Email = "",
                    Lastname = x.Apellidos,
                    PassportCountryID = x.PaisId,
                    PassportNumber = x.NumeroPasaporte,
                    PassportPhoto = x.URl,
                    Phone = x.Telefono,
                    ScheduleID = Salida.ID,
                    UserID =1,
                    BookingReference = booking
                    

                }).ToList());
                if(Retorno != null) {
                    db.Tickets.AddRange(Pasajeros.Select(x => new Ticket() {
                        CabinTypeID = CabinType.ID,
                        Firstname = x.Nombres,
                        Confirmed = true,
                        Email = "",
                        Lastname = x.Apellidos,
                        PassportCountryID = x.PaisId,
                        PassportNumber = x.NumeroPasaporte,
                        PassportPhoto = x.URl,
                        Phone = x.Telefono,
                        ScheduleID = Salida.ID,
                        UserID = 1,
                        BookingReference = booking


                    }).ToList());
                }

                if(db.SaveChanges() > 0) {
                    MessageBox.Show("Se han agregado correctamente :)");
                }else {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
