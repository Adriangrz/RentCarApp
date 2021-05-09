using EFDatabaseAccess;
using RentCarWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarWinFormsApp
{
    public partial class MainCarRentalForm : Form
    {
        private CarRentalTimeRangeUserControl carRentalTimeRangeUserControl = new CarRentalTimeRangeUserControl();
        private SelectingCarForRentalUserControl selectingCarForRentalUserControl = new SelectingCarForRentalUserControl();
        private CustomerDataUserControl customerDataUserControl = new CustomerDataUserControl();
        private CarRentalConfirmationUserControl carRentalConfirmationUserControl = new CarRentalConfirmationUserControl();
        public MainCarRentalForm()
        {
            InitializeComponent();

            carRentalTimeRangeUserControl.Dock = DockStyle.Fill;
            carRentalTimeRangeUserControl.BtnSelectTimeRange += BtnSelectTimeRange_Click;
            pnlMain.Controls.Add(carRentalTimeRangeUserControl);

            selectingCarForRentalUserControl.Dock = DockStyle.Fill;
            selectingCarForRentalUserControl.BtnReserv += BtnReserv_Click;
            selectingCarForRentalUserControl.BtnBack += BtnBackToCarRentalTimeRange_Click;

            customerDataUserControl.Dock = DockStyle.Fill;
            customerDataUserControl.BtnConfirmRental += BtnConfirmRental_Click;
            customerDataUserControl.BtnBack += BtnBackToSelectingCarForRental_Click;

            carRentalConfirmationUserControl.Dock = DockStyle.Fill;
            carRentalConfirmationUserControl.BtnBackToApp += BtnBackToApp_Click;
            carRentalConfirmationUserControl.BtnExitApp += BtnExitApp_Click;
        }

        private void MainCarRentalForm_Shown(object sender, EventArgs e)
        {
            HelloForm helloForm = new HelloForm(this);
            helloForm.Show();
            this.Hide();
        }

        private void BtnSelectTimeRange_Click(object sender, EventArgs e)
        {
            var reservationFrom = carRentalTimeRangeUserControl.RentFromDate;
            var reservationTo = carRentalTimeRangeUserControl.RentToDate;
            using var context = new RentCarContext();
            var data = context.Cars.Except(
                context.Cars.Join(context.Rents, c => c.CarId, r => r.CarId, (car, rent) => new { car, rent })
                .Where(x => ((reservationFrom >= x.rent.DateOfRentFrom && reservationFrom <= x.rent.DateOfRentTo) ||
                 (reservationTo >= x.rent.DateOfRentFrom && reservationTo <= x.rent.DateOfRentTo) ||
                 (reservationFrom >= x.rent.DateOfRentFrom && reservationTo <= x.rent.DateOfRentTo) ||
                 (reservationFrom <= x.rent.DateOfRentFrom && reservationTo >= x.rent.DateOfRentTo)))
                .Select(x => x.car))
                .Select(x => new CarModel{ CarId = x.CarId, Make = x.Make, Model = x.Model, ProdYear = x.ProdYear, Transmission = x.Transmission, Fuel = x.Fuel, Price = x.Price });
            selectingCarForRentalUserControl.CarListToRent = data.ToList();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(selectingCarForRentalUserControl);
        }

        private void BtnReserv_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(customerDataUserControl);
        }

        private void BtnConfirmRental_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(carRentalConfirmationUserControl);
        }

        private void BtnBackToSelectingCarForRental_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(selectingCarForRentalUserControl);
        }

        private void BtnBackToCarRentalTimeRange_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(carRentalTimeRangeUserControl);
        }

        private void BtnBackToApp_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(carRentalTimeRangeUserControl);
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
