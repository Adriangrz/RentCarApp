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
    public partial class SelectingCarForRentalUserControl : UserControl
    {
        public SelectingCarForRentalUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler BtnReserv { add { btnReserv.Click += value; } remove { btnReserv.Click -= value; } }
        public event EventHandler BtnBack { add { btnBack.Click += value; } remove { btnBack.Click -= value; } }
    }
}
