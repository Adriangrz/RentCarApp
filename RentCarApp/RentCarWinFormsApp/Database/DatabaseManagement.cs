using EFDatabaseAccess;
using EFDatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using RentCarWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarWinFormsApp.Database
{
    public static class DatabaseManagement
    {
        public static async Task<List<CarModel>> GetCarList(DateTime carRentalFrom,DateTime carRentalTo)
        {
            using var context = new RentCarContext();
            var data = await context.Cars.Except(
                context.Cars.Join(context.Rents, c => c.CarId, r => r.CarId, (car, rent) => new { car, rent })
                .Where(x => ((carRentalFrom >= x.rent.DateOfRentFrom && carRentalFrom <= x.rent.DateOfRentTo) ||
                 (carRentalTo >= x.rent.DateOfRentFrom && carRentalTo <= x.rent.DateOfRentTo) ||
                 (carRentalFrom >= x.rent.DateOfRentFrom && carRentalTo <= x.rent.DateOfRentTo) ||
                 (carRentalFrom <= x.rent.DateOfRentFrom && carRentalTo >= x.rent.DateOfRentTo)))
                .Select(x => x.car))
                .Select(x => new CarModel { CarId = x.CarId, Make = x.Make, Model = x.Model, ProdYear = x.ProdYear, Transmission = x.Transmission, Fuel = x.Fuel, Price = x.Price }).ToListAsync();
            return data;
        }
        public static async Task SaveRentalDetails(CustomerDataUserControl customerDataUserControl, SelectingCarForRentalUserControl selectingCarForRentalUserControl, DateTime carRentalFrom, DateTime carRentalTo,decimal totalCost)
        {
            using var context = new RentCarContext();
            var customer = new Customer()
            {
                Name = customerDataUserControl.CustomerName,
                Surname = customerDataUserControl.CustomerSurname,
                City = customerDataUserControl.CustomerCity,
                Street = customerDataUserControl.CustomerStreet,
                PhoneNumber = customerDataUserControl.CustomerPhoneNumber,
                Email = customerDataUserControl.CustomerEmail
            };
            var rent = new Rent()
            {
                DateOfRentFrom = carRentalFrom,
                DateOfRentTo = carRentalTo,
                TotalCost = totalCost
            };
            rent.Customer = customer;
            rent.Car = await context.Cars.FindAsync(selectingCarForRentalUserControl.CarId);
            await context.AddAsync(rent);
            await context.SaveChangesAsync();
        }
        public static async Task<byte[]> GetCarImage(object carId)
        {
            using var context = new RentCarContext();
            var data = await context.Cars.Where(x => x.CarId == (Guid)carId).Select(x => x.PictureLink).SingleOrDefaultAsync();
            return data;
        }
    }
}
