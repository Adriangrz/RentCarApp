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
    public partial class CustomerDataUserControl : UserControl
    {
        public CustomerDataUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler BtnConfirmRental { add { btnConfirmRental.Click += value; } remove { btnConfirmRental.Click -= value; } }
        public event EventHandler BtnBack { add { btnBack.Click += value; } remove { btnBack.Click -= value; } }
        public string CustomerName
        { 
            get 
            {
                return txtbName.Text;
            } 
        }
        public string CustomerSurname
        {
            get
            {
                return txtbSurname.Text;
            }
        }
        public string CustomerCity
        {
            get
            {
                return txtbCity.Text;
            }
        }
        public string CustomerStreet
        {
            get
            {
                return txtbStreet.Text;
            }
        }
        public int CustomerPhoneNumber
        {
            get
            {
                return int.Parse(txtbPhoneNumber.Text);
            }
        }
        public string CustomerEmail
        {
            get
            {
                return txtbEmail.Text;
            }
        }
        public void ClearForm()
        {
            txtbName.Text = "";
            txtbSurname.Text = "";
            txtbCity.Text = "";
            txtbStreet.Text = "";
            txtbPhoneNumber.Text = "";
            txtbEmail.Text = "";
        }
        public bool CheckIfAllCustomerDataAreProvided()
        {
            erPrvCustomerData.Clear();

            bool allCustomerDataAreProvided = true;

            if (string.IsNullOrWhiteSpace(txtbName.Text))
            {
                erPrvCustomerData.SetError(txtbName, "Pole jest wymagane");
                allCustomerDataAreProvided = false;
            }
            if (string.IsNullOrWhiteSpace(txtbSurname.Text))
            {
                erPrvCustomerData.SetError(txtbSurname, "Pole jest wymagane");
                allCustomerDataAreProvided = false;
            }
            if (string.IsNullOrWhiteSpace(txtbCity.Text))
            {
                erPrvCustomerData.SetError(txtbCity, "Pole jest wymagane");
                allCustomerDataAreProvided = false;
            }
            if (string.IsNullOrWhiteSpace(txtbStreet.Text))
            {
                erPrvCustomerData.SetError(txtbStreet, "Pole jest wymagane");
                allCustomerDataAreProvided = false;
            }
            if (string.IsNullOrWhiteSpace(txtbPhoneNumber.Text))
            {
                erPrvCustomerData.SetError(txtbPhoneNumber, "Pole jest wymagane");
                allCustomerDataAreProvided = false;
            }
            if (string.IsNullOrWhiteSpace(txtbEmail.Text))
            {
                erPrvCustomerData.SetError(txtbEmail, "Pole jest wymagane");
                allCustomerDataAreProvided = false;
            }

            return allCustomerDataAreProvided;
        }
    }
}
