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
    public partial class CarRentalConfirmationUserControl : UserControl
    {
        public CarRentalConfirmationUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler BtnBackToApp { add { btnBackToApp.Click += value; } remove { btnBackToApp.Click -= value; } }
        public event EventHandler BtnExitApp { add { btnExitApp.Click += value; } remove { btnExitApp.Click -= value; } }
    }
}
