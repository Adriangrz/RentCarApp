
namespace RentCarWinFormsApp
{
    partial class HelloForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHello = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.pnlContinue = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlHello.SuspendLayout();
            this.pnlContinue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHello
            // 
            this.pnlHello.Controls.Add(this.lblHello);
            this.pnlHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHello.Location = new System.Drawing.Point(0, 0);
            this.pnlHello.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHello.Name = "pnlHello";
            this.pnlHello.Size = new System.Drawing.Size(686, 355);
            this.pnlHello.TabIndex = 0;
            // 
            // lblHello
            // 
            this.lblHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHello.Location = new System.Drawing.Point(0, 0);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(686, 355);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Witaj w aplikacji do wypożyczenia samochodu";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContinue
            // 
            this.pnlContinue.Controls.Add(this.btnContinue);
            this.pnlContinue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContinue.Location = new System.Drawing.Point(0, 355);
            this.pnlContinue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlContinue.Name = "pnlContinue";
            this.pnlContinue.Size = new System.Drawing.Size(686, 93);
            this.pnlContinue.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.Location = new System.Drawing.Point(268, 28);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 36);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Przejdź dalej";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.pnlHello);
            this.Controls.Add(this.pnlContinue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "HelloForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelloForm_FormClosing);
            this.pnlHello.ResumeLayout(false);
            this.pnlContinue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHello;
        private System.Windows.Forms.Panel pnlContinue;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnContinue;
    }
}