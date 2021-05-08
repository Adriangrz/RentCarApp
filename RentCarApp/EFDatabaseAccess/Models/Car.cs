using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseAccess.Models
{
    public class Car
    {
        public Guid CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ProdYear { get; set; }
        public CarTransmission Transmission { get; set; }
        public CarFuel Fuel { get; set; }
        public byte[] PictureLink { get; set; }
        public decimal Price { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
