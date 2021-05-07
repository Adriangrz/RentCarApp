
namespace RentCarApp
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlCustomerData = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.txtbStreet = new System.Windows.Forms.TextBox();
            this.txtbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.pnlAccept = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlCustomerData.SuspendLayout();
            this.pnlAccept.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(702, 103);
            this.pnlTitle.TabIndex = 0;
            // 
            // pnlCustomerData
            // 
            this.pnlCustomerData.Controls.Add(this.txtbEmail);
            this.pnlCustomerData.Controls.Add(this.txtbPhoneNumber);
            this.pnlCustomerData.Controls.Add(this.txtbStreet);
            this.pnlCustomerData.Controls.Add(this.txtbCity);
            this.pnlCustomerData.Controls.Add(this.txtbSurname);
            this.pnlCustomerData.Controls.Add(this.txtbName);
            this.pnlCustomerData.Controls.Add(this.lblEmail);
            this.pnlCustomerData.Controls.Add(this.lblPhoneNumber);
            this.pnlCustomerData.Controls.Add(this.lblStreet);
            this.pnlCustomerData.Controls.Add(this.lblCity);
            this.pnlCustomerData.Controls.Add(this.lblSurname);
            this.pnlCustomerData.Controls.Add(this.lblName);
            this.pnlCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerData.Location = new System.Drawing.Point(0, 103);
            this.pnlCustomerData.Name = "pnlCustomerData";
            this.pnlCustomerData.Size = new System.Drawing.Size(702, 303);
            this.pnlCustomerData.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 103);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Wpisz swoje dane by potwierdzić wypożyczenie";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(202, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Imię";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurname.Location = new System.Drawing.Point(202, 86);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Nazwisko";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(202, 124);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Miasto";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreet.Location = new System.Drawing.Point(202, 162);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 16);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Ulica";
            this.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(202, 200);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 16);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Numer telefonu";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(202, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbName
            // 
            this.txtbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbName.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbName.Location = new System.Drawing.Point(328, 46);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(172, 20);
            this.txtbName.TabIndex = 6;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbSurname.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbSurname.Location = new System.Drawing.Point(328, 84);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(172, 20);
            this.txtbSurname.TabIndex = 7;
            // 
            // txtbCity
            // 
            this.txtbCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCity.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbCity.Location = new System.Drawing.Point(328, 122);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(172, 20);
            this.txtbCity.TabIndex = 8;
            // 
            // txtbStreet
            // 
            this.txtbStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbStreet.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbStreet.Location = new System.Drawing.Point(328, 160);
            this.txtbStreet.Name = "txtbStreet";
            this.txtbStreet.Size = new System.Drawing.Size(172, 20);
            this.txtbStreet.TabIndex = 9;
            // 
            // txtbPhoneNumber
            // 
            this.txtbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbPhoneNumber.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbPhoneNumber.Location = new System.Drawing.Point(328, 198);
            this.txtbPhoneNumber.Name = "txtbPhoneNumber";
            this.txtbPhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.txtbPhoneNumber.TabIndex = 10;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbEmail.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbEmail.Location = new System.Drawing.Point(328, 236);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(172, 20);
            this.txtbEmail.TabIndex = 11;
            // 
            // pnlAccept
            // 
            this.pnlAccept.Controls.Add(this.btnAccept);
            this.pnlAccept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAccept.Location = new System.Drawing.Point(0, 406);
            this.pnlAccept.Name = "pnlAccept";
            this.pnlAccept.Size = new System.Drawing.Size(702, 81);
            this.pnlAccept.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.Location = new System.Drawing.Point(281, 25);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(141, 30);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Potwierdz";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // CustomerDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCustomerData);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlAccept);
            this.Name = "CustomerDataUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.pnlTitle.ResumeLayout(false);
            this.pnlCustomerData.ResumeLayout(false);
            this.pnlCustomerData.PerformLayout();
            this.pnlAccept.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCustomerData;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbPhoneNumber;
        private System.Windows.Forms.TextBox txtbStreet;
        private System.Windows.Forms.TextBox txtbCity;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlAccept;
        private System.Windows.Forms.Button btnAccept;
    }
}
