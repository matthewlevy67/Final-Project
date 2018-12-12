namespace WindowsFormsApp12
{
    partial class Total
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
            this.cmbB = new System.Windows.Forms.ComboBox();
            this.cmbL = new System.Windows.Forms.ComboBox();
            this.cmbD = new System.Windows.Forms.ComboBox();
            this.txtQtyB = new System.Windows.Forms.TextBox();
            this.txtQtyL = new System.Windows.Forms.TextBox();
            this.txtQtyD = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblSubTotalCal = new System.Windows.Forms.Label();
            this.lblTaxCal = new System.Windows.Forms.Label();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbB
            // 
            this.cmbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbB.FormattingEnabled = true;
            this.cmbB.Items.AddRange(new object[] {
            "Bar Mitzvah Bagel",
            "Vegitarian Platter",
            "Protein Platter"});
            this.cmbB.Location = new System.Drawing.Point(111, 111);
            this.cmbB.Name = "cmbB";
            this.cmbB.Size = new System.Drawing.Size(259, 39);
            this.cmbB.TabIndex = 0;
            // 
            // cmbL
            // 
            this.cmbL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbL.FormattingEnabled = true;
            this.cmbL.Items.AddRange(new object[] {
            "Bar Mitzvah Bagel",
            "Vegitarian Platter",
            "Protein Platter"});
            this.cmbL.Location = new System.Drawing.Point(111, 243);
            this.cmbL.Name = "cmbL";
            this.cmbL.Size = new System.Drawing.Size(259, 39);
            this.cmbL.TabIndex = 1;
            // 
            // cmbD
            // 
            this.cmbD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbD.FormattingEnabled = true;
            this.cmbD.Items.AddRange(new object[] {
            "Bar Mitzvah Bagel",
            "Vegitarian Platter",
            "Protein Platter"});
            this.cmbD.Location = new System.Drawing.Point(111, 375);
            this.cmbD.Name = "cmbD";
            this.cmbD.Size = new System.Drawing.Size(259, 39);
            this.cmbD.TabIndex = 2;
            // 
            // txtQtyB
            // 
            this.txtQtyB.Location = new System.Drawing.Point(496, 112);
            this.txtQtyB.Name = "txtQtyB";
            this.txtQtyB.Size = new System.Drawing.Size(149, 38);
            this.txtQtyB.TabIndex = 3;
            // 
            // txtQtyL
            // 
            this.txtQtyL.Location = new System.Drawing.Point(496, 244);
            this.txtQtyL.Name = "txtQtyL";
            this.txtQtyL.Size = new System.Drawing.Size(149, 38);
            this.txtQtyL.TabIndex = 4;
            // 
            // txtQtyD
            // 
            this.txtQtyD.Location = new System.Drawing.Point(496, 376);
            this.txtQtyD.Name = "txtQtyD";
            this.txtQtyD.Size = new System.Drawing.Size(149, 38);
            this.txtQtyD.TabIndex = 5;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(116, 547);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(137, 32);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Sub Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(116, 621);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(62, 32);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(116, 695);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 32);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total ";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(290, 459);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(229, 59);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblSubTotalCal
            // 
            this.lblSubTotalCal.AutoSize = true;
            this.lblSubTotalCal.Location = new System.Drawing.Point(290, 547);
            this.lblSubTotalCal.Name = "lblSubTotalCal";
            this.lblSubTotalCal.Size = new System.Drawing.Size(0, 32);
            this.lblSubTotalCal.TabIndex = 10;
            // 
            // lblTaxCal
            // 
            this.lblTaxCal.AutoSize = true;
            this.lblTaxCal.Location = new System.Drawing.Point(290, 621);
            this.lblTaxCal.Name = "lblTaxCal";
            this.lblTaxCal.Size = new System.Drawing.Size(0, 32);
            this.lblTaxCal.TabIndex = 11;
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Location = new System.Drawing.Point(284, 695);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(0, 32);
            this.lblTotalCal.TabIndex = 12;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(750, 112);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(34, 32);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "X";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(750, 246);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(34, 32);
            this.lblL.TabIndex = 14;
            this.lblL.Text = "X";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(750, 382);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(34, 32);
            this.lblD.TabIndex = 15;
            this.lblD.Text = "X";
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 812);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblTotalCal);
            this.Controls.Add(this.lblTaxCal);
            this.Controls.Add(this.lblSubTotalCal);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtQtyD);
            this.Controls.Add(this.txtQtyL);
            this.Controls.Add(this.txtQtyB);
            this.Controls.Add(this.cmbD);
            this.Controls.Add(this.cmbL);
            this.Controls.Add(this.cmbB);
            this.Name = "Total";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbB;
        private System.Windows.Forms.ComboBox cmbL;
        private System.Windows.Forms.ComboBox cmbD;
        private System.Windows.Forms.TextBox txtQtyB;
        private System.Windows.Forms.TextBox txtQtyL;
        private System.Windows.Forms.TextBox txtQtyD;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblSubTotalCal;
        private System.Windows.Forms.Label lblTaxCal;
        private System.Windows.Forms.Label lblTotalCal;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblD;
    }
}

