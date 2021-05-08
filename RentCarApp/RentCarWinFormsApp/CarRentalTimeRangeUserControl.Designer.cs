
namespace RentCarWinFormsApp
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
            this.tlpnlTimeRange = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRentFrom = new System.Windows.Forms.Panel();
            this.dtpRentFromTime = new System.Windows.Forms.DateTimePicker();
            this.dtpRentFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblRentFrom = new System.Windows.Forms.Label();
            this.pnlRentTo = new System.Windows.Forms.Panel();
            this.dtpRentToTime = new System.Windows.Forms.DateTimePicker();
            this.dtpRentToDate = new System.Windows.Forms.DateTimePicker();
            this.lblRentTo = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlSelectTimeRange.SuspendLayout();
            this.tlpnlTimeRange.SuspendLayout();
            this.pnlRentFrom.SuspendLayout();
            this.pnlRentTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Font = new System.Drawing.Font("Californian FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(702, 85);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Wyszukaj samochód na wynajem";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelectTimeRange
            // 
            this.pnlSelectTimeRange.Controls.Add(this.btnSelectTimeRange);
            this.pnlSelectTimeRange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSelectTimeRange.Location = new System.Drawing.Point(0, 372);
            this.pnlSelectTimeRange.Name = "pnlSelectTimeRange";
            this.pnlSelectTimeRange.Size = new System.Drawing.Size(702, 115);
            this.pnlSelectTimeRange.TabIndex = 1;
            // 
            // btnSelectTimeRange
            // 
            this.btnSelectTimeRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectTimeRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectTimeRange.FlatAppearance.BorderSize = 0;
            this.btnSelectTimeRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTimeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectTimeRange.Location = new System.Drawing.Point(287, 38);
            this.btnSelectTimeRange.Name = "btnSelectTimeRange";
            this.btnSelectTimeRange.Size = new System.Drawing.Size(128, 38);
            this.btnSelectTimeRange.TabIndex = 0;
            this.btnSelectTimeRange.Text = "Szukaj";
            this.btnSelectTimeRange.UseVisualStyleBackColor = false;
            // 
            // tlpnlTimeRange
            // 
            this.tlpnlTimeRange.ColumnCount = 1;
            this.tlpnlTimeRange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlTimeRange.Controls.Add(this.pnlRentFrom, 0, 1);
            this.tlpnlTimeRange.Controls.Add(this.pnlRentTo, 0, 2);
            this.tlpnlTimeRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlTimeRange.Location = new System.Drawing.Point(0, 85);
            this.tlpnlTimeRange.Name = "tlpnlTimeRange";
            this.tlpnlTimeRange.RowCount = 4;
            this.tlpnlTimeRange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlTimeRange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlTimeRange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlTimeRange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlTimeRange.Size = new System.Drawing.Size(702, 287);
            this.tlpnlTimeRange.TabIndex = 2;
            // 
            // pnlRentFrom
            // 
            this.pnlRentFrom.Controls.Add(this.dtpRentFromTime);
            this.pnlRentFrom.Controls.Add(this.dtpRentFromDate);
            this.pnlRentFrom.Controls.Add(this.lblRentFrom);
            this.pnlRentFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentFrom.Font = new System.Drawing.Font("Californian FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlRentFrom.Location = new System.Drawing.Point(3, 74);
            this.pnlRentFrom.Name = "pnlRentFrom";
            this.pnlRentFrom.Size = new System.Drawing.Size(696, 65);
            this.pnlRentFrom.TabIndex = 0;
            // 
            // dtpRentFromTime
            // 
            this.dtpRentFromTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentFromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRentFromTime.Location = new System.Drawing.Point(512, 22);
            this.dtpRentFromTime.Name = "dtpRentFromTime";
            this.dtpRentFromTime.ShowUpDown = true;
            this.dtpRentFromTime.Size = new System.Drawing.Size(141, 21);
            this.dtpRentFromTime.TabIndex = 2;
            // 
            // dtpRentFromDate
            // 
            this.dtpRentFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentFromDate.Location = new System.Drawing.Point(241, 22);
            this.dtpRentFromDate.Name = "dtpRentFromDate";
            this.dtpRentFromDate.Size = new System.Drawing.Size(241, 21);
            this.dtpRentFromDate.TabIndex = 1;
            this.dtpRentFromDate.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // lblRentFrom
            // 
            this.lblRentFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRentFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentFrom.Location = new System.Drawing.Point(43, 22);
            this.lblRentFrom.Name = "lblRentFrom";
            this.lblRentFrom.Size = new System.Drawing.Size(168, 21);
            this.lblRentFrom.TabIndex = 0;
            this.lblRentFrom.Text = "Data i godzina odbioru:";
            this.lblRentFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRentTo
            // 
            this.pnlRentTo.Controls.Add(this.dtpRentToTime);
            this.pnlRentTo.Controls.Add(this.dtpRentToDate);
            this.pnlRentTo.Controls.Add(this.lblRentTo);
            this.pnlRentTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentTo.Font = new System.Drawing.Font("Californian FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlRentTo.Location = new System.Drawing.Point(3, 145);
            this.pnlRentTo.Name = "pnlRentTo";
            this.pnlRentTo.Size = new System.Drawing.Size(696, 65);
            this.pnlRentTo.TabIndex = 1;
            // 
            // dtpRentToTime
            // 
            this.dtpRentToTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentToTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRentToTime.Location = new System.Drawing.Point(512, 22);
            this.dtpRentToTime.Name = "dtpRentToTime";
            this.dtpRentToTime.ShowUpDown = true;
            this.dtpRentToTime.Size = new System.Drawing.Size(141, 21);
            this.dtpRentToTime.TabIndex = 2;
            // 
            // dtpRentToDate
            // 
            this.dtpRentToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRentToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentToDate.Location = new System.Drawing.Point(241, 22);
            this.dtpRentToDate.Name = "dtpRentToDate";
            this.dtpRentToDate.Size = new System.Drawing.Size(241, 21);
            this.dtpRentToDate.TabIndex = 1;
            this.dtpRentToDate.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // lblRentTo
            // 
            this.lblRentTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentTo.Location = new System.Drawing.Point(43, 22);
            this.lblRentTo.Name = "lblRentTo";
            this.lblRentTo.Size = new System.Drawing.Size(168, 21);
            this.lblRentTo.TabIndex = 0;
            this.lblRentTo.Text = "Data i godzina zwrotu:";
            this.lblRentTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarRentalTimeRangeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpnlTimeRange);
            this.Controls.Add(this.pnlSelectTimeRange);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Californian FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CarRentalTimeRangeUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.pnlTitle.ResumeLayout(false);
            this.pnlSelectTimeRange.ResumeLayout(false);
            this.tlpnlTimeRange.ResumeLayout(false);
            this.pnlRentFrom.ResumeLayout(false);
            this.pnlRentTo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlSelectTimeRange;
        private System.Windows.Forms.TableLayoutPanel tlpnlTimeRange;
        private System.Windows.Forms.Button btnSelectTimeRange;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRentFrom;
        private System.Windows.Forms.Panel pnlRentTo;
        private System.Windows.Forms.DateTimePicker dtpRentFromTime;
        private System.Windows.Forms.DateTimePicker dtpRentFromDate;
        private System.Windows.Forms.Label lblRentFrom;
        private System.Windows.Forms.DateTimePicker dtpRentToTime;
        private System.Windows.Forms.DateTimePicker dtpRentToDate;
        private System.Windows.Forms.Label lblRentTo;
    }
}
