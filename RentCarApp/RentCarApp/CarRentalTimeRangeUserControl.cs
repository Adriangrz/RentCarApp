using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarApp
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
    }
}
