
namespace RentCarWinFormsApp
{
    partial class CarRentalConfirmationUserControl
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
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnBackToApp = new System.Windows.Forms.Button();
            this.pnlConfirmation.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.Controls.Add(this.lblConfirmation);
            this.pnlConfirmation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmation.Location = new System.Drawing.Point(0, 0);
            this.pnlConfirmation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(702, 373);
            this.pnlConfirmation.TabIndex = 0;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmation.Location = new System.Drawing.Point(0, 0);
            this.lblConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(702, 373);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "Przyjeliśmy zgłoszenie o wypożyczenie samochodu.Dziękujemy za skorzystanie z apli" +
    "kacji i zapraszamy do naszej wypożyczalni.";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnExitApp);
            this.pnlOptions.Controls.Add(this.btnBackToApp);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOptions.Location = new System.Drawing.Point(0, 373);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(702, 114);
            this.pnlOptions.TabIndex = 1;
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExitApp.Location = new System.Drawing.Point(375, 26);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(149, 62);
            this.btnExitApp.TabIndex = 1;
            this.btnExitApp.Text = "Wyjście z aplikacji";
            this.btnExitApp.UseVisualStyleBackColor = false;
            // 
            // btnBackToApp
            // 
            this.btnBackToApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToApp.FlatAppearance.BorderSize = 0;
            this.btnBackToApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackToApp.Location = new System.Drawing.Point(179, 26);
            this.btnBackToApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackToApp.Name = "btnBackToApp";
            this.btnBackToApp.Size = new System.Drawing.Size(149, 62);
            this.btnBackToApp.TabIndex = 0;
            this.btnBackToApp.Text = "Powrót do początku aplikacji";
            this.btnBackToApp.UseVisualStyleBackColor = false;
            // 
            // CarRentalConfirmationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConfirmation);
            this.Controls.Add(this.pnlOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CarRentalConfirmationUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnBackToApp;
        private System.Windows.Forms.Label lblConfirmation;
    }
}
