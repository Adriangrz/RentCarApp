
namespace RentCarApp
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
            this.pnlSelectedCarDetails = new System.Windows.Forms.Panel();
            this.lblTotalRentalPriceTag = new System.Windows.Forms.Label();
            this.lblTotalRentalPrice = new System.Windows.Forms.Label();
            this.picbCar = new System.Windows.Forms.PictureBox();
            this.pnlCarList = new System.Windows.Forms.Panel();
            this.pnlReserv = new System.Windows.Forms.Panel();
            this.btnReserv = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotalRentalPrice = new System.Windows.Forms.Panel();
            this.pnlCarPic = new System.Windows.Forms.Panel();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourlyRentalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowCar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPicCar = new System.Windows.Forms.Label();
            this.pnlSelectedCarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCar)).BeginInit();
            this.pnlCarList.SuspendLayout();
            this.pnlReserv.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTotalRentalPrice.SuspendLayout();
            this.pnlCarPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelectedCarDetails
            // 
            this.pnlSelectedCarDetails.Controls.Add(this.pnlCarPic);
            this.pnlSelectedCarDetails.Controls.Add(this.pnlTotalRentalPrice);
            this.pnlSelectedCarDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectedCarDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlSelectedCarDetails.Name = "pnlSelectedCarDetails";
            this.pnlSelectedCarDetails.Size = new System.Drawing.Size(330, 337);
            this.pnlSelectedCarDetails.TabIndex = 0;
            // 
            // lblTotalRentalPriceTag
            // 
            this.lblTotalRentalPriceTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalRentalPriceTag.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalRentalPriceTag.Location = new System.Drawing.Point(53, 5);
            this.lblTotalRentalPriceTag.Name = "lblTotalRentalPriceTag";
            this.lblTotalRentalPriceTag.Size = new System.Drawing.Size(225, 24);
            this.lblTotalRentalPriceTag.TabIndex = 2;
            this.lblTotalRentalPriceTag.Text = "Całkowita cena wypożyczenia";
            this.lblTotalRentalPriceTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRentalPrice
            // 
            this.lblTotalRentalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalRentalPrice.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalRentalPrice.Location = new System.Drawing.Point(66, 37);
            this.lblTotalRentalPrice.Name = "lblTotalRentalPrice";
            this.lblTotalRentalPrice.Size = new System.Drawing.Size(199, 33);
            this.lblTotalRentalPrice.TabIndex = 1;
            this.lblTotalRentalPrice.Text = "Wybierz samochód by zobaczyć całkowitą cene";
            this.lblTotalRentalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbCar
            // 
            this.picbCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbCar.Location = new System.Drawing.Point(0, 0);
            this.picbCar.Name = "picbCar";
            this.picbCar.Size = new System.Drawing.Size(330, 262);
            this.picbCar.TabIndex = 0;
            this.picbCar.TabStop = false;
            // 
            // pnlCarList
            // 
            this.pnlCarList.Controls.Add(this.dgvCarList);
            this.pnlCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCarList.Location = new System.Drawing.Point(339, 3);
            this.pnlCarList.Name = "pnlCarList";
            this.pnlCarList.Size = new System.Drawing.Size(330, 337);
            this.pnlCarList.TabIndex = 1;
            // 
            // pnlReserv
            // 
            this.pnlReserv.Controls.Add(this.btnReserv);
            this.pnlReserv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReserv.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pnlReserv.Location = new System.Drawing.Point(0, 343);
            this.pnlReserv.Name = "pnlReserv";
            this.pnlReserv.Size = new System.Drawing.Size(672, 86);
            this.pnlReserv.TabIndex = 2;
            // 
            // btnReserv
            // 
            this.btnReserv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReserv.FlatAppearance.BorderSize = 0;
            this.btnReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserv.Location = new System.Drawing.Point(272, 24);
            this.btnReserv.Name = "btnReserv";
            this.btnReserv.Size = new System.Drawing.Size(128, 38);
            this.btnReserv.TabIndex = 0;
            this.btnReserv.Text = "Rezerwuj";
            this.btnReserv.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCarList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSelectedCarDetails, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 343);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlTotalRentalPrice
            // 
            this.pnlTotalRentalPrice.Controls.Add(this.lblTotalRentalPrice);
            this.pnlTotalRentalPrice.Controls.Add(this.lblTotalRentalPriceTag);
            this.pnlTotalRentalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalRentalPrice.Location = new System.Drawing.Point(0, 262);
            this.pnlTotalRentalPrice.Name = "pnlTotalRentalPrice";
            this.pnlTotalRentalPrice.Size = new System.Drawing.Size(330, 75);
            this.pnlTotalRentalPrice.TabIndex = 3;
            // 
            // pnlCarPic
            // 
            this.pnlCarPic.Controls.Add(this.lblPicCar);
            this.pnlCarPic.Controls.Add(this.picbCar);
            this.pnlCarPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCarPic.Location = new System.Drawing.Point(0, 0);
            this.pnlCarPic.Name = "pnlCarPic";
            this.pnlCarPic.Size = new System.Drawing.Size(330, 262);
            this.pnlCarPic.TabIndex = 4;
            // 
            // dgvCarList
            // 
            this.dgvCarList.AllowUserToAddRows = false;
            this.dgvCarList.AllowUserToDeleteRows = false;
            this.dgvCarList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.Brand,
            this.Model,
            this.ProdYear,
            this.Transmission,
            this.Fuel,
            this.HourlyRentalPrice,
            this.ShowCar});
            this.dgvCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarList.Location = new System.Drawing.Point(0, 0);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.Size = new System.Drawing.Size(330, 337);
            this.dgvCarList.TabIndex = 0;
            // 
            // CarId
            // 
            this.CarId.HeaderText = "Identyfikator";
            this.CarId.Name = "CarId";
            this.CarId.ReadOnly = true;
            this.CarId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Marka";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProdYear
            // 
            this.ProdYear.HeaderText = "Rok produkcji";
            this.ProdYear.Name = "ProdYear";
            this.ProdYear.ReadOnly = true;
            this.ProdYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Transmission
            // 
            this.Transmission.HeaderText = "Skrzynia biegów";
            this.Transmission.Name = "Transmission";
            this.Transmission.ReadOnly = true;
            this.Transmission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fuel
            // 
            this.Fuel.HeaderText = "Paliwo";
            this.Fuel.Name = "Fuel";
            this.Fuel.ReadOnly = true;
            this.Fuel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HourlyRentalPrice
            // 
            this.HourlyRentalPrice.HeaderText = "Godzinna cena wypożyczenia";
            this.HourlyRentalPrice.Name = "HourlyRentalPrice";
            this.HourlyRentalPrice.ReadOnly = true;
            this.HourlyRentalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShowCar
            // 
            this.ShowCar.HeaderText = "Pokaż samochód";
            this.ShowCar.Name = "ShowCar";
            this.ShowCar.ReadOnly = true;
            // 
            // lblPicCar
            // 
            this.lblPicCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPicCar.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPicCar.Location = new System.Drawing.Point(22, 112);
            this.lblPicCar.Name = "lblPicCar";
            this.lblPicCar.Size = new System.Drawing.Size(286, 39);
            this.lblPicCar.TabIndex = 1;
            this.lblPicCar.Text = "Wybierz samochód by zobaczyć jego wygląd";
            this.lblPicCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectingCarForRentalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlReserv);
            this.Name = "SelectingCarForRentalUserControl";
            this.Size = new System.Drawing.Size(672, 429);
            this.pnlSelectedCarDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbCar)).EndInit();
            this.pnlCarList.ResumeLayout(false);
            this.pnlReserv.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTotalRentalPrice.ResumeLayout(false);
            this.pnlCarPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelectedCarDetails;
        private System.Windows.Forms.Panel pnlCarList;
        private System.Windows.Forms.Panel pnlReserv;
        private System.Windows.Forms.Button btnReserv;
        private System.Windows.Forms.PictureBox picbCar;
        private System.Windows.Forms.Label lblTotalRentalPrice;
        private System.Windows.Forms.Label lblTotalRentalPriceTag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCarPic;
        private System.Windows.Forms.Panel pnlTotalRentalPrice;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourlyRentalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ShowCar;
        private System.Windows.Forms.Label lblPicCar;
    }
}
