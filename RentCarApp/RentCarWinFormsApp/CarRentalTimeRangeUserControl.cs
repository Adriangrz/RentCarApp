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
            dtpRentFromDate.MinDate = DateTime.Today;
            dtpRentToDate.MinDate = DateTime.Today;
        }
        public event EventHandler BtnSelectTimeRange { add { btnSelectTimeRange.Click += value; } remove { btnSelectTimeRange.Click -= value; } }

        public DateTime RentFromDate
        { 
            get {
                return dtpRentFromDate.Value.Date.Add(dtpRentFromTime.Value.TimeOfDay);
            } 
        }
        public DateTime RentToDate
        {
            get
            {
                return dtpRentToDate.Value.Date.Add(dtpRentToTime.Value.TimeOfDay);
            }
        }
    }
}
