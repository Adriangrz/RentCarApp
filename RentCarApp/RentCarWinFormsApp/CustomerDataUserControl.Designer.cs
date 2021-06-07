
namespace RentCarWinFormsApp
{
    partial class CustomerDataUserControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAcceptOrBack = new System.Windows.Forms.Panel();
            this.btnConfirmRental = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tlpnlUserData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlData1 = new System.Windows.Forms.Panel();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlData2 = new System.Windows.Forms.Panel();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.pnlData3 = new System.Windows.Forms.Panel();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.pnlData4 = new System.Windows.Forms.Panel();
            this.txtbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.pnlData5 = new System.Windows.Forms.Panel();
            this.txtbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.pnlData6 = new System.Windows.Forms.Panel();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.erPrvCustomerData = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlAcceptOrBack.SuspendLayout();
            this.tlpnlUserData.SuspendLayout();
            this.pnlData1.SuspendLayout();
            this.pnlData2.SuspendLayout();
            this.pnlData3.SuspendLayout();
            this.pnlData4.SuspendLayout();
            this.pnlData5.SuspendLayout();
            this.pnlData6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPrvCustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(702, 67);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Wpisz swoje dane by potwierdzić wypożyczenie";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAcceptOrBack
            // 
            this.pnlAcceptOrBack.Controls.Add(this.btnConfirmRental);
            this.pnlAcceptOrBack.Controls.Add(this.btnBack);
            this.pnlAcceptOrBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcceptOrBack.Location = new System.Drawing.Point(0, 417);
            this.pnlAcceptOrBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlAcceptOrBack.Name = "pnlAcceptOrBack";
            this.pnlAcceptOrBack.Size = new System.Drawing.Size(702, 70);
            this.pnlAcceptOrBack.TabIndex = 1;
            // 
            // btnConfirmRental
            // 
            this.btnConfirmRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmRental.FlatAppearance.BorderSize = 0;
            this.btnConfirmRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmRental.Location = new System.Drawing.Point(380, 17);
            this.btnConfirmRental.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnConfirmRental.Name = "btnConfirmRental";
            this.btnConfirmRental.Size = new System.Drawing.Size(150, 36);
            this.btnConfirmRental.TabIndex = 1;
            this.btnConfirmRental.Text = "Potwierdz";
            this.btnConfirmRental.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(173, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Wstecz";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // tlpnlUserData
            // 
            this.tlpnlUserData.ColumnCount = 1;
            this.tlpnlUserData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlUserData.Controls.Add(this.pnlData1, 0, 1);
            this.tlpnlUserData.Controls.Add(this.pnlData2, 0, 2);
            this.tlpnlUserData.Controls.Add(this.pnlData3, 0, 3);
            this.tlpnlUserData.Controls.Add(this.pnlData4, 0, 4);
            this.tlpnlUserData.Controls.Add(this.pnlData5, 0, 5);
            this.tlpnlUserData.Controls.Add(this.pnlData6, 0, 6);
            this.tlpnlUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlUserData.Location = new System.Drawing.Point(0, 67);
            this.tlpnlUserData.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tlpnlUserData.Name = "tlpnlUserData";
            this.tlpnlUserData.RowCount = 8;
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpnlUserData.Size = new System.Drawing.Size(702, 350);
            this.tlpnlUserData.TabIndex = 2;
            // 
            // pnlData1
            // 
            this.pnlData1.Controls.Add(this.txtbName);
            this.pnlData1.Controls.Add(this.lblName);
            this.pnlData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData1.Location = new System.Drawing.Point(4, 46);
            this.pnlData1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData1.Name = "pnlData1";
            this.pnlData1.Size = new System.Drawing.Size(694, 37);
            this.pnlData1.TabIndex = 0;
            // 
            // txtbName
            // 
            this.txtbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbName.Location = new System.Drawing.Point(342, 4);
            this.txtbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(200, 28);
            this.txtbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(152, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Imię";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData2
            // 
            this.pnlData2.Controls.Add(this.txtbSurname);
            this.pnlData2.Controls.Add(this.lblSurname);
            this.pnlData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData2.Location = new System.Drawing.Point(4, 89);
            this.pnlData2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData2.Name = "pnlData2";
            this.pnlData2.Size = new System.Drawing.Size(694, 37);
            this.pnlData2.TabIndex = 1;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbSurname.Location = new System.Drawing.Point(343, 4);
            this.txtbSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(200, 28);
            this.txtbSurname.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(151, 4);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(96, 25);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Nazwisko";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData3
            // 
            this.pnlData3.Controls.Add(this.txtbCity);
            this.pnlData3.Controls.Add(this.lblCity);
            this.pnlData3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData3.Location = new System.Drawing.Point(4, 132);
            this.pnlData3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData3.Name = "pnlData3";
            this.pnlData3.Size = new System.Drawing.Size(694, 37);
            this.pnlData3.TabIndex = 2;
            // 
            // txtbCity
            // 
            this.txtbCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbCity.Location = new System.Drawing.Point(342, 4);
            this.txtbCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(200, 28);
            this.txtbCity.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(151, 4);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(70, 25);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Miasto";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData4
            // 
            this.pnlData4.Controls.Add(this.txtbStreet);
            this.pnlData4.Controls.Add(this.lblStreet);
            this.pnlData4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData4.Location = new System.Drawing.Point(4, 175);
            this.pnlData4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData4.Name = "pnlData4";
            this.pnlData4.Size = new System.Drawing.Size(694, 37);
            this.pnlData4.TabIndex = 3;
            // 
            // txtbStreet
            // 
            this.txtbStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbStreet.Location = new System.Drawing.Point(342, 4);
            this.txtbStreet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbStreet.Name = "txtbStreet";
            this.txtbStreet.Size = new System.Drawing.Size(200, 28);
            this.txtbStreet.TabIndex = 1;
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(152, 4);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(55, 25);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Ulica";
            this.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData5
            // 
            this.pnlData5.Controls.Add(this.txtbPhoneNumber);
            this.pnlData5.Controls.Add(this.lblPhoneNumber);
            this.pnlData5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData5.Location = new System.Drawing.Point(4, 218);
            this.pnlData5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData5.Name = "pnlData5";
            this.pnlData5.Size = new System.Drawing.Size(694, 37);
            this.pnlData5.TabIndex = 4;
            // 
            // txtbPhoneNumber
            // 
            this.txtbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbPhoneNumber.Location = new System.Drawing.Point(342, 4);
            this.txtbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbPhoneNumber.Name = "txtbPhoneNumber";
            this.txtbPhoneNumber.Size = new System.Drawing.Size(200, 28);
            this.txtbPhoneNumber.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(151, 4);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 25);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Numer telefonu";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData6
            // 
            this.pnlData6.Controls.Add(this.txtbEmail);
            this.pnlData6.Controls.Add(this.lblEmail);
            this.pnlData6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData6.Location = new System.Drawing.Point(4, 261);
            this.pnlData6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData6.Name = "pnlData6";
            this.pnlData6.Size = new System.Drawing.Size(694, 37);
            this.pnlData6.TabIndex = 5;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbEmail.Location = new System.Drawing.Point(342, 4);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(200, 28);
            this.txtbEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(151, 4);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erPrvCustomerData
            // 
            this.erPrvCustomerData.ContainerControl = this;
            // 
            // CustomerDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpnlUserData);
            this.Controls.Add(this.pnlAcceptOrBack);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "CustomerDataUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.pnlTitle.ResumeLayout(false);
            this.pnlAcceptOrBack.ResumeLayout(false);
            this.tlpnlUserData.ResumeLayout(false);
            this.pnlData1.ResumeLayout(false);
            this.pnlData1.PerformLayout();
            this.pnlData2.ResumeLayout(false);
            this.pnlData2.PerformLayout();
            this.pnlData3.ResumeLayout(false);
            this.pnlData3.PerformLayout();
            this.pnlData4.ResumeLayout(false);
            this.pnlData4.PerformLayout();
            this.pnlData5.ResumeLayout(false);
            this.pnlData5.PerformLayout();
            this.pnlData6.ResumeLayout(false);
            this.pnlData6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPrvCustomerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlAcceptOrBack;
        private System.Windows.Forms.TableLayoutPanel tlpnlUserData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnConfirmRental;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlData1;
        private System.Windows.Forms.Panel pnlData2;
        private System.Windows.Forms.Panel pnlData3;
        private System.Windows.Forms.Panel pnlData4;
        private System.Windows.Forms.Panel pnlData5;
        private System.Windows.Forms.Panel pnlData6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbCity;
        private System.Windows.Forms.TextBox txtbStreet;
        private System.Windows.Forms.TextBox txtbPhoneNumber;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.ErrorProvider erPrvCustomerData;
    }
}
