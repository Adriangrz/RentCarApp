using EFDatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseAccess.Configuration
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.ToTable("Rents");

            builder.HasKey(x => x.RentId);

            builder.HasOne(r => r.Car)
                .WithMany(ca => ca.Rents)
                .HasForeignKey(r => r.CarId);

            builder.HasOne(r => r.Customer)
               .WithMany(cu => cu.Rents)
               .HasForeignKey(r => r.CustomerId);
        }
    }
}
