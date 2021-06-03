
namespace RentCarWinFormsApp
{
    partial class SelectingCarForRentalUserControl
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
            this.tlpnlSelectingCar = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSelectedCarDetails = new System.Windows.Forms.Panel();
            this.pnlCarPic = new System.Windows.Forms.Panel();
            this.lblPicCar = new System.Windows.Forms.Label();
            this.picbCar = new System.Windows.Forms.PictureBox();
            this.pnlTotalRentalPrice = new System.Windows.Forms.Panel();
            this.lblTotalRentalPrice = new System.Windows.Forms.Label();
            this.lblTotalRentalPriceTag = new System.Windows.Forms.Label();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.ShowCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpnlReservOrBack = new System.Windows.Forms.TableLayoutPanel();
            this.btnReserv = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tlpnlSelectingCar.SuspendLayout();
            this.pnlSelectedCarDetails.SuspendLayout();
            this.pnlCarPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCar)).BeginInit();
            this.pnlTotalRentalPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.tlpnlReservOrBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpnlSelectingCar
            // 
            this.tlpnlSelectingCar.ColumnCount = 2;
            this.tlpnlSelectingCar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlSelectingCar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlSelectingCar.Controls.Add(this.pnlSelectedCarDetails, 0, 0);
            this.tlpnlSelectingCar.Controls.Add(this.dgvCarList, 1, 0);
            this.tlpnlSelectingCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlSelectingCar.Location = new System.Drawing.Point(0, 0);
            this.tlpnlSelectingCar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tlpnlSelectingCar.Name = "tlpnlSelectingCar";
            this.tlpnlSelectingCar.RowCount = 1;
            this.tlpnlSelectingCar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlSelectingCar.Size = new System.Drawing.Size(702, 409);
            this.tlpnlSelectingCar.TabIndex = 0;
            // 
            // pnlSelectedCarDetails
            // 
            this.pnlSelectedCarDetails.Controls.Add(this.pnlCarPic);
            this.pnlSelectedCarDetails.Controls.Add(this.pnlTotalRentalPrice);
            this.pnlSelectedCarDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectedCarDetails.Location = new System.Drawing.Point(5, 3);
            this.pnlSelectedCarDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlSelectedCarDetails.Name = "pnlSelectedCarDetails";
            this.pnlSelectedCarDetails.Size = new System.Drawing.Size(341, 403);
            this.pnlSelectedCarDetails.TabIndex = 0;
            // 
            // pnlCarPic
            // 
            this.pnlCarPic.Controls.Add(this.lblPicCar);
            this.pnlCarPic.Controls.Add(this.picbCar);
            this.pnlCarPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCarPic.Location = new System.Drawing.Point(0, 0);
            this.pnlCarPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCarPic.Name = "pnlCarPic";
            this.pnlCarPic.Size = new System.Drawing.Size(341, 324);
            this.pnlCarPic.TabIndex = 0;
            // 
            // lblPicCar
            // 
            this.lblPicCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPicCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPicCar.Location = new System.Drawing.Point(8, 144);
            this.lblPicCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPicCar.Name = "lblPicCar";
            this.lblPicCar.Size = new System.Drawing.Size(324, 36);
            this.lblPicCar.TabIndex = 2;
            this.lblPicCar.Text = "Wybierz samochód by zobaczyć jego wygląd";
            this.lblPicCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbCar
            // 
            this.picbCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbCar.Location = new System.Drawing.Point(0, 0);
            this.picbCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picbCar.Name = "picbCar";
            this.picbCar.Size = new System.Drawing.Size(341, 324);
            this.picbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbCar.TabIndex = 0;
            this.picbCar.TabStop = false;
            // 
            // pnlTotalRentalPrice
            // 
            this.pnlTotalRentalPrice.Controls.Add(this.lblTotalRentalPrice);
            this.pnlTotalRentalPrice.Controls.Add(this.lblTotalRentalPriceTag);
            this.pnlTotalRentalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalRentalPrice.Location = new System.Drawing.Point(0, 324);
            this.pnlTotalRentalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTotalRentalPrice.Name = "pnlTotalRentalPrice";
            this.pnlTotalRentalPrice.Size = new System.Drawing.Size(341, 79);
            this.pnlTotalRentalPrice.TabIndex = 1;
            // 
            // lblTotalRentalPrice
            // 
            this.lblTotalRentalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRentalPrice.Location = new System.Drawing.Point(54, 41);
            this.lblTotalRentalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRentalPrice.Name = "lblTotalRentalPrice";
            this.lblTotalRentalPrice.Size = new System.Drawing.Size(232, 31);
            this.lblTotalRentalPrice.TabIndex = 1;
            this.lblTotalRentalPrice.Text = "Wybierz samochód by zobaczyć całkowitą cene";
            this.lblTotalRentalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRentalPriceTag
            // 
            this.lblTotalRentalPriceTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalRentalPriceTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRentalPriceTag.Location = new System.Drawing.Point(39, 8);
            this.lblTotalRentalPriceTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRentalPriceTag.Name = "lblTotalRentalPriceTag";
            this.lblTotalRentalPriceTag.Size = new System.Drawing.Size(262, 22);
            this.lblTotalRentalPriceTag.TabIndex = 0;
            this.lblTotalRentalPriceTag.Text = "Całkowita cena wypożyczenia";
            this.lblTotalRentalPriceTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCarList
            // 
            this.dgvCarList.AllowUserToAddRows = false;
            this.dgvCarList.AllowUserToDeleteRows = false;
            this.dgvCarList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowCar});
            this.dgvCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarList.Location = new System.Drawing.Point(356, 3);
            this.dgvCarList.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.RowHeadersWidth = 62;
            this.dgvCarList.RowTemplate.Height = 25;
            this.dgvCarList.Size = new System.Drawing.Size(341, 403);
            this.dgvCarList.TabIndex = 1;
            this.dgvCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarList_CellContentClick);
            // 
            // ShowCar
            // 
            this.ShowCar.HeaderText = "Pokaż samochód";
            this.ShowCar.MinimumWidth = 150;
            this.ShowCar.Name = "ShowCar";
            this.ShowCar.ReadOnly = true;
            this.ShowCar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowCar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ShowCar.Text = "Pokaż samochód";
            this.ShowCar.UseColumnTextForButtonValue = true;
            this.ShowCar.Width = 150;
            // 
            // tlpnlReservOrBack
            // 
            this.tlpnlReservOrBack.ColumnCount = 2;
            this.tlpnlReservOrBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlReservOrBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlReservOrBack.Controls.Add(this.btnReserv, 1, 0);
            this.tlpnlReservOrBack.Controls.Add(this.btnBack, 0, 0);
            this.tlpnlReservOrBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpnlReservOrBack.Location = new System.Drawing.Point(0, 409);
            this.tlpnlReservOrBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tlpnlReservOrBack.Name = "tlpnlReservOrBack";
            this.tlpnlReservOrBack.RowCount = 1;
            this.tlpnlReservOrBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnlReservOrBack.Size = new System.Drawing.Size(702, 78);
            this.tlpnlReservOrBack.TabIndex = 1;
            // 
            // btnReserv
            // 
            this.btnReserv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReserv.FlatAppearance.BorderSize = 0;
            this.btnReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReserv.Location = new System.Drawing.Point(451, 21);
            this.btnReserv.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnReserv.Name = "btnReserv";
            this.btnReserv.Size = new System.Drawing.Size(150, 36);
            this.btnReserv.TabIndex = 0;
            this.btnReserv.Text = "Rezerwuj";
            this.btnReserv.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(100, 21);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Wstecz";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // SelectingCarForRentalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpnlSelectingCar);
            this.Controls.Add(this.tlpnlReservOrBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectingCarForRentalUserControl";
            this.Size = new System.Drawing.Size(702, 487);
            this.tlpnlSelectingCar.ResumeLayout(false);
            this.pnlSelectedCarDetails.ResumeLayout(false);
            this.pnlCarPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbCar)).EndInit();
            this.pnlTotalRentalPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.tlpnlReservOrBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpnlSelectingCar;
        private System.Windows.Forms.TableLayoutPanel tlpnlReservOrBack;
        private System.Windows.Forms.Panel pnlSelectedCarDetails;
        private System.Windows.Forms.Button btnReserv;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Panel pnlTotalRentalPrice;
        private System.Windows.Forms.Panel pnlCarPic;
        private System.Windows.Forms.PictureBox picbCar;
        private System.Windows.Forms.Label lblTotalRentalPrice;
        private System.Windows.Forms.Label lblTotalRentalPriceTag;
        private System.Windows.Forms.Label lblPicCar;
        private System.Windows.Forms.DataGridViewButtonColumn ShowCar;
    }
}
