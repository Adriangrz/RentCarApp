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
    public partial class CarRentalTimeRangeUserControl : UserControl
    {
        public CarRentalTimeRangeUserControl()
        {
            InitializeComponent();
            dtpRentToDate.MinDate = DateTime.Today;
            dtpRentToDate.Value = DateTime.Today.AddDays(1);
            dtpRentFromDate.MinDate = DateTime.Today;
            dtpRentFromDate.Value = DateTime.Today;
        }
        public event EventHandler BtnSelectTimeRange { add { btnSelectTimeRange.Click += value; } remove { btnSelectTimeRange.Click -= value; } }

        public DateTime RentFromDate
        { 
            get {
                return dtpRentFromDate.Value.Date.AddHours(dtpRentFromTime.Value.Hour).AddMinutes(dtpRentFromTime.Value.Hour);
            } 
        }
        public DateTime RentToDate
        {
            get
            {
                return dtpRentToDate.Value.Date.AddHours(dtpRentToTime.Value.Hour).AddMinutes(dtpRentToTime.Value.Hour);
            }
        }
    }
}
