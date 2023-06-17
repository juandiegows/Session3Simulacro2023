using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Simulacro2023.Model.Data {
    public class Vuelo {
        public Vuelo(Schedule schedule) {
            ID = schedule.ID;
            Origen = schedule.Route.Airport.IATACode;
            Destino = schedule.Route.Airport1.IATACode;
            Fecha = schedule.Date;
            Hora = new DateTime(schedule.Time.Ticks).ToLongTimeString();
            Numero = schedule.FlightNumber.ToString();
            Precio = schedule.EconomyPrice.ToString("$ 0");
        }
        public int ID { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        [Display(Name = "Número de vuelo")]
        public string Numero { get; set; }
        [Display(Name = "Precio de cabina")]
        public string Precio { get; set; }
    }
}
