using EFDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarWinFormsApp.Models
{
    public class CarModel
    {
        [DisplayName("Identyfikator")]
        public Guid CarId { get; set; }
        [DisplayName("Marka")]
        public string Make { get; set; }
        [DisplayName("Model")]
        public string Model { get; set; }
        [DisplayName("Rok produkcji")]
        public int ProdYear { get; set; }
        [DisplayName("Skrzynia biegów")]
        public CarTransmission Transmission { get; set; }
        [DisplayName("Paliwo")]
        public CarFuel Fuel { get; set; }
        [DisplayName("Cena")]
        public decimal Price { get; set; }
    }
}
