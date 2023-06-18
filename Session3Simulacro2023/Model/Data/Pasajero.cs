using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Simulacro2023.Model.Data {
    public class Pasajero {
        public string Nombres { get; set; } 
        public string Apellidos { get; set;}
        [DisplayName("Fecha de Nacimiento")]
        public string Fecha { get; set;}
        [DisplayName( "Número de pasaporte")]
        public string NumeroPasaporte { get; set;}
        public int PaisId { get; set;}
        [DisplayName("Pais de pasaporte")]
        public String PaisPasaporte { get; set;}
        public String Telefono { get; set;}
        public String URl { get;set;}


    }
}
