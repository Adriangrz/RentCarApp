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
    public partial class MainCarRentalForm : Form
    {
        private SelectingCarForRentalUserControl selectingCarForRentalUserControl = new SelectingCarForRentalUserControl();
        private CarRentalTimeRangeUserControl carRentalTimeRangeUserControl = new CarRentalTimeRangeUserControl();
        public MainCarRentalForm()
        {
            InitializeComponent();
            carRentalTimeRangeUserControl.Dock = DockStyle.Fill;
            carRentalTimeRangeUserControl.BtnSelectTimeRange += BtnSelectTimeRange_Click;
            pnlMain.Controls.Add(carRentalTimeRangeUserControl);
        }

        private void MainCarRentalForm_Shown(object sender, EventArgs e)
        {
            HelloForm helloForm = new HelloForm(this);
            helloForm.Show();
            this.Hide();
        }
        private void BtnSelectTimeRange_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            selectingCarForRentalUserControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(selectingCarForRentalUserControl);
        }
    }
}
