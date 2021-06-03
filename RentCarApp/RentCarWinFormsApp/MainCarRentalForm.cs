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
        private CarRentalTimeRangeUserControl _carRentalTimeRangeUserControl;
        private SelectingCarForRentalUserControl _selectingCarForRentalUserControl;
        private CustomerDataUserControl _customerDataUserControl;
        private CarRentalConfirmationUserControl _carRentalConfirmationUserControl;
        public MainCarRentalForm(CarRentalTimeRangeUserControl carRentalTimeRangeUserControl, SelectingCarForRentalUserControl selectingCarForRentalUserControl, CustomerDataUserControl customerDataUserControl, CarRentalConfirmationUserControl carRentalConfirmationUserControl)
        {
            InitializeComponent();
            _carRentalTimeRangeUserControl = carRentalTimeRangeUserControl;
            _selectingCarForRentalUserControl = selectingCarForRentalUserControl;
            _customerDataUserControl = customerDataUserControl;
            _carRentalConfirmationUserControl = carRentalConfirmationUserControl;

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
            DateTime carRentalFrom = _carRentalTimeRangeUserControl.RentFromDate;
            DateTime carRentalTo = _carRentalTimeRangeUserControl.RentToDate;
            if (carRentalTo.CompareTo(carRentalFrom) <= 0)
            {
                MessageBox.Show("Data zwrotu nie może być mniejsza lub równa odbioru");
                return;
            }
            _selectingCarForRentalUserControl.CarListToRent = await DatabaseManagement.GetCarList(carRentalFrom, carRentalTo);
            _selectingCarForRentalUserControl.CarRentalFrom = carRentalFrom;
            _selectingCarForRentalUserControl.CarRentalTo = carRentalTo;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_selectingCarForRentalUserControl);
        }

        private void BtnReserv_Click(object sender, EventArgs e)
        {
            if (_selectingCarForRentalUserControl.CarId is null)
            {
                MessageBox.Show("Musisz wybrać samochód");
                return;
            }
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_customerDataUserControl);
        }

        private async void BtnConfirmRental_Click(object sender, EventArgs e)
        {
            if (!_customerDataUserControl.CheckIfAllCustomerDataAreProvided())
                return;
            DateTime carRentalFrom = _carRentalTimeRangeUserControl.RentFromDate;
            DateTime carRentalTo = _carRentalTimeRangeUserControl.RentToDate;
            decimal totalCost = _selectingCarForRentalUserControl.TotalPrice;
            await DatabaseManagement.SaveRentalDetails(_customerDataUserControl, _selectingCarForRentalUserControl, carRentalFrom, carRentalTo, totalCost);
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_carRentalConfirmationUserControl);
        }

        private void BtnBackToSelectingCarForRental_Click(object sender, EventArgs e)
        {
            _customerDataUserControl.ClearForm();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_selectingCarForRentalUserControl);
        }

        private void BtnBackToCarRentalTimeRange_Click(object sender, EventArgs e)
        {
            _selectingCarForRentalUserControl.ClearForm();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_carRentalTimeRangeUserControl);
        }

        private void BtnBackToApp_Click(object sender, EventArgs e)
        {
            _selectingCarForRentalUserControl.ClearForm();
            _customerDataUserControl.ClearForm();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_carRentalTimeRangeUserControl);
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
