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
    public partial class HelloForm : Form
    {
        public MainCarRentalForm MainCarRentalForm { get; set; }
        public HelloForm(MainCarRentalForm mainCarRentalForm)
        {
            InitializeComponent();
            MainCarRentalForm = mainCarRentalForm;
        }
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            MainCarRentalForm.Location = this.Location;
            MainCarRentalForm.Width = this.Width;
            MainCarRentalForm.Height = this.Height;
            MainCarRentalForm.Show();
            this.Close();
        }

        private void HelloForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainCarRentalForm.Location = this.Location;
            MainCarRentalForm.Width = this.Width;
            MainCarRentalForm.Height = this.Height;
            MainCarRentalForm.Show();
        }
    }
}
