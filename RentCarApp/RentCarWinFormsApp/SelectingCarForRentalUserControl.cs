using EFDatabaseAccess;
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

        private void dgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarList.Columns[e.ColumnIndex].Name == "ShowCar")
            {
                var carId = dgvCarList.Rows[e.RowIndex].Cells[1].Value;
                using var context = new RentCarContext();
                
                var data = context.Cars.Where(x => x.CarId == (Guid)carId).Select(x => x.PictureLink).SingleOrDefault();
                lblPicCar.Visible = false;
                using MemoryStream ms = new MemoryStream(data);
                picbCar.Image = Image.FromStream(ms);              
            }
        }
    }
}
