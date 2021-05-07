
namespace RentCarApp
{
    partial class CarRentalTimeRangeUserControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSelectTimeRange = new System.Windows.Forms.Panel();
            this.btnSelectTimeRange = new System.Windows.Forms.Button();
            this.pnlTimeRange = new System.Windows.Forms.Panel();
            this.lblRentTo = new System.Windows.Forms.Label();
            this.lblRentFrom = new System.Windows.Forms.Label();
            this.dtpRentToTime = new System.Windows.Forms.DateTimePicker();
            this.dtpRentFromTime = new System.Windows.Forms.DateTimePicker();
            this.dtpRentToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentFromDate = new System.Windows.Forms.DateTimePicker();
            this.pnlTitle.SuspendLayout();
            this.pnlSelectTimeRange.SuspendLayout();
            this.pnlTimeRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(686, 85);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(686, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Wyszukaj samochód na wynajem";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelectTimeRange
            // 
            this.pnlSelectTimeRange.Controls.Add(this.btnSelectTimeRange);
            this.pnlSelectTimeRange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSelectTimeRange.Location = new System.Drawing.Point(0, 311);
            this.pnlSelectTimeRange.Name = "pnlSelectTimeRange";
            this.pnlSelectTimeRange.Size = new System.Drawing.Size(686, 115);
            this.pnlSelectTimeRange.TabIndex = 1;
            // 
            // btnSelectTimeRange
            // 
            this.btnSelectTimeRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectTimeRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectTimeRange.FlatAppearance.BorderSize = 0;
            this.btnSelectTimeRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTimeRange.Location = new System.Drawing.Point(279, 38);
            this.btnSelectTimeRange.Name = "btnSelectTimeRange";
            this.btnSelectTimeRange.Size = new System.Drawing.Size(128, 38);
            this.btnSelectTimeRange.TabIndex = 0;
            this.btnSelectTimeRange.Text = "Szukaj";
            this.btnSelectTimeRange.UseVisualStyleBackColor = false;
            // 
            // pnlTimeRange
            // 
            this.pnlTimeRange.Controls.Add(this.lblRentTo);
            this.pnlTimeRange.Controls.Add(this.lblRentFrom);
            this.pnlTimeRange.Controls.Add(this.dtpRentToTime);
            this.pnlTimeRange.Controls.Add(this.dtpRentFromTime);
            this.pnlTimeRange.Controls.Add(this.dtpRentToDate);
            this.pnlTimeRange.Controls.Add(this.dtpRentFromDate);
            this.pnlTimeRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimeRange.Location = new System.Drawing.Point(0, 85);
            this.pnlTimeRange.Name = "pnlTimeRange";
            this.pnlTimeRange.Size = new System.Drawing.Size(686, 226);
            this.pnlTimeRange.TabIndex = 2;
            // 
            // lblRentTo
            // 
            this.lblRentTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRentTo.AutoSize = true;
            this.lblRentTo.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRentTo.Location = new System.Drawing.Point(34, 155);
            this.lblRentTo.Name = "lblRentTo";
            this.lblRentTo.Size = new System.Drawing.Size(146, 16);
            this.lblRentTo.TabIndex = 5;
            this.lblRentTo.Text = "Data i godzina zwrotu:";
            this.lblRentTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRentFrom
            // 
            this.lblRentFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRentFrom.AutoSize = true;
            this.lblRentFrom.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRentFrom.Location = new System.Drawing.Point(26, 32);
            this.lblRentFrom.Name = "lblRentFrom";
            this.lblRentFrom.Size = new System.Drawing.Size(154, 16);
            this.lblRentFrom.TabIndex = 4;
            this.lblRentFrom.Text = "Data i godzina odbioru:";
            this.lblRentFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRentToTime
            // 
            this.dtpRentToTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRentToTime.Location = new System.Drawing.Point(520, 153);
            this.dtpRentToTime.Name = "dtpRentToTime";
            this.dtpRentToTime.ShowUpDown = true;
            this.dtpRentToTime.Size = new System.Drawing.Size(141, 20);
            this.dtpRentToTime.TabIndex = 3;
            this.dtpRentToTime.Value = new System.DateTime(2021, 5, 6, 15, 8, 0, 0);
            // 
            // dtpRentFromTime
            // 
            this.dtpRentFromTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRentFromTime.Location = new System.Drawing.Point(520, 32);
            this.dtpRentFromTime.Name = "dtpRentFromTime";
            this.dtpRentFromTime.ShowUpDown = true;
            this.dtpRentFromTime.Size = new System.Drawing.Size(141, 20);
            this.dtpRentFromTime.TabIndex = 2;
            this.dtpRentFromTime.Value = new System.DateTime(2021, 5, 6, 15, 8, 0, 0);
            // 
            // dtpRentToDate
            // 
            this.dtpRentToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentToDate.Location = new System.Drawing.Point(245, 153);
            this.dtpRentToDate.Name = "dtpRentToDate";
            this.dtpRentToDate.Size = new System.Drawing.Size(210, 20);
            this.dtpRentToDate.TabIndex = 1;
            this.dtpRentToDate.Value = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
            // 
            // dtpRentFromDate
            // 
            this.dtpRentFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentFromDate.Location = new System.Drawing.Point(245, 32);
            this.dtpRentFromDate.Name = "dtpRentFromDate";
            this.dtpRentFromDate.Size = new System.Drawing.Size(210, 20);
            this.dtpRentFromDate.TabIndex = 0;
            this.dtpRentFromDate.Value = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
            // 
            // CarRentalTimeRangeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTimeRange);
            this.Controls.Add(this.pnlSelectTimeRange);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "CarRentalTimeRangeUserControl";
            this.Size = new System.Drawing.Size(686, 426);
            this.pnlTitle.ResumeLayout(false);
            this.pnlSelectTimeRange.ResumeLayout(false);
            this.pnlTimeRange.ResumeLayout(false);
            this.pnlTimeRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlSelectTimeRange;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTimeRange;
        private System.Windows.Forms.Button btnSelectTimeRange;
        private System.Windows.Forms.DateTimePicker dtpRentToDate;
        private System.Windows.Forms.DateTimePicker dtpRentFromDate;
        private System.Windows.Forms.DateTimePicker dtpRentFromTime;
        private System.Windows.Forms.DateTimePicker dtpRentToTime;
        private System.Windows.Forms.Label lblRentTo;
        private System.Windows.Forms.Label lblRentFrom;
    }
}
