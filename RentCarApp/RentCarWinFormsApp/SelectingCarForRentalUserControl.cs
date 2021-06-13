using EFDatabaseAccess;
using RentCarWinFormsApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarWinFormsApp
{
    public partial class SelectingCarForRentalUserControl : UserControl
    {
        public SelectingCarForRentalUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler BtnReserv { add { btnReserv.Click += value; } remove { btnReserv.Click -= value; } }
        public event EventHandler BtnBack { add { btnBack.Click += value; } remove { btnBack.Click -= value; } }

        public object CarListToRent { 
            set {
                dgvCarList.DataSource = value;
            } 
        }
        public DateTime CarRentalFrom { get; set; }
        public DateTime CarRentalTo { get; set; }
        public decimal TotalPrice { get; private set; } = 0;
        public Guid? CarId { get; set; } = null;

        public void ClearForm()
        {
            picbCar.Image = null;
            lblTotalRentalPrice.Text = "Wybierz samochód by zobaczyć całkowitą cene";
            CarId = null;
            lblPicCar.Visible = true;
        }

        private async void DgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCarList.Columns[e.ColumnIndex].Name != "ShowCar")
                    return;
                var carId = dgvCarList.Rows[e.RowIndex].Cells[dgvCarList.Columns["CarId"].Index].Value;
                bool parseIsSuccess = decimal.TryParse(dgvCarList.Rows[e.RowIndex].Cells[dgvCarList.Columns["Price"].Index].Value.ToString(), out decimal price);
                if (!parseIsSuccess)
                {
                    MessageBox.Show("Coś poszło nie tak");
                    return;
                }
                lblPicCar.Visible = false;
                using var ms = new MemoryStream(await DatabaseManagement.GetCarImage(carId));
                picbCar.Image = Image.FromStream(ms);

                var rentTime = (CarRentalTo - CarRentalFrom).TotalDays;
                TotalPrice = (decimal)(rentTime * decimal.ToDouble(price));
                lblTotalRentalPrice.Text = (TotalPrice).ToString("0.##");
                CarId = (Guid)carId;
            }
            catch
            {
                MessageBox.Show("Uwaga! Coś poszło nie tak");
            }
        }
    }
}
