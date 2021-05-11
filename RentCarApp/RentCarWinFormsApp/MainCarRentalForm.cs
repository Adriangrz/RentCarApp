using EFDatabaseAccess;
using EFDatabaseAccess.Models;
using RentCarWinFormsApp.Database;
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

        private async void BtnSelectTimeRange_Click(object sender, EventArgs e)
        {
            DateTime carRentalFrom = carRentalTimeRangeUserControl.RentFromDate;
            DateTime carRentalTo = carRentalTimeRangeUserControl.RentToDate;
            if (carRentalTo.CompareTo(carRentalFrom) <= 0)
            {
                MessageBox.Show("Data zwrotu nie może być mniejsza lub równa odbioru");
                return;
            }
            selectingCarForRentalUserControl.CarListToRent = await DatabaseManagement.GetCarList(carRentalFrom, carRentalTo);
            selectingCarForRentalUserControl.CarRentalFrom = carRentalFrom;
            selectingCarForRentalUserControl.CarRentalTo = carRentalTo;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(selectingCarForRentalUserControl);
        }

        private void BtnReserv_Click(object sender, EventArgs e)
        {
            if (selectingCarForRentalUserControl.CarId is null)
            {
                MessageBox.Show("Musisz wybrać samochód");
                return;
            }
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(customerDataUserControl);
        }

        private async void BtnConfirmRental_Click(object sender, EventArgs e)
        {
            if (!customerDataUserControl.CheckIfAllCustomerDataAreProvided())
                return;
            DateTime carRentalFrom = carRentalTimeRangeUserControl.RentFromDate;
            DateTime carRentalTo = carRentalTimeRangeUserControl.RentToDate;
            decimal totalCost = selectingCarForRentalUserControl.TotalPrice;
            await DatabaseManagement.SaveRentalDetails(customerDataUserControl, selectingCarForRentalUserControl, carRentalFrom, carRentalTo, totalCost);
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(carRentalConfirmationUserControl);
        }

        private void BtnBackToSelectingCarForRental_Click(object sender, EventArgs e)
        {
            customerDataUserControl.ClearForm();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(selectingCarForRentalUserControl);
        }

        private void BtnBackToCarRentalTimeRange_Click(object sender, EventArgs e)
        {
            selectingCarForRentalUserControl.ClearForm();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(carRentalTimeRangeUserControl);
        }

        private void BtnBackToApp_Click(object sender, EventArgs e)
        {
            selectingCarForRentalUserControl.ClearForm();
            customerDataUserControl.ClearForm();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(carRentalTimeRangeUserControl);
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
