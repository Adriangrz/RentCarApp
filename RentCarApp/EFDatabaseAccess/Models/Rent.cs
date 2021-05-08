using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseAccess.Models
{
    public class Rent
    {
        public Guid RentId { get; set; }
        public DateTime DateOfRentFrom { get; set; }
        public DateTime DateOfRentTo { get; set; }
        public decimal TotalCost { get; set; }

        public Guid CarId { get; set; }
        public Car Car { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
